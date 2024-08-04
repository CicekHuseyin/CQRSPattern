using Inspimo.CQRSPattern.CQRSPattern.Commends;
using Inspimo.CQRSPattern.DAL;

namespace Inspimo.CQRSPattern.CQRSPattern.Handlers
{
    public class CreateProductCommentHandler
    {
        private readonly Context _context;

        public CreateProductCommentHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateProductCommand command)
        {
            var values = _context.Products.Add(new Product
            {
                ProductBrand = command.ProductBrand,
                ProductName = command.ProductName,
                ProductStatus = true,
                ProductStock= command.ProductStock,
                ProductPrice= command.ProductPrice
            });
            _context.SaveChanges();

        }
    }
}
