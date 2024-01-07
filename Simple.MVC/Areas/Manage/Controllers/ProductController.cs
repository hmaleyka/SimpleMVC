using Microsoft.AspNetCore.Mvc;
using Simple.Business.Helpers;
using Simple.Business.Services.Interfaces;
using Simple.Business.ViewModels;

namespace Simple.MVC.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        private readonly IWebHostEnvironment _env;

        public ProductController(IProductService service , IWebHostEnvironment env)
        {
            _service = service;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            var products =  await _service.GetAllAsync();
            return View(products);
        }

        public  IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Create(CreateProductVM product)
        {
            string path = product.Image.Upload(_env.WebRootPath, @"/Upload/Product/");

            await _service.Create(product , path);
            return RedirectToAction("Index");
        }
    }
}
