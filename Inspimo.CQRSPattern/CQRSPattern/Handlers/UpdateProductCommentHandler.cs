using Inspimo.CQRSPattern.CQRSPattern.Commends;
using Inspimo.CQRSPattern.DAL;

namespace Inspimo.CQRSPattern.CQRSPattern.Handlers
{
    public class UpdateProductCommentHandler
    {
        private readonly Context _context;

        public UpdateProductCommentHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.ProductBrand = command.ProductBrand;
            values.ProductName = command.ProductName;
            values.ProductPrice = command.ProductPrice;
            values.ProductStatus = true;
            values.ProductStock = command.ProductStock;
            _context.SaveChanges();
        }
    }
}
