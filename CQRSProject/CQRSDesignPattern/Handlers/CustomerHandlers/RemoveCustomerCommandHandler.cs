using CQRSProject.Context;
using CQRSProject.CQRSDesignPattern.Commands.CustomerCommands;

namespace CQRSProject.CQRSDesignPattern.Handlers.CustomerHandlers
{
    public class RemoveCustomerCommandHandler
    {
        private readonly CQRSContext _context;

        public RemoveCustomerCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(RemoveCustomerCommand command)
        {
            var value = _context.Customers.Find(command.CustomerId);
            _context.Customers.Remove(value);
            _context.SaveChanges();
        }
    }
}
