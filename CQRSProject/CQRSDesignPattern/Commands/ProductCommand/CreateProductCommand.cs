namespace CQRSProject.CQRSDesignPattern.Commands.ProductCommand
{
    public class CreateProductCommand
    {
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public int CategoryId { get; set; }
    }
}
