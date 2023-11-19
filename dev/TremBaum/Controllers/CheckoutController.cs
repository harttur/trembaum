using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TremBaum.Helpers;
using TremBaum.Models;

namespace TremBaum.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            var carrinho = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "Carrinho");
            ViewBag.carrinho = carrinho;
            ViewBag.total = carrinho.Sum(item => item.Produto.Preco * item.Quantidade);
            return View();
        }
    }
}
