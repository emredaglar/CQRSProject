using MediatR;

namespace CQRSProject.MediatorDesignPattern.Results
{
    public class GetCustomerByIdQueryResult:IRequest
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
