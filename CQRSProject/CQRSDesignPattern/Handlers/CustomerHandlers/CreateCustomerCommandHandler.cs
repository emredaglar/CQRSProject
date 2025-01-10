using CQRSProject.Context;
using CQRSProject.CQRSDesignPattern.Commands.CustomerCommands;
using CQRSProject.Entities;

namespace CQRSProject.CQRSDesignPattern.Handlers.CustomerHandlers
{
    public class CreateCustomerCommandHandler
    {
        private readonly CQRSContext _context;

        public CreateCustomerCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(CreateCustomerCommand command)
        {
            _context.Customers.Add(new Customer
            {
                CustomerName = command.CustomerName,
                CustomerSurname = command.CustomerSurname
            });
            _context.SaveChanges();
        }
    }
}
