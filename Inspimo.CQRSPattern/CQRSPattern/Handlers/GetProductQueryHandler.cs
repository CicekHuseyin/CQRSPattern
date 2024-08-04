using Inspimo.CQRSPattern.CQRSPattern.Results;
using Inspimo.CQRSPattern.DAL;

namespace Inspimo.CQRSPattern.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                ProductBrand = x.ProductBrand,
                ProductPrice = x.ProductPrice,
                ProductID = x.ProductID,
                ProductStatus = x.ProductStatus,
                ProductStock = x.ProductStock,
                Name = x.ProductName
            }).ToList();
            return values;
        }
    }
}
