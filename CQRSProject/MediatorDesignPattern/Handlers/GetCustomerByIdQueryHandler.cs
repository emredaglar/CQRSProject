using CQRSProject.Context;
using CQRSProject.MediatorDesignPattern.Queries;
using CQRSProject.MediatorDesignPattern.Results;
using MediatR;

namespace CQRSProject.MediatorDesignPattern.Handlers
{
	public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, GetCustomerByIdQueryResult>
	{
		private readonly CQRSContext _context;

		public GetCustomerByIdQueryHandler(CQRSContext context)
		{
			_context = context;
		}

		public async Task<GetCustomerByIdQueryResult> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _context.Customers.FindAsync(request.CustomerId);
			return new GetCustomerByIdQueryResult
			{
				CustomerName = values.CustomerName,
				CustomerSurname = values.CustomerSurname
			};
		}
	}
}
