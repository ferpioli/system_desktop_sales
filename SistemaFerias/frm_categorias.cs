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
    public partial class frm_categorias : Form
    {
        public frm_categorias()
        {
            InitializeComponent();
        }

        private void frm_categorias_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.AddNew();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {
                this.categoriaBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria inserida com sucesso!");
            }
        }

        private bool valida()//valida preenchimento de campo
        {
            if (txt_Categoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O Campo Categoria é obrigatorio");
                txt_Categoria.Focus();
                return false;

            }
            return true;
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que deseja excluir?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.categoriaPossuiProduto(this.categoriaAtual))
                {
                    MessageBox.Show("A categoria possui produtos");
                }
                else
                {

                    this.categoriaBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria Excluida com sucesso");
                }
            }

        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
        }

        public Categorias categoriaAtual
        {
            get
            {

                return (Categorias)this.categoriaBindingSource.Current;
            }
        }

        private bool categoriaPossuiProduto(Categorias categoria)
        {
            var Produtos = DataContextFactory.DataContext.Produtos.Where(x => x.CodigoCategoria == categoria.Codigo);
            if (Produtos.Count() > 0)
                return true;

            else
                return false;

        }

    }
}
