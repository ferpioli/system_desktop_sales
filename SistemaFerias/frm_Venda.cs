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
    public partial class frm_Venda : Form
    {
        public frm_Venda()
        {
            InitializeComponent();
        }

        private void frm_Venda_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 120);
            this.pessoasBindingSource.DataSource = DataContextFactory.DataContext.Pessoas;
            this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Vendas;
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos;
            this.contas_receberBindingSource.DataSource = DataContextFactory.DataContext.Contas_recebers;
            this.status_pagamentoBindingSource.DataSource = DataContextFactory.DataContext.status_pagamentos;
            this.vendaBindingSource.AddNew();

        }

        public Venda  VendaCorrente
        {
            get
            {
                return (Venda)this.vendaBindingSource.Current;
            }
        }

        public ItensVenda ItemCorrente
        {
            get
            {
                return (ItensVenda)this.itensVendaBindingSource.Current;
            }
        }

        public Contas_receber ContaCorrente
        {
            get
            {
                return (Contas_receber)this.contas_receberBindingSource.Current;
            }

        }


        private void itensVendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(800, 600);
            cmb_Cliente.Enabled = false;
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            groupBox1.Visible = true;
            button1.Enabled = false;

            this.itensVendaBindingSource.DataSource = DataContextFactory.DataContext.ItensVendas.Where( x => x.CodigoProduto == this.VendaCorrente.CodigoVenda) ;
            NovoItem();
        }

        private void NovoItem()
        {
            this.itensVendaBindingSource.AddNew();
            this.ItemCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ItemCorrente.quantidade = 1;
       
           
        }

        private void btn_NovoItem_Click(object sender, EventArgs e)
        {
            this.itensVendaBindingSource.EndEdit();
            dg_Vendas.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            MostrarSomadeValores();
            NovoItem();
         


        }

        private void dg_Vendas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((Produto)e.Value).Descricao;
        }

        private void cmb_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Produtos.SelectedItem != null)
            {
                var pro = (Produto)cmb_Produtos.SelectedItem;
                this.ItemCorrente.CodigoProduto = (int)pro.Codigo;
                this.ItemCorrente.valor = (decimal)pro.valor;
            }

        }
            private void MostrarSomadeValores()
        {
            decimal Total = 0;
            foreach(DataGridViewRow dg in dg_Vendas.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);
                decimal subtotal = v1 * v2;
                dg.Cells[4].Value = subtotal;
                Total = Total + subtotal;
            }
            this.VendaCorrente.valor = Total;

        }

        private void btn_FinalizarPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar o pedido?", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.itensVendaBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.VendaCorrente.desconto = 0;
                btn_NovoItem.Enabled = false;
                cmb_Produtos.Enabled = false;
                txt_Quantidade.Enabled = false;
                txt_desconto.ReadOnly = false;
                txt_desconto.FindForm();
                btn_FinalizarPedido.Enabled = false;
                btn_FinalizarVenda.Enabled = true;
                txt_CodigoVenda.Enabled = false;
                

            }
        }

        private void btn_FinalizarVenda_Click(object sender, EventArgs e)
        {
            this.VendaCorrente.desconto = Convert.ToDecimal(txt_desconto.Text);
            this.VendaCorrente.valorPago = (decimal)(this.VendaCorrente.valor - this.VendaCorrente.desconto);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            txt_desconto.Enabled = false;
            btn_FinalizarVenda.Enabled = false;
            // btn_imprimir.Enabled = true;
            cmb_formaPgto.Enabled = true;
            this.contas_receberBindingSource.AddNew();
            this.ContaCorrente.Codigo_venda = this.VendaCorrente.CodigoVenda;
            this.ContaCorrente.data_compra = DateTime.Now;
            this.ContaCorrente.data_vencimento = DateTime.Now;
        }

        private void cmb_formaPgto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_formaPgto.SelectedItem != null)
            {

                var status = (status_pagamento)cmb_formaPgto.SelectedItem;
                if(status.codigo_status == 1)
                {
                    this.ContaCorrente.Codigo_status = (int)status.codigo_status;
                    this.ContaCorrente.data_pagamento = DateTime.Now;
                    btn_finalizar.Enabled = true;
                    txt_DataVencimento.Enabled = false;
                    
                }
                else if (status.codigo_status ==2)
                {
                    this.ContaCorrente.Codigo_status = (int)status.codigo_status;
                    this.ContaCorrente.data_vencimento = DateTime.Now;
                    this.ContaCorrente.data_pagamento = null;
                    txt_DataVencimento.Enabled = true;
                    btn_finalizar.Enabled = true;
                }

            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            this.contas_receberBindingSource.EndEdit();
            txt_DataVencimento.Enabled = false;
            btn_finalizar.Enabled = false;
            cmb_formaPgto.Enabled = false;
            btn_imprimir.Enabled = true;
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("venda Finalizada com sucesso!");


        }
    }
    }
