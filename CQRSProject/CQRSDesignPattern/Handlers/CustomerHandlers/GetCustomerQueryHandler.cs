using CQRSProject.Context;
using CQRSProject.CQRSDesignPattern.Results.CustomerResults;

namespace CQRSProject.CQRSDesignPattern.Handlers.CustomerHandlers
{
    public class GetCustomerQueryHandler
    {
        private readonly CQRSContext _context;

        public GetCustomerQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public List<GetCustomerQueryResult> Handle()
        {
            var values = _context.Customers.Select(x => new GetCustomerQueryResult
            {
                CustomerId = x.CustomerId,
                CustomerName = x.CustomerName,
                CustomerSurname = x.CustomerSurname,
            });
            return values.ToList();
        }
    }
}
