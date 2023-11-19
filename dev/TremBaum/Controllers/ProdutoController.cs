using Microsoft.AspNetCore.Mvc;
using TremBaum.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace TremBaum.Controllers
{
    [Authorize]
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            ProdutoModel produtoModel = new ProdutoModel();
            ViewBag.Produto = produtoModel.findAll();
            return View();
        }
    }
}
