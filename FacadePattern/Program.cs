using System;

namespace FacadePattern
{
    internal static class Program
    {
        /*
         * The Facade Pattern is a structural design pattern that provides a simplified
         * interface to a complex subsystem. It acts as a "front door," hiding the 
         * complexities of the subsystem from the client and providing an easy-to-use interface.
         */
        /*
         * Real-Life Example: Banking System
            When you open a bank account or perform a transaction like withdrawing cash 
        or transferring money, several steps happen in the background:

            Verify your identity (authentication).
            Check your account balance.
            Process the transaction (deduct or transfer money).
            Generate a receipt or update the transaction history.
            As a customer, you don't need to interact with each subsystem (e.g., 
        identity verification, balance checking, etc.) directly. Instead, you use a 
        simplified interface, like an ATM or mobile banking app, which acts as a Facade.
         */
        private static void Main()
        {
            // Create the facade
            BankingFacade bankingFacade = new BankingFacade();

            // Use the facade to perform a money transfer
            bankingFacade.TransferMoney("12345", "password", "67890", 500m);

            Console.WriteLine();

            // Attempt with insufficient funds
            bankingFacade.TransferMoney("12345", "password", "67890", 1500m);
        }
    }
}
