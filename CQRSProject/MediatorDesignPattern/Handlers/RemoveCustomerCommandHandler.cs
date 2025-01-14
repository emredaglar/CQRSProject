using CQRSProject.Context;
using CQRSProject.MediatorDesignPattern.Commands;
using MediatR;

namespace CQRSProject.MediatorDesignPattern.Handlers
{
	public class RemoveCustomerCommandHandler : IRequestHandler<RemoveCustomerCommand>
	{
		private readonly CQRSContext _context;

		public RemoveCustomerCommandHandler(CQRSContext context)
		{
			_context = context;
		}

		public async Task Handle(RemoveCustomerCommand request, CancellationToken cancellationToken)
		{
			var value = _context.Customers.Find(request.CustomerId);
			_context.Customers.Remove(value);
			await _context.SaveChangesAsync();
		}
	}
}
