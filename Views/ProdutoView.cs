using System;
using System.Collections.Generic;
using MvcConsole.Models;

namespace MvcConsole.Views
{
    public class ProdutoView
    {
        public void MostrarNoConsole(List<Produto> lista)
        {
            foreach (Produto item in lista)
            {
                Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }
        }
    }
}