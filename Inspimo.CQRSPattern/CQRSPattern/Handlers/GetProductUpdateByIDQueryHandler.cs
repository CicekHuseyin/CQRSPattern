using Inspimo.CQRSPattern.CQRSPattern.Queries;
using Inspimo.CQRSPattern.CQRSPattern.Results;
using Inspimo.CQRSPattern.DAL;

namespace Inspimo.CQRSPattern.CQRSPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductUpdateQueryResult Handle(GetProductUpdateByIDQuery query)
        {
            var values = _context.Products.Find(query.Id);
            return new GetProductUpdateQueryResult
            {
                ProductBrand = values.ProductBrand,
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                ProductPrice = values.ProductPrice,
                ProductStatus = true,
                ProductStock = values.ProductStock,
            };
        }
    }
}
