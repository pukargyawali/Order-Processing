using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using OrderProcess.Repositories;
using OrderProcess.Models;
using OrderProcess.BusinessLayer.Interfaces;
using OrderProcess.Common;

namespace OrderProcess.BusinessLayer
{
    public class OrderProcessService
    {
        private IInventoryRepository invRepo;
        private IOrderRepository orderRepo;
        private IEmailService emailService;
        private IPaymentGateway paymentGateway;

        public OrderProcessService(IInventoryRepository invRepo,
                                   IOrderRepository orderRepo,
                                   IEmailService emailService,
                                   IPaymentGateway paymentGateway)
        {
            this.invRepo = invRepo;
            this.orderRepo = orderRepo;
            this.emailService = emailService;
            this.paymentGateway = paymentGateway;
        }

        public bool ProcessOrder(Order order)
        {
            bool isSuccessful = false;

            // validates order such as products, credit card and availability of product in the inventory. 
            OrderValidation validation = new OrderValidation(invRepo, orderRepo);
            bool isValidOrder = validation.ValidateOrder(order);

            if (isValidOrder)
            {
                // validates the credit card info. 
                CreditCardValidation ccValidation = new CreditCardValidation();
                bool isValidCC = ccValidation.ValidateCard(order.CreditCard);
               

                // start processing order in transaction such as inserting order record to DB and update the inventory and charge the card.  
                using (TransactionScope scope = new TransactionScope())
                {
                    try
                    {
                        // insert to DB first.   
                        order.Status = OrderStatus.OrderPlaced;
                        orderRepo.Add(order);

                        // update the inventory for each product in the order. 
                        foreach (Product product in order.Products)
                        {
                            invRepo.UpdateInventory(product.ID, product.QuantityOrdered.Quantity);
                        }

                        // charge credit card                     
                        if (paymentGateway.ChargePayment(order.CreditCard.CreditCardNumber, order.Amount))
                        {
                            isSuccessful = true;
                            scope.Complete();
                            NotifyOrder(order);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log the exception and send the email to support.  
                        emailService.SendEmail("support@thecomoany.com", "Order Processing Failed", String.Format("Order Processing failed with exception : {0}", ex.ToString()));
                    }
                }
            }

            return isSuccessful;
        }

        /// <summary>
        /// Notify the departments in the list such as Sale to notify that an order has been placed. 
        /// </summary>
        /// <param name="order"></param>
        private void NotifyOrder(Order order)
        {
            // send email if the transaction completes successfully.   

            string emailContent = Utilities.GetContentForOrder(order);
            string subject = Utilities.GetEmailSubjectForOrder(order);

            // Notify all the departments in the list
            foreach (Department department in order.DepartmentsToNotify)
            {
                emailService.SendEmail(department.Email, subject, emailContent);
            }
        }
    }
}
