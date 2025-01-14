using MediatR;

namespace CQRSProject.MediatorDesignPattern.Results.CustomerResults
{
    public class GetCustomerQueryResult:IRequest
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
