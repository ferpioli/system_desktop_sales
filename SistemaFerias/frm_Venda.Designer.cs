namespace SistemaFerias
{
    partial class frm_Venda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoPessoaLabel;
            System.Windows.Forms.Label codigoVendaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label codigoProdutoLabel;
            System.Windows.Forms.Label valorLabel1;
            System.Windows.Forms.Label descontoLabel;
            System.Windows.Forms.Label valorPagoLabel;
            System.Windows.Forms.Label codigo_statusLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label data_vencimentoLabel;
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_Cliente = new System.Windows.Forms.ComboBox();
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_formaPgto = new System.Windows.Forms.ComboBox();
            this.contas_recebersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_FinalizarVenda = new System.Windows.Forms.Button();
            this.btn_FinalizarPedido = new System.Windows.Forms.Button();
            this.txt_desconto = new System.Windows.Forms.MaskedTextBox();
            this.ValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.txt_Valor = new System.Windows.Forms.MaskedTextBox();
            this.btn_NovoItem = new System.Windows.Forms.Button();
            this.cmb_Produtos = new System.Windows.Forms.ComboBox();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dg_Vendas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.txt_CodigoVenda = new System.Windows.Forms.TextBox();
            this.vendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.status_pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contas_receberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_DataVencimento = new System.Windows.Forms.DateTimePicker();
            this.btn_finalizar = new System.Windows.Forms.Button();
            codigoPessoaLabel = new System.Windows.Forms.Label();
            codigoVendaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codigoProdutoLabel = new System.Windows.Forms.Label();
            valorLabel1 = new System.Windows.Forms.Label();
            descontoLabel = new System.Windows.Forms.Label();
            valorPagoLabel = new System.Windows.Forms.Label();
            codigo_statusLabel = new System.Windows.Forms.Label();
            data_vencimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contas_recebersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Vendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_pagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_receberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoPessoaLabel
            // 
            codigoPessoaLabel.AutoSize = true;
            codigoPessoaLabel.Location = new System.Drawing.Point(21, 46);
            codigoPessoaLabel.Name = "codigoPessoaLabel";
            codigoPessoaLabel.Size = new System.Drawing.Size(39, 13);
            codigoPessoaLabel.TabIndex = 1;
            codigoPessoaLabel.Text = "Cliente";
            // 
            // codigoVendaLabel
            // 
            codigoVendaLabel.AutoSize = true;
            codigoVendaLabel.Location = new System.Drawing.Point(9, 27);
            codigoVendaLabel.Name = "codigoVendaLabel";
            codigoVendaLabel.Size = new System.Drawing.Size(77, 13);
            codigoVendaLabel.TabIndex = 0;
            codigoVendaLabel.Text = "Codigo Venda:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(23, 82);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(63, 13);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "quantidade:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(53, 108);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(33, 13);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "valor:";
            // 
            // codigoProdutoLabel
            // 
            codigoProdutoLabel.AutoSize = true;
            codigoProdutoLabel.Location = new System.Drawing.Point(9, 52);
            codigoProdutoLabel.Name = "codigoProdutoLabel";
            codigoProdutoLabel.Size = new System.Drawing.Size(47, 13);
            codigoProdutoLabel.TabIndex = 8;
            codigoProdutoLabel.Text = "Produto:";
            // 
            // valorLabel1
            // 
            valorLabel1.AutoSize = true;
            valorLabel1.Location = new System.Drawing.Point(141, 222);
            valorLabel1.Name = "valorLabel1";
            valorLabel1.Size = new System.Drawing.Size(33, 13);
            valorLabel1.TabIndex = 10;
            valorLabel1.Text = "valor:";
            // 
            // descontoLabel
            // 
            descontoLabel.AutoSize = true;
            descontoLabel.Location = new System.Drawing.Point(141, 245);
            descontoLabel.Name = "descontoLabel";
            descontoLabel.Size = new System.Drawing.Size(54, 13);
            descontoLabel.TabIndex = 12;
            descontoLabel.Text = "desconto:";
            // 
            // valorPagoLabel
            // 
            valorPagoLabel.AutoSize = true;
            valorPagoLabel.Location = new System.Drawing.Point(141, 267);
            valorPagoLabel.Name = "valorPagoLabel";
            valorPagoLabel.Size = new System.Drawing.Size(60, 13);
            valorPagoLabel.TabIndex = 14;
            valorPagoLabel.Text = "valor Total:";
            // 
            // codigo_statusLabel
            // 
            codigo_statusLabel.AutoSize = true;
            codigo_statusLabel.Location = new System.Drawing.Point(421, 213);
            codigo_statusLabel.Name = "codigo_statusLabel";
            codigo_statusLabel.Size = new System.Drawing.Size(108, 13);
            codigo_statusLabel.TabIndex = 21;
            codigo_statusLabel.Text = "Forma de Pagamento";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(Sistemas.DAL.Venda);
            // 
            // cmb_Cliente
            // 
            this.cmb_Cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "CodigoPessoa", true));
            this.cmb_Cliente.DataSource = this.pessoasBindingSource;
            this.cmb_Cliente.DisplayMember = "descricao";
            this.cmb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cliente.FormattingEnabled = true;
            this.cmb_Cliente.Location = new System.Drawing.Point(66, 43);
            this.cmb_Cliente.Name = "cmb_Cliente";
            this.cmb_Cliente.Size = new System.Drawing.Size(121, 21);
            this.cmb_Cliente.TabIndex = 2;
            this.cmb_Cliente.ValueMember = "CodigoPessoa";
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataSource = typeof(Sistemas.DAL.Pessoas);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "NovaVenda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_finalizar);
            this.groupBox1.Controls.Add(data_vencimentoLabel);
            this.groupBox1.Controls.Add(this.txt_DataVencimento);
            this.groupBox1.Controls.Add(codigo_statusLabel);
            this.groupBox1.Controls.Add(this.cmb_formaPgto);
            this.groupBox1.Controls.Add(this.btn_imprimir);
            this.groupBox1.Controls.Add(this.btn_FinalizarVenda);
            this.groupBox1.Controls.Add(this.btn_FinalizarPedido);
            this.groupBox1.Controls.Add(this.txt_desconto);
            this.groupBox1.Controls.Add(this.ValorTotal);
            this.groupBox1.Controls.Add(this.txt_Valor);
            this.groupBox1.Controls.Add(valorPagoLabel);
            this.groupBox1.Controls.Add(descontoLabel);
            this.groupBox1.Controls.Add(valorLabel1);
            this.groupBox1.Controls.Add(this.btn_NovoItem);
            this.groupBox1.Controls.Add(codigoProdutoLabel);
            this.groupBox1.Controls.Add(this.cmb_Produtos);
            this.groupBox1.Controls.Add(this.dg_Vendas);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(this.txt_Quantidade);
            this.groupBox1.Controls.Add(codigoVendaLabel);
            this.groupBox1.Controls.Add(this.txt_CodigoVenda);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 458);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Venda";
            this.groupBox1.Visible = false;
            // 
            // cmb_formaPgto
            // 
            this.cmb_formaPgto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contas_recebersBindingSource, "Codigo_status", true));
            this.cmb_formaPgto.DataSource = this.status_pagamentoBindingSource;
            this.cmb_formaPgto.DisplayMember = "status";
            this.cmb_formaPgto.Enabled = false;
            this.cmb_formaPgto.FormattingEnabled = true;
            this.cmb_formaPgto.Location = new System.Drawing.Point(543, 213);
            this.cmb_formaPgto.Name = "cmb_formaPgto";
            this.cmb_formaPgto.Size = new System.Drawing.Size(121, 21);
            this.cmb_formaPgto.TabIndex = 22;
            this.cmb_formaPgto.ValueMember = "codigo_status";
            this.cmb_formaPgto.SelectedIndexChanged += new System.EventHandler(this.cmb_formaPgto_SelectedIndexChanged);
            // 
            // contas_recebersBindingSource
            // 
            this.contas_recebersBindingSource.DataMember = "Contas_recebers";
            this.contas_recebersBindingSource.DataSource = this.vendaBindingSource;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Enabled = false;
            this.btn_imprimir.Location = new System.Drawing.Point(6, 300);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(100, 23);
            this.btn_imprimir.TabIndex = 21;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_FinalizarVenda
            // 
            this.btn_FinalizarVenda.Enabled = false;
            this.btn_FinalizarVenda.Location = new System.Drawing.Point(6, 257);
            this.btn_FinalizarVenda.Name = "btn_FinalizarVenda";
            this.btn_FinalizarVenda.Size = new System.Drawing.Size(100, 23);
            this.btn_FinalizarVenda.TabIndex = 20;
            this.btn_FinalizarVenda.Text = "Finalizar Venda";
            this.btn_FinalizarVenda.UseVisualStyleBackColor = true;
            this.btn_FinalizarVenda.Click += new System.EventHandler(this.btn_FinalizarVenda_Click);
            // 
            // btn_FinalizarPedido
            // 
            this.btn_FinalizarPedido.Location = new System.Drawing.Point(6, 217);
            this.btn_FinalizarPedido.Name = "btn_FinalizarPedido";
            this.btn_FinalizarPedido.Size = new System.Drawing.Size(100, 23);
            this.btn_FinalizarPedido.TabIndex = 19;
            this.btn_FinalizarPedido.Text = "Finalizar Pedido";
            this.btn_FinalizarPedido.UseVisualStyleBackColor = true;
            this.btn_FinalizarPedido.Click += new System.EventHandler(this.btn_FinalizarPedido_Click);
            // 
            // txt_desconto
            // 
            this.txt_desconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "desconto", true));
            this.txt_desconto.Location = new System.Drawing.Point(208, 238);
            this.txt_desconto.Name = "txt_desconto";
            this.txt_desconto.ReadOnly = true;
            this.txt_desconto.Size = new System.Drawing.Size(100, 20);
            this.txt_desconto.TabIndex = 17;
            // 
            // ValorTotal
            // 
            this.ValorTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "valorPago", true));
            this.ValorTotal.Location = new System.Drawing.Point(208, 264);
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.ReadOnly = true;
            this.ValorTotal.Size = new System.Drawing.Size(100, 20);
            this.ValorTotal.TabIndex = 16;
            // 
            // txt_Valor
            // 
            this.txt_Valor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "valor", true));
            this.txt_Valor.Location = new System.Drawing.Point(208, 215);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.ReadOnly = true;
            this.txt_Valor.Size = new System.Drawing.Size(100, 20);
            this.txt_Valor.TabIndex = 15;
            // 
            // btn_NovoItem
            // 
            this.btn_NovoItem.Location = new System.Drawing.Point(117, 146);
            this.btn_NovoItem.Name = "btn_NovoItem";
            this.btn_NovoItem.Size = new System.Drawing.Size(75, 23);
            this.btn_NovoItem.TabIndex = 5;
            this.btn_NovoItem.Text = "Novo Item";
            this.btn_NovoItem.UseVisualStyleBackColor = true;
            this.btn_NovoItem.Click += new System.EventHandler(this.btn_NovoItem_Click);
            // 
            // cmb_Produtos
            // 
            this.cmb_Produtos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensVendaBindingSource, "CodigoProduto", true));
            this.cmb_Produtos.DataSource = this.produtoBindingSource;
            this.cmb_Produtos.DisplayMember = "Descricao";
            this.cmb_Produtos.FormattingEnabled = true;
            this.cmb_Produtos.Location = new System.Drawing.Point(62, 49);
            this.cmb_Produtos.Name = "cmb_Produtos";
            this.cmb_Produtos.Size = new System.Drawing.Size(130, 21);
            this.cmb_Produtos.TabIndex = 9;
            this.cmb_Produtos.ValueMember = "Codigo";
            this.cmb_Produtos.SelectedIndexChanged += new System.EventHandler(this.cmb_Produtos_SelectedIndexChanged);
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataSource = typeof(Sistemas.DAL.ItensVenda);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Sistemas.DAL.Produto);
            // 
            // dg_Vendas
            // 
            this.dg_Vendas.AllowUserToAddRows = false;
            this.dg_Vendas.AllowUserToDeleteRows = false;
            this.dg_Vendas.AutoGenerateColumns = false;
            this.dg_Vendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_Vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.dg_Vendas.DataSource = this.itensVendaBindingSource;
            this.dg_Vendas.Location = new System.Drawing.Point(220, 19);
            this.dg_Vendas.Name = "dg_Vendas";
            this.dg_Vendas.ReadOnly = true;
            this.dg_Vendas.Size = new System.Drawing.Size(548, 159);
            this.dg_Vendas.TabIndex = 8;
            this.dg_Vendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itensVendaDataGridView_CellContentClick);
            this.dg_Vendas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dg_Vendas_CellFormatting);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigoProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodigoProduto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn4.HeaderText = "valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "quantidade";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(92, 105);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.ReadOnly = true;
            this.valorTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorTextBox.TabIndex = 7;
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "quantidade", true));
            this.txt_Quantidade.Location = new System.Drawing.Point(92, 79);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(100, 20);
            this.txt_Quantidade.TabIndex = 5;
            // 
            // txt_CodigoVenda
            // 
            this.txt_CodigoVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "CodigoVenda", true));
            this.txt_CodigoVenda.Location = new System.Drawing.Point(92, 24);
            this.txt_CodigoVenda.Name = "txt_CodigoVenda";
            this.txt_CodigoVenda.ReadOnly = true;
            this.txt_CodigoVenda.Size = new System.Drawing.Size(100, 20);
            this.txt_CodigoVenda.TabIndex = 1;
            // 
            // vendaBindingSource1
            // 
            this.vendaBindingSource1.DataSource = typeof(Sistemas.DAL.Venda);
            // 
            // status_pagamentoBindingSource
            // 
            this.status_pagamentoBindingSource.DataSource = typeof(Sistemas.DAL.status_pagamento);
            // 
            // contas_receberBindingSource
            // 
            this.contas_receberBindingSource.DataSource = typeof(Sistemas.DAL.Contas_receber);
            // 
            // data_vencimentoLabel
            // 
            data_vencimentoLabel.AutoSize = true;
            data_vencimentoLabel.Location = new System.Drawing.Point(421, 247);
            data_vencimentoLabel.Name = "data_vencimentoLabel";
            data_vencimentoLabel.Size = new System.Drawing.Size(89, 13);
            data_vencimentoLabel.TabIndex = 22;
            data_vencimentoLabel.Text = "data vencimento:";
            // 
            // txt_DataVencimento
            // 
            this.txt_DataVencimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contas_receberBindingSource, "data_vencimento", true));
            this.txt_DataVencimento.Enabled = false;
            this.txt_DataVencimento.Location = new System.Drawing.Point(516, 246);
            this.txt_DataVencimento.Name = "txt_DataVencimento";
            this.txt_DataVencimento.Size = new System.Drawing.Size(148, 20);
            this.txt_DataVencimento.TabIndex = 23;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Enabled = false;
            this.btn_finalizar.Location = new System.Drawing.Point(564, 300);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(100, 23);
            this.btn_finalizar.TabIndex = 24;
            this.btn_finalizar.Text = "FINALIZAR";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // frm_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(codigoPessoaLabel);
            this.Controls.Add(this.cmb_Cliente);
            this.Name = "frm_Venda";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frm_Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contas_recebersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Vendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_pagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contas_receberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox cmb_Cliente;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_Vendas;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.TextBox txt_CodigoVenda;
        private System.Windows.Forms.BindingSource vendaBindingSource1;
        private System.Windows.Forms.ComboBox cmb_Produtos;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button btn_NovoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.MaskedTextBox txt_desconto;
        private System.Windows.Forms.MaskedTextBox ValorTotal;
        private System.Windows.Forms.MaskedTextBox txt_Valor;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_FinalizarVenda;
        private System.Windows.Forms.Button btn_FinalizarPedido;
        private System.Windows.Forms.ComboBox cmb_formaPgto;
        private System.Windows.Forms.BindingSource contas_recebersBindingSource;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.DateTimePicker txt_DataVencimento;
        private System.Windows.Forms.BindingSource contas_receberBindingSource;
        private System.Windows.Forms.BindingSource status_pagamentoBindingSource;
    }
}