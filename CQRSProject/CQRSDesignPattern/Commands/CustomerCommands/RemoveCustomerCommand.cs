﻿namespace CQRSProject.CQRSDesignPattern.Commands.CustomerCommands
{
    public class RemoveCustomerCommand
    {
        public int CustomerId { get; set; }

        public RemoveCustomerCommand(int customerId)
        {
            CustomerId = customerId;
        }
    }
}
