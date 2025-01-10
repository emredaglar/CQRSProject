using CQRSProject.Context;
using CQRSProject.CQRSDesignPattern.Queries.CategoryQueries;
using CQRSProject.CQRSDesignPattern.Results.CategoryResults;

namespace CQRSProject.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly CQRSContext _context;

        public GetCategoryByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public GetCategoryByIdQueryResult Handle(GetCategoryByIdQuery query)
        {
            var value = _context.Categories.Find(query.CategoryId);
            return new GetCategoryByIdQueryResult
            {
                CategoryId = value.CategoryId,
                CategoryName = value.CategoryName,
            };
        }
    }
}
