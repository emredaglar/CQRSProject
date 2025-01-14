using CQRSProject.Context;
using CQRSProject.MediatorDesignPattern.Queries;
using CQRSProject.MediatorDesignPattern.Results.CustomerResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSProject.MediatorDesignPattern.Handlers
{
	public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, List<GetCustomerQueryResult>>
	{
		private readonly CQRSContext _context;

		public GetCustomerQueryHandler(CQRSContext context)
		{
			_context = context;
		}

		public async Task<List<GetCustomerQueryResult>> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
		{
			return await _context.Customers.Select(x => new GetCustomerQueryResult
			{
				CustomerId = x.CustomerId,
				CustomerName = x.CustomerName,
				CustomerSurname = x.CustomerSurname
			}).AsNoTracking().ToListAsync();
		}
	}
}
