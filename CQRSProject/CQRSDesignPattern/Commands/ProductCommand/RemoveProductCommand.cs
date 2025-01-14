namespace CQRSProject.CQRSDesignPattern.Commands.ProductCommand
{
    public class RemoveProductCommand
    {
        public int ProductId { get; set; }

		public RemoveProductCommand(int productId)
		{
			ProductId = productId;
		}
	}
}
