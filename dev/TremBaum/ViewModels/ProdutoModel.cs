using TremBaum.Controllers;
using TremBaum.Models;

namespace TremBaum.ViewModels
{
    public class ProdutoModel
    {
        public List<Produto> _produtos { get; set; }

        public List<Produto> findAll()
        {
            _produtos = new List<Produto>
            {
                new Produto()
                {
                    Id_produto = "1",
                    Nome = "Sabor de Minas 670 ML",
                    Preco = 55.90,
                    Foto = "Produto01.jpeg"
                },
                new Produto()
                {
                    Id_produto = "2",
                    Nome = "Doce de Leite DOM",
                    Preco = 25.00,
                    Foto = "Produto02.jpeg"
                },
                new Produto()
                {
                    Id_produto = "3",
                    Nome = "Café Mineiro 500G",
                    Preco = 17.59,
                    Foto = "Produto03.jpeg"
                },
                new Produto()
                {
                    Id_produto = "4",
                    Nome = "Geléia de Mocotó Mineira Artesanal",
                    Preco = 22.10,
                    Foto = "Produto04.jpeg"
                },
                new Produto()
                {
                    Id_produto = "5",
                    Nome = "Pão de Queijo 1KG",
                    Preco = 20.09,
                    Foto = "Produto05.jpeg"
                },
                new Produto()
                {
                    Id_produto = "6",
                    Nome = "Goiabada Lisa 1KG",
                    Preco = 23.99,
                    Foto = "Produto06.jpeg"
                },
                new Produto()
                {
                    Id_produto = "7",
                    Nome = "Queijo Minas 450g",
                    Preco = 35.99,
                    Foto = "Produto07.jpeg"
                },
                new Produto()
                {
                    Id_produto = "8",
                    Nome = "Queijo Canastra",
                    Preco = 65.94,
                    Foto = "Produto08.jpeg"
                },
                new Produto()
                {
                    Id_produto = "9",
                    Nome = "Torresmo Pururuca",
                    Preco = 5.50,
                    Foto = "Produto09.jpeg"
                }
            };

            return _produtos;
        }

        public Produto find(string id)
        {
            List<Produto> produtos = findAll();
            var prod = produtos.Where(a => a.Id_produto == id).FirstOrDefault();
            return prod;
        }
    }
}