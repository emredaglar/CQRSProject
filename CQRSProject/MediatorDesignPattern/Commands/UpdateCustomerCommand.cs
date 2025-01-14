using MediatR;

namespace CQRSProject.MediatorDesignPattern.Commands
{
    public class UpdateCustomerCommand:IRequest
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
