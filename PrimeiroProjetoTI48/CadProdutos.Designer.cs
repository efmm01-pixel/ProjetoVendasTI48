namespace PrimeiroProjetoTI48
{
    partial class CadProdutos
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCusto = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.GridProduto = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnMostrarDados = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelID.Location = new System.Drawing.Point(33, 18);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(16, 14);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNome.Location = new System.Drawing.Point(32, 49);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(39, 14);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "NOME:";
            // 
            // labelCusto
            // 
            this.labelCusto.AutoSize = true;
            this.labelCusto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCusto.Location = new System.Drawing.Point(32, 83);
            this.labelCusto.Name = "labelCusto";
            this.labelCusto.Size = new System.Drawing.Size(38, 14);
            this.labelCusto.TabIndex = 2;
            this.labelCusto.Text = "Custo:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(100, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(276, 20);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(276, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(100, 80);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(276, 20);
            this.txtCusto.TabIndex = 5;
            this.txtCusto.TextChanged += new System.EventHandler(this.txtCusto_TextChanged);
            // 
            // GridProduto
            // 
            this.GridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProduto.Location = new System.Drawing.Point(36, 185);
            this.GridProduto.Name = "GridProduto";
            this.GridProduto.Size = new System.Drawing.Size(465, 255);
            this.GridProduto.TabIndex = 6;
            this.GridProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProduto_CellContentClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdicionar.Location = new System.Drawing.Point(414, 13);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(87, 25);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlterar.Location = new System.Drawing.Point(414, 46);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 25);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluir.Location = new System.Drawing.Point(414, 78);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 25);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnMostrarDados
            // 
            this.btnMostrarDados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarDados.Location = new System.Drawing.Point(414, 109);
            this.btnMostrarDados.Name = "btnMostrarDados";
            this.btnMostrarDados.Size = new System.Drawing.Size(87, 25);
            this.btnMostrarDados.TabIndex = 10;
            this.btnMostrarDados.Text = "MostrarDados";
            this.btnMostrarDados.UseVisualStyleBackColor = true;
            this.btnMostrarDados.Click += new System.EventHandler(this.btnMostrarDados_Click_1);
            // 
            // btnConsultar
            // 
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultar.Location = new System.Drawing.Point(414, 140);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(87, 25);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
            // 
            // produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(552, 485);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnMostrarDados);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.GridProduto);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelCusto);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelID);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "produtos";
            this.Text = "produtos";
            ((System.ComponentModel.ISupportInitialize)(this.GridProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCusto;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.DataGridView GridProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnMostrarDados;
        private System.Windows.Forms.Button btnConsultar;
    }
}