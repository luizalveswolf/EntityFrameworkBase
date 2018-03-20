using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGreSqlEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            ProdutoContext dbContext = new ProdutoContext();

            dbContext.Produtos.ToList().ForEach(p => Console.WriteLine(p.Nome));
        }
    }
}
