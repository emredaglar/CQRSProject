﻿namespace CQRSProject.CQRSDesignPattern.Commands.ProductCommand
{
    public class UpdateProductCommand
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public int CategoryId { get; set; }
    }
}
