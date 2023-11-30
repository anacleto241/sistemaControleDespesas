namespace SistemaCadastro
{
    partial class FrmAddCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCategoria));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.marcador = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricaoCategoria = new System.Windows.Forms.TextBox();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.tabExibir = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgCategorias = new System.Windows.Forms.DataGridView();
            this.tabAlterar = new System.Windows.Forms.TabPage();
            this.txtAlteraDescricao = new System.Windows.Forms.TextBox();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnConfirmaCadastro = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemoveCategoria = new System.Windows.Forms.Button();
            this.btnConfirmaAlteracao = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.tabExibir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).BeginInit();
            this.tabAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(77, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 28);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.marcador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(77, 565);
            this.panel1.TabIndex = 3;
            // 
            // marcador
            // 
            this.marcador.BackColor = System.Drawing.Color.Firebrick;
            this.marcador.Location = new System.Drawing.Point(-72, 171);
            this.marcador.Margin = new System.Windows.Forms.Padding(4);
            this.marcador.Name = "marcador";
            this.marcador.Size = new System.Drawing.Size(13, 44);
            this.marcador.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "CATEGORIA";
            // 
            // txtDescricaoCategoria
            // 
            this.txtDescricaoCategoria.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtDescricaoCategoria.Location = new System.Drawing.Point(312, 203);
            this.txtDescricaoCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricaoCategoria.Name = "txtDescricaoCategoria";
            this.txtDescricaoCategoria.Size = new System.Drawing.Size(391, 32);
            this.txtDescricaoCategoria.TabIndex = 17;
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNomeCategoria.Location = new System.Drawing.Point(312, 99);
            this.txtNomeCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(391, 34);
            this.txtNomeCategoria.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(63, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(63, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nome:";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(879, 46);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(46, 35);
            this.btnFechar.TabIndex = 20;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastrar);
            this.tabControl1.Controls.Add(this.tabExibir);
            this.tabControl1.Controls.Add(this.tabAlterar);
            this.tabControl1.Location = new System.Drawing.Point(96, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 432);
            this.tabControl1.TabIndex = 21;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.Controls.Add(this.label4);
            this.tabCadastrar.Controls.Add(this.txtNomeCategoria);
            this.tabCadastrar.Controls.Add(this.BtnConfirmaCadastro);
            this.tabCadastrar.Controls.Add(this.label3);
            this.tabCadastrar.Controls.Add(this.txtDescricaoCategoria);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 25);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastrar.Size = new System.Drawing.Size(825, 403);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Adicionar";
            this.tabCadastrar.UseVisualStyleBackColor = true;
            // 
            // tabExibir
            // 
            this.tabExibir.Controls.Add(this.label1);
            this.tabExibir.Controls.Add(this.label5);
            this.tabExibir.Controls.Add(this.txtBusca);
            this.tabExibir.Controls.Add(this.dgCategorias);
            this.tabExibir.Controls.Add(this.btnAlterar);
            this.tabExibir.Controls.Add(this.btnRemoveCategoria);
            this.tabExibir.Location = new System.Drawing.Point(4, 25);
            this.tabExibir.Name = "tabExibir";
            this.tabExibir.Padding = new System.Windows.Forms.Padding(3);
            this.tabExibir.Size = new System.Drawing.Size(825, 400);
            this.tabExibir.TabIndex = 1;
            this.tabExibir.Text = "Exibir";
            this.tabExibir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-67, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Banda:";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBusca.Location = new System.Drawing.Point(127, 36);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(248, 32);
            this.txtBusca.TabIndex = 17;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // dgCategorias
            // 
            this.dgCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCategorias.BackgroundColor = System.Drawing.Color.White;
            this.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorias.Location = new System.Drawing.Point(40, 114);
            this.dgCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgCategorias.Name = "dgCategorias";
            this.dgCategorias.ReadOnly = true;
            this.dgCategorias.RowHeadersWidth = 51;
            this.dgCategorias.RowTemplate.Height = 29;
            this.dgCategorias.Size = new System.Drawing.Size(752, 245);
            this.dgCategorias.TabIndex = 16;
            // 
            // tabAlterar
            // 
            this.tabAlterar.Controls.Add(this.txtAlteraDescricao);
            this.tabAlterar.Controls.Add(this.txtAlteraNome);
            this.tabAlterar.Controls.Add(this.label8);
            this.tabAlterar.Controls.Add(this.label10);
            this.tabAlterar.Controls.Add(this.btnConfirmaAlteracao);
            this.tabAlterar.Location = new System.Drawing.Point(4, 25);
            this.tabAlterar.Name = "tabAlterar";
            this.tabAlterar.Size = new System.Drawing.Size(825, 400);
            this.tabAlterar.TabIndex = 2;
            this.tabAlterar.Text = "Alterar";
            this.tabAlterar.UseVisualStyleBackColor = true;
            // 
            // txtAlteraDescricao
            // 
            this.txtAlteraDescricao.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAlteraDescricao.Location = new System.Drawing.Point(276, 202);
            this.txtAlteraDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlteraDescricao.Name = "txtAlteraDescricao";
            this.txtAlteraDescricao.Size = new System.Drawing.Size(443, 32);
            this.txtAlteraDescricao.TabIndex = 26;
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAlteraNome.Location = new System.Drawing.Point(276, 98);
            this.txtAlteraNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(443, 34);
            this.txtAlteraNome.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(87, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Descrição:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(87, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Nome:";
            // 
            // BtnConfirmaCadastro
            // 
            this.BtnConfirmaCadastro.FlatAppearance.BorderSize = 0;
            this.BtnConfirmaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmaCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnConfirmaCadastro.ForeColor = System.Drawing.Color.DimGray;
            this.BtnConfirmaCadastro.Image = global::SistemaCadastro.Properties.Resources.adicionar;
            this.BtnConfirmaCadastro.Location = new System.Drawing.Point(312, 305);
            this.BtnConfirmaCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirmaCadastro.Name = "BtnConfirmaCadastro";
            this.BtnConfirmaCadastro.Size = new System.Drawing.Size(175, 60);
            this.BtnConfirmaCadastro.TabIndex = 18;
            this.BtnConfirmaCadastro.Text = "&Cadastrar";
            this.BtnConfirmaCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmaCadastro.UseVisualStyleBackColor = true;
            this.BtnConfirmaCadastro.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click_1);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.Color.DimGray;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(636, 29);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(156, 58);
            this.btnAlterar.TabIndex = 20;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // btnRemoveCategoria
            // 
            this.btnRemoveCategoria.FlatAppearance.BorderSize = 0;
            this.btnRemoveCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemoveCategoria.ForeColor = System.Drawing.Color.DimGray;
            this.btnRemoveCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveCategoria.Image")));
            this.btnRemoveCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveCategoria.Location = new System.Drawing.Point(438, 26);
            this.btnRemoveCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveCategoria.Name = "btnRemoveCategoria";
            this.btnRemoveCategoria.Size = new System.Drawing.Size(171, 61);
            this.btnRemoveCategoria.TabIndex = 19;
            this.btnRemoveCategoria.Text = "Remover";
            this.btnRemoveCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveCategoria.UseVisualStyleBackColor = true;
            this.btnRemoveCategoria.Click += new System.EventHandler(this.btnRemoveCategoria_Click);
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.FlatAppearance.BorderSize = 0;
            this.btnConfirmaAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaAlteracao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmaAlteracao.ForeColor = System.Drawing.Color.DimGray;
            this.btnConfirmaAlteracao.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmaAlteracao.Image")));
            this.btnConfirmaAlteracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.Location = new System.Drawing.Point(312, 291);
            this.btnConfirmaAlteracao.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmaAlteracao.Name = "btnConfirmaAlteracao";
            this.btnConfirmaAlteracao.Size = new System.Drawing.Size(175, 60);
            this.btnConfirmaAlteracao.TabIndex = 27;
            this.btnConfirmaAlteracao.Text = "Confirmar Alteração";
            this.btnConfirmaAlteracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmaAlteracao.UseVisualStyleBackColor = true;
            this.btnConfirmaAlteracao.Click += new System.EventHandler(this.btnConfirmaAlteracao_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(60, 46);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 161);
            this.panel3.TabIndex = 2;
            // 
            // FrmAddCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 565);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddCategoria";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.tabExibir.ResumeLayout(false);
            this.tabExibir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).EndInit();
            this.tabAlterar.ResumeLayout(false);
            this.tabAlterar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnConfirmaCadastro;
        private System.Windows.Forms.TextBox txtDescricaoCategoria;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel marcador;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastrar;
        private System.Windows.Forms.TabPage tabExibir;
        private System.Windows.Forms.TabPage tabAlterar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemoveCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlteraDescricao;
        private System.Windows.Forms.TextBox txtAlteraNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConfirmaAlteracao;
        private System.Windows.Forms.Panel panel3;
    }
}