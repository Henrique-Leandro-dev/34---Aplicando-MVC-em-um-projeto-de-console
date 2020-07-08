using System.Collections.Generic;
using MvcConsole.Models;
using MvcConsole.Views;

namespace MvcConsole.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar()
        {
            List<Produto> lista = produtoModel.Ler();
            produtoView.MostrarNoConsole(lista);
        }

        public void Buscar(string termo)
        {
            List<Produto> lista = produtoModel.Ler().FindAll(x => x.Preco == float.Parse(termo));
            produtoView.MostrarNoConsole(lista);
        }

    }
}