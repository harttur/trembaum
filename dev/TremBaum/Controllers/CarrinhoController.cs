using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TremBaum.Helpers;
using TremBaum.Models;
using TremBaum.ViewModels;

namespace TremBaum.Controllers
{
    [Authorize]
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            var carrinho = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "Carrinho");
            ViewBag.Carrinho = carrinho;
            ViewBag.total = carrinho.Sum(item=>item.Produto.Preco*item.Quantidade);
            return View();
        }
        private int isExist(string id)
        {
            List<Item> carrinho = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "Carrinho");
            for (int i = 0; i < carrinho.Count;  i++)
            {
                if (carrinho[i].Produto.Id_produto.Equals(id))
                {  
                    return i; 
                }
            }
            return -1;
        }
        public IActionResult Comprar(string id)
        {
            ProdutoModel produtomodel = new ProdutoModel();
            if(SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "Carrinho") == null)
            {
                List<Item> carrinho = new List<Item>();
                carrinho.Add(new Item {Produto = produtomodel.find(id), Quantidade = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "Carrinho", carrinho);
            }
            else
            {
                List<Item> carrinho = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "Carrinho");
                int index = isExist(id);
                if(index != -1)
                {
                    carrinho[index].Quantidade++;
                }
                else
                {
                    carrinho.Add(new Item { Produto = produtomodel.find(id), Quantidade = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "Carrinho", carrinho);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Remover(string id)
        {
            List<Item> carrinho = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "Carrinho");
            int index = isExist(id);
            carrinho.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "Carrinho", carrinho);
            return RedirectToAction("Index");
        }
    }
}
