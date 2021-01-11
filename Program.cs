using System;
using System.Collections.Generic;
using _16_12___Listas_de_objetos.classes;

namespace _16_12___Listas_de_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            Produto cafe = new Produto(2, "Café pequeno", 3.5f);

            produtos.Add(new Produto(1, "Pão na chapa", 2.5f));
            produtos.Add(cafe);
            produtos.Add(new Produto(3, "Coxinha", 5.5f));

        foreach (var item in produtos)
        {
            Console.WriteLine($"Item codigo {item.Codigo} Nome {item.Nome} Preço {item.Preco}");
        }
        }
    }
}
