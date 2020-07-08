using System;
using MvcConsole.Controllers;
using MvcConsole.Views;

namespace MvcConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtos = new ProdutoController();
            produtos.Buscar("200,56");
        }
    }
}
