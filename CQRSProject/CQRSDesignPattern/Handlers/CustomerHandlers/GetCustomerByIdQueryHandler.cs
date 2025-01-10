using CQRSProject.Context;
using CQRSProject.CQRSDesignPattern.Queries.CustomerQueries;
using CQRSProject.CQRSDesignPattern.Results.CategoryResults;
using CQRSProject.CQRSDesignPattern.Results.CustomerResults;

namespace CQRSProject.CQRSDesignPattern.Handlers.CustomerHandlers
{
    public class GetCustomerByIdQueryHandler
    {
        private readonly CQRSContext _context;

        public GetCustomerByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public GetCustomerByIdQueryResult Handle(GetCustomerByIdQuery query)
        {
            var value=_context.Customers.Find(query.CustomerId);
            return new GetCustomerByIdQueryResult
            {
                CustomerId = value.CustomerId,
                CustomerName = value.CustomerName,
                CustomerSurname=value.CustomerSurname,  

            };
        }
    }
}
