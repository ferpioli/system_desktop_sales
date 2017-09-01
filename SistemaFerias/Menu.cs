using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFerias
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_Cad_Produtos_Click(object sender, EventArgs e)
        {
            frm_Produtos frm = new frm_Produtos();
            frm.Show();
        }

        private void btn_Cad_Categorias_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Produtos frm = new frm_Produtos();
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ConsultaProdutos frm = new frm_ConsultaProdutos();
            frm.Show();
        }

        

        private void veToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Venda frm = new frm_Venda();
            frm.Show();
        }

        private void produtosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_rel_produtos frm = new frm_rel_produtos();
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
