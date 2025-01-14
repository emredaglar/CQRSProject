using CQRSProject.MediatorDesignPattern.Results;
using MediatR;

namespace CQRSProject.MediatorDesignPattern.Queries
{
	public class GetCustomerByIdQuery:IRequest<GetCustomerByIdQueryResult>
	{
        public int CustomerId { get; set; }

		public GetCustomerByIdQuery(int customerId)
		{
			CustomerId = customerId;
		}
	}
}
