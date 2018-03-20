using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlEntityFramework
{
    public class VendasContext : DbContext
    {
        public VendasContext(): base("MySqlVendas")
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
