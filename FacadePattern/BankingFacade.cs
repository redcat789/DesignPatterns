using FacadePattern.Subsystem;
using System;

namespace FacadePattern
{
    public class BankingFacade
    {
        private readonly Authentication _authentication;
        private readonly Account _account;
        private readonly Transaction _transaction;
        private readonly Notification _notification;

        public BankingFacade()
        {
            _authentication = new Authentication();
            _account = new Account();
            _transaction = new Transaction();
            _notification = new Notification();
        }

        public void TransferMoney(string accountNumber, string password, string recipientAccount, decimal amount)
        {
            Console.WriteLine("Starting money transfer process...");

            if (!_authentication.AuthenticateUser(accountNumber, password))
            {
                Console.WriteLine("Authentication failed. Transaction aborted.");
                return;
            }

            decimal balance = _account.GetBalance(accountNumber);
            if (balance < amount)
            {
                Console.WriteLine("Insufficient funds. Transaction aborted.");
                return;
            }

            _account.DeductBalance(accountNumber, amount);
            _transaction.Process(accountNumber, recipientAccount, amount);
            _notification.SendNotification(accountNumber, $"You have transferred {amount:C} to {recipientAccount}.");
        }
    }

}
