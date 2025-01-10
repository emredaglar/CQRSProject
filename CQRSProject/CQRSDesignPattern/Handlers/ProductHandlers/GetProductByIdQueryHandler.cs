using CQRSProject.Context;
using CQRSProject.CQRSDesignPattern.Queries.ProductQueries;
using CQRSProject.CQRSDesignPattern.Results.ProductResults;

namespace CQRSProject.CQRSDesignPattern.Handlers.ProductHandlers
{
    //query dışarıdan gönderilen parametreyi tutar
    public class GetProductByIdQueryHandler
    {
        private readonly CQRSContext _context;

        public GetProductByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var value = _context.Products.Find(query.ProductId);
            return new GetProductByIdQueryResult
            {
                ProductId = value.ProductId,
                CategoryId = value.CategoryId,
                ProductName = value.ProductName,
                ProductStock = value.ProductStock
            };
        }
    }
}
