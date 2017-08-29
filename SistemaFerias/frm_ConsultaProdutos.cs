using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistemas.DAL;

namespace SistemaFerias
{
    public partial class frm_ConsultaProdutos : Form
    {
        public frm_ConsultaProdutos()
        {
            InitializeComponent();
        }

        private void frm_ConsultaProdutos_Load(object sender, EventArgs e)
        {
            this.categoriasBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)cmb_Pesquisar.SelectedValue);

        }

        public void Pesquisar(int codigoCategoria)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos.Where(x => x.CodigoCategoria == codigoCategoria);
        }
    }
}
