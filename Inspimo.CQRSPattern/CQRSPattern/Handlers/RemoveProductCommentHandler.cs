using Inspimo.CQRSPattern.CQRSPattern.Commends;
using Inspimo.CQRSPattern.DAL;

namespace Inspimo.CQRSPattern.CQRSPattern.Handlers
{
    public class RemoveProductCommentHandler
    {
        private readonly Context _context;

        public RemoveProductCommentHandler(Context context)
        {
            _context = context;
        }
        public void Handle(RemoveProductCommand command) 
        {
            var values=_context.Products.Find(command.Id);
            _context.Products.Remove(values);
            _context.SaveChanges();
        }
    }
}
