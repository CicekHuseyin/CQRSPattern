using Inspimo.CQRSPattern.CQRSPattern.Commends;
using Inspimo.CQRSPattern.CQRSPattern.Handlers;
using Inspimo.CQRSPattern.CQRSPattern.Queries;
using Inspimo.CQRSPattern.CQRSPattern.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Inspimo.CQRSPattern.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly GetProductByIDQueryHandler _getProductByIDQueryHandler;
        private readonly CreateProductCommentHandler _createProductCommentHandler;
        private readonly RemoveProductCommentHandler _removeProductCommentHandler;
        private readonly GetProductUpdateByIDQueryHandler _getProductUpdateByIDQueryHandler;
        private readonly UpdateProductCommentHandler _updateProductCommentHandler;

        public DefaultController(GetProductQueryHandler getProductQueryHandler, GetProductByIDQueryHandler getProductByIDQueryHandler, CreateProductCommentHandler createProductCommentHandler, RemoveProductCommentHandler removeProductCommentHandler, GetProductUpdateByIDQueryHandler getProductUpdateByIDQueryHandler, UpdateProductCommentHandler updateProductCommentHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _getProductByIDQueryHandler = getProductByIDQueryHandler;
            _createProductCommentHandler = createProductCommentHandler;
            _removeProductCommentHandler = removeProductCommentHandler;
            _getProductUpdateByIDQueryHandler = getProductUpdateByIDQueryHandler;
            _updateProductCommentHandler = updateProductCommentHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
        public IActionResult GetProduct(int id) 
        {
            var values = _getProductByIDQueryHandler.Handle(new GetProductByIDQuery(id));
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommentHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int id)
        {
            _removeProductCommentHandler.Handle(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = _getProductUpdateByIDQueryHandler.Handle(new GetProductUpdateByIDQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
            _updateProductCommentHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
