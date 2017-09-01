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
    public partial class frm_login : Form
    {
        public bool logado = false;
        public frm_login()
        {
            InitializeComponent();
        }

        private void efetuarLogin()
        {
            var user = DataContextFactory.DataContext.Usuarios.Count(
                x => x.usuario == txt_usuario.Text && x.senha == txt_senha.Text);

            if( user > 0)
            {
                this.logado = true;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("usuario ou senha incorretos");
            }
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            efetuarLogin();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
