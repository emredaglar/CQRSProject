
using CQRSProject.MediatorDesignPattern.Results.CustomerResults;
using MediatR;

namespace CQRSProject.MediatorDesignPattern.Queries
{
	public class GetCustomerQuery:IRequest<List<GetCustomerQueryResult>>
	{
	}
}
