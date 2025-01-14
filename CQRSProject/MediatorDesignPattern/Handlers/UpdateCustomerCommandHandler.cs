using CQRSProject.Context;
using CQRSProject.MediatorDesignPattern.Commands;
using MediatR;

namespace CQRSProject.MediatorDesignPattern.Handlers
{
	public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
	{
		private readonly CQRSContext _context;

		public UpdateCustomerCommandHandler(CQRSContext context)
		{
			_context = context;
		}

		public async Task Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
		{
			var values = _context.Customers.Find(request.CustomerId);
			values.CustomerSurname=request.CustomerSurname;
			values.CustomerName=request.CustomerName;
			await _context.SaveChangesAsync();
		}
	}
}
