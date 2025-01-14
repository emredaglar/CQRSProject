using CQRSProject.CQRSDesignPattern.Commands.CategoryCommands;
using CQRSProject.CQRSDesignPattern.Handlers.CategoryHandlers;
using CQRSProject.CQRSDesignPattern.Queries.CategoryQueries;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler;
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
        private readonly CreateCategoryCommandHandler _createCategoryCommandHandler;
        private readonly RemoveCategoryCommandHandler _removeCategoryCommandHandler;
        private readonly UpdateCategoryCommandHandler _updateCategoryCommandHandler;

        public CategoryController(GetCategoryByIdQueryHandler getCategoryByIdQueryHandler, GetCategoryQueryHandler getCategoryQueryHandler, CreateCategoryCommandHandler createCategoryCommandHandler, RemoveCategoryCommandHandler removeCategoryCommandHandler, UpdateCategoryCommandHandler updateCategoryCommandHandler)
        {
            _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
            _getCategoryQueryHandler = getCategoryQueryHandler;
            _createCategoryCommandHandler = createCategoryCommandHandler;
            _removeCategoryCommandHandler = removeCategoryCommandHandler;
            _updateCategoryCommandHandler = updateCategoryCommandHandler;
        }

        public IActionResult CategoryList()
        {
            var values = _getCategoryQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryCommand command)// category entity yerine CreateCategoryCommand yazdık-resultta buna benzer ama get işlemlerini tutar. ikisinide entity benzet
          //query dışarıdan gönderilen parametreyi tutar
        {
            _createCategoryCommandHandler.Handle(command);
            return RedirectToAction("CategoryList");
        }
        public IActionResult DeleteCategory(int id)
        {
            _removeCategoryCommandHandler.Handle(new RemoveCategoryCommand(id));
            return RedirectToAction("CategoryList");
        }
		[HttpGet]
		public IActionResult UpdateCategory(int id)
		{
			var value = _getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQuery(id));
			return View(value);
		}

		[HttpPost]
		public IActionResult UpdateCategory(UpdateCategoryCommand command)
		{
			_updateCategoryCommandHandler.Handle(command);
			return RedirectToAction("CategoryList");
		}
		[HttpGet]
        public IActionResult GetByIdCategory()
        {
            return View();
        }
    }
}
