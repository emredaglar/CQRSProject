using CQRSProject.Context;
using CQRSProject.Entities;
using CQRSProject.MediatorDesignPattern.Commands;
using CQRSProject.Migrations;
using MediatR;

namespace CQRSProject.MediatorDesignPattern.Handlers
{
	public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand>
	{
		private readonly CQRSContext _context;

		public CreateCustomerCommandHandler(CQRSContext context)
		{
			_context = context;
		}

		public async Task Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
		{
			_context.Customers.Add(new Customer
			{
				CustomerName = request.CustomerName,
				CustomerSurname = request.CustomerSurname
			});
			await _context.SaveChangesAsync();
		}
	}
}
