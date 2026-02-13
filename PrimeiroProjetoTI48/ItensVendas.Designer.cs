namespace PrimeiroProjetoTI48
{
    partial class ItensVendas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblVendaId = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalVenda = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.dgItensVenda = new System.Windows.Forms.DataGridView();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.txtVendaId = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgItensVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVendaId
            // 
            this.lblVendaId.AutoSize = true;
            this.lblVendaId.Location = new System.Drawing.Point(32, 47);
            this.lblVendaId.Name = "lblVendaId";
            this.lblVendaId.Size = new System.Drawing.Size(66, 13);
            this.lblVendaId.Text = "ID da venda";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(32, 74);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.Text = "Cliente";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(32, 99);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.Text = "Produto";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(32, 124);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(32, 153);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.AutoSize = true;
            this.lblTotalVenda.Location = new System.Drawing.Point(32, 178);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(68, 13);
            this.lblTotalVenda.Text = "Total Venda:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(35, 243);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(219, 243);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 21);
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Location = new System.Drawing.Point(535, 12);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(253, 20);
            // 
            // dgItensVenda
            // 
            this.dgItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItensVenda.Location = new System.Drawing.Point(23, 288);
            this.dgItensVenda.Name = "dgItensVenda";
            this.dgItensVenda.Size = new System.Drawing.Size(240, 150);
            this.dgItensVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItensVenda_CellContentClick);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(299, 288);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(121, 23);
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(299, 351);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(121, 23);
            this.btnAdicionarItem.Text = "Adicionar Item";
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Location = new System.Drawing.Point(426, 351);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(121, 23);
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(426, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 23);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Location = new System.Drawing.Point(361, 399);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(121, 23);
            this.btnRemoverItem.Text = "Remover item";
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // txtVendaId
            // 
            this.txtVendaId.Location = new System.Drawing.Point(131, 44);
            this.txtVendaId.Name = "txtVendaId";
            this.txtVendaId.Size = new System.Drawing.Size(164, 20);
            this.txtVendaId.TextChanged += new System.EventHandler(this.txtVendaId_TextChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(131, 117);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(164, 20);
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(112, 150);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(164, 20);
            // 
            // ItensVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtVendaId);
            this.Controls.Add(this.btnRemoverItem);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.btnAdicionarItem);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.dgItensVenda);
            this.Controls.Add(this.dtpDataVenda);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblTotalVenda);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblVendaId);
            this.Name = "ItensVendas";
            this.Text = "ItensVendas";
            this.Load += new System.EventHandler(this.ItensVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgItensVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblVendaId;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalVenda;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.DataGridView dgItensVenda;
        private System.Windows.Forms.Button btnNovaVenda;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.TextBox txtVendaId;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtTotal;
    }
}