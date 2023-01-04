using BlockIoLib;
using HIN_Ventures.Models.Entities;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using System.Drawing;
using System.Globalization;

namespace HIN_Ventures.Services
{
    public class PaymentService
    {

        public static readonly string HIN_ACCOUNT_ADDRESS = "2Mz8gC1F5Yyh4WyMX4F5ZSz3LemRttFFLTT";
        private BlockIo blockIo;
        public PaymentService()
        {
                blockIo = new BlockIo("67c8-ed6e-0ef0-4c5d",
                "jkh55NJKn14kn4knk");
        }


        public void TransferMoneyToHinVentures(Customer customer, Freelancer freelancer,
            double amount, Assignment assignment)
        {

            double discount = 1.0;
            if (customer.Subscription != null)
            {
                if (customer.Subscription?.SubscriptionId == 1)
                    discount = 0.9;
                else if (customer.Subscription?.SubscriptionId == 2)
                    discount = 0.75;
                else if (customer.Subscription?.SubscriptionId == 3)
                    discount = 0.6;
                
            }
            
            var price = amount * discount;

            var customerAccountAddress = customer.AccountAddress;

            if (customerAccountAddress != null)
            {
                var prepareTransactionApiResponse = blockIo.PrepareTransaction(new
                {
                    amounts = price.ToString(CultureInfo.InvariantCulture),
                    from_addresses = customerAccountAddress,
                    to_addresses = HIN_ACCOUNT_ADDRESS
                });

                try
                {
                    var transactionApiResponse = blockIo.CreateAndSignTransaction(prepareTransactionApiResponse);
                    blockIo.SubmitTransaction(new { transaction_data = transactionApiResponse });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                
                
            }

        }

        public double GetBalance(string accountAddress)
        {
            var balance = blockIo.GetAddressBalance(new { addresses = accountAddress });
            var result = balance.Data.ToString();
            return result;

        }

        public void TransferMoneyFromHinToFreelancer(Freelancer freelancer, double amount, 
            Assignment assignment)
        {
            var freelancerAccountAddress = freelancer.AccountAddress;

            if (freelancerAccountAddress != null)
            {
                var prepareTransactionApiResponse = blockIo.PrepareTransaction(new
                {
                    amounts = amount.ToString(CultureInfo.InvariantCulture),
                    from_addresses = HIN_ACCOUNT_ADDRESS,
                    to_addresses = freelancerAccountAddress
                });

                var transactionApiResponse = blockIo.CreateAndSignTransaction(prepareTransactionApiResponse);
                blockIo.SubmitTransaction(new { transaction_data = transactionApiResponse });

            } 
        }

    }
}
