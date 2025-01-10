using CQRSProject.Context;
using CQRSProject.CQRSDesignPattern.Results.ProductResults;

namespace CQRSProject.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class GetProductQueryHandler
    {
        private readonly CQRSContext _context;

        public GetProductQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        //public List<GetProductQueryResult> Handle()
        //{
        //    var values=_context.Products
        //}
    }
}
