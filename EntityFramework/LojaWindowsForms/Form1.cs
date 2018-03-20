using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaWindowsForms
{
    public partial class Form1 : Form
    {

        private ProductDbContext context;

        public Form1()
        {
            InitializeComponent();
            context = new ProductDbContext();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja()
            {
                Nome = "Loja ActionsFigures"
            };

            context.Lojas.Add(loja);

            //insert
            Produto produto = new Produto()
            {
                Nome = "Barbi",
                Valor = 35m,
                Descricao = "Boneca",
                Loja = loja
                
            };

            context.Produtos.Add(produto);

            context.SaveChanges();
            MessageBox.Show("Produto Inserido com sucesso!");
        }

        private void btnInsertSelect_Click(object sender, EventArgs e)
        {
            //busca a loja
            Loja loja = context.Lojas.Find(3);

            Produto novoProduto = new Produto()
            {
                Nome = "Carros De Ação",
                Valor = 50,
                LojaId = loja.Id,
                Loja = loja
            };

            //add o produto
            context.Produtos.Add(novoProduto);
            //perssistir o produto
            context.SaveChanges();
            MessageBox.Show("Produto Inserido com sucesso!");
        }

        private void btnSelectLojaProduto_Click(object sender, EventArgs e)
        {
            //buscar produto
            Produto produto = context.Produtos.Find(4);

            //os dados estao interligados
            Loja lojaProduto = produto.Loja;
        }

        private void btnSelectWhere_Click(object sender, EventArgs e)
        {
            IEnumerable<Produto> produtosComecaodsComA =
                context.Produtos.Where(p => p.Nome.StartsWith("B"));

            IEnumerable<Produto> produtoDaLoja =
                 context.Produtos.Where(p => p.LojaId == 3);
           
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //busca a loja
            Loja loja = context.Lojas.Find(3);
            loja.Nome = "Trocando o nome de novo";

            Produto produto = context.Produtos.Find(4);
            produto.Nome = "To fudido";

            context.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Loja loja = context.Lojas.Find(3);
            context.Lojas.Remove(loja);
            context.SaveChanges();
        }

        private void btnUpdateEntityState_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto()
            {
                Id = 2,
                Nome = "Teste",
                LojaId = 1
            };

            context.Entry(produto).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
