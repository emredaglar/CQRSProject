using CQRSProject.CQRSDesignPattern.Commands.ProductCommand;
using CQRSProject.CQRSDesignPattern.Handlers.ProductHandlers;
using CQRSProject.CQRSDesignPattern.Queries.ProductQueries;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Printing;

namespace CQRSProject.Controllers
{
	public class ProductController : Controller
	{
		private readonly CreateProductCommandHandler _createProductCommandHandler;
		private readonly UpdateProductCommandHandler _updateProductCommandHandler;
		private readonly RemoveProductCommandHandler _removeProductCommandHandler;
		private readonly GetProductQueryHandler _getProductQueryHandler;
		private readonly GetProductByIdQueryHandler _getProductByIdQueryHandler;

		public ProductController(CreateProductCommandHandler createProductCommandHandler, UpdateProductCommandHandler updateProductCommandHandler, RemoveProductCommandHandler removeProductCommandHandler, GetProductQueryHandler getProductQueryHandler, GetProductByIdQueryHandler getProductByIdQueryHandler)
		{
			_createProductCommandHandler = createProductCommandHandler;
			_updateProductCommandHandler = updateProductCommandHandler;
			_removeProductCommandHandler = removeProductCommandHandler;
			_getProductQueryHandler = getProductQueryHandler;
			_getProductByIdQueryHandler = getProductByIdQueryHandler;
		}

		public IActionResult ProductList()
		{
			var values = _getProductQueryHandler.Handle();
			return View();
		}
		[HttpPost]
		public IActionResult CreateProduct(CreateProductCommand command)
		{
			_createProductCommandHandler.Handle(command);
			return RedirectToAction("ProdctList");
		}
		public ActionResult DeleteProduct(int id)
		{
			_removeProductCommandHandler.Handle(new RemoveProductCommand(id));
			return RedirectToAction("ProdctList");
		}
		[HttpGet]
		public ActionResult UpdateProduct(int id)
		{
			var value = _getProductByIdQueryHandler.Handle(new GetProductByIdQuery(id));
			return View(value);
		}
		[HttpPost]
		public ActionResult UpdateProduct(UpdateProductCommand command)
		{
			//var value = UpdateProductCommandHandler.Handle(command);
			return RedirectToAction("ProdctList");
		}
	}
}