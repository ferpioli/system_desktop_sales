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
    public partial class frm_Produtos : Form
    {
        public frm_Produtos()
        {
            InitializeComponent();
        }

        private void frm_Produtos_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos;
            this.categoriasBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.AddNew();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        { if (this.valida())
            {
                this.produtoBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Categoria inserida com sucesso!");
            }

        }

        private bool valida()
        {
            if (txt_Descricao.Text.Trim() == string.Empty )
            {
                MessageBox.Show("O campo descrição é obrigatorio");
                txt_Descricao.Focus();
                return false;
            }
            return true;
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmacao",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                this.produtoBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria Excluida com sucesso!");
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.CancelEdit();

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((Categorias)e.Value).Descricao;
        }
    }
}
