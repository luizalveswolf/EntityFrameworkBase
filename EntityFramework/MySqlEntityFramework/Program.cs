using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            VendasContext vendasContext = new VendasContext();

            Produto produto = new Produto()
            {
                Nome = "smartphone",
                Preco = 1800
            };

            vendasContext.Produtos.Add(produto);
            vendasContext.SaveChanges();


        }
    }
}
