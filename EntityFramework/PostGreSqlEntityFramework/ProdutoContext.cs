using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGreSqlEntityFramework
{
    class ProdutoContext :DbContext
    {
        public ProdutoContext():base("PgProdutos")
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
