using CQRSProject.Context;
using CQRSProject.CQRSDesignPattern.Commands.CategoryCommands;
using CQRSProject.CQRSDesignPattern.Commands.CustomerCommands;

namespace CQRSProject.CQRSDesignPattern.Handlers.CustomerHandlers
{
    public class UpdateCustomerCommandHandler
    {
        private readonly CQRSContext _context;

        public UpdateCustomerCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(UpdateCustomerCommand command)
        {
            var value = _context.Customers.Find(command.CustomerId);
            value.CustomerName = command.CustomerName;
            value.CustomerSurname = command.CustomerSurname;
            _context.SaveChanges();
        }
    }
}
