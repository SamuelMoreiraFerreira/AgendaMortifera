namespace AgendaMortifera.Controllers
{
    partial class frmPerfil
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
            dgvCategorias = new DataGridView();
            btnRefreshCategorias = new Button();
            tbxAlterarSenha = new TextBox();
            gbxSeguranca = new GroupBox();
            btnConfirmarSenha = new Button();
            label1 = new Label();
            btnAdicionarCategoria = new Button();
            btnEditarCategoria = new Button();
            btnExcluirCategoria = new Button();
            gbxInfo = new GroupBox();
            label3 = new Label();
            lblPecado = new Label();
            label5 = new Label();
            lblUsuario = new Label();
            label = new Label();
            lblTelefone = new Label();
            label2 = new Label();
            lblNome = new Label();
            btnContatos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            gbxSeguranca.SuspendLayout();
            gbxInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategorias
            // 
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.ColumnHeadersHeight = 25;
            dgvCategorias.Location = new Point(12, 57);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(281, 183);
            dgvCategorias.TabIndex = 2;
            // 
            // btnRefreshCategorias
            // 
            btnRefreshCategorias.Location = new Point(12, 12);
            btnRefreshCategorias.Name = "btnRefreshCategorias";
            btnRefreshCategorias.Size = new Size(281, 39);
            btnRefreshCategorias.TabIndex = 3;
            btnRefreshCategorias.Text = "Atualizar";
            btnRefreshCategorias.UseVisualStyleBackColor = true;
            btnRefreshCategorias.Click += ButtonRefresh_Click;
            // 
            // tbxAlterarSenha
            // 
            tbxAlterarSenha.Location = new Point(17, 48);
            tbxAlterarSenha.Name = "tbxAlterarSenha";
            tbxAlterarSenha.Size = new Size(205, 23);
            tbxAlterarSenha.TabIndex = 6;
            tbxAlterarSenha.TextChanged += tbxAlterarSenha_TextChanged;
            // 
            // gbxSeguranca
            // 
            gbxSeguranca.Controls.Add(btnConfirmarSenha);
            gbxSeguranca.Controls.Add(label1);
            gbxSeguranca.Controls.Add(tbxAlterarSenha);
            gbxSeguranca.Location = new Point(550, 12);
            gbxSeguranca.Name = "gbxSeguranca";
            gbxSeguranca.Size = new Size(238, 116);
            gbxSeguranca.TabIndex = 7;
            gbxSeguranca.TabStop = false;
            gbxSeguranca.Text = "Privacidade e Segurança";
            // 
            // btnConfirmarSenha
            // 
            btnConfirmarSenha.Enabled = false;
            btnConfirmarSenha.Location = new Point(17, 78);
            btnConfirmarSenha.Name = "btnConfirmarSenha";
            btnConfirmarSenha.Size = new Size(205, 23);
            btnConfirmarSenha.TabIndex = 8;
            btnConfirmarSenha.Text = "Confirmar";
            btnConfirmarSenha.UseVisualStyleBackColor = true;
            btnConfirmarSenha.Click += btnConfirmarSenha_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 7;
            label1.Text = "Alterar Senha";
            // 
            // btnAdicionarCategoria
            // 
            btnAdicionarCategoria.Location = new Point(12, 246);
            btnAdicionarCategoria.Name = "btnAdicionarCategoria";
            btnAdicionarCategoria.Size = new Size(89, 89);
            btnAdicionarCategoria.TabIndex = 8;
            btnAdicionarCategoria.Text = "ADD";
            btnAdicionarCategoria.UseVisualStyleBackColor = true;
            btnAdicionarCategoria.Click += btnAdicionarCategoria_Click;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.Location = new Point(108, 246);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(89, 89);
            btnEditarCategoria.TabIndex = 9;
            btnEditarCategoria.Text = "EDIT";
            btnEditarCategoria.UseVisualStyleBackColor = true;
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // btnExcluirCategoria
            // 
            btnExcluirCategoria.Location = new Point(204, 246);
            btnExcluirCategoria.Name = "btnExcluirCategoria";
            btnExcluirCategoria.Size = new Size(89, 89);
            btnExcluirCategoria.TabIndex = 10;
            btnExcluirCategoria.Text = "DELETE";
            btnExcluirCategoria.UseVisualStyleBackColor = true;
            btnExcluirCategoria.Click += btnExcluirCategoria_Click;
            // 
            // gbxInfo
            // 
            gbxInfo.Controls.Add(label3);
            gbxInfo.Controls.Add(lblPecado);
            gbxInfo.Controls.Add(label5);
            gbxInfo.Controls.Add(lblUsuario);
            gbxInfo.Controls.Add(label);
            gbxInfo.Controls.Add(lblTelefone);
            gbxInfo.Controls.Add(label2);
            gbxInfo.Controls.Add(lblNome);
            gbxInfo.Location = new Point(550, 140);
            gbxInfo.Name = "gbxInfo";
            gbxInfo.Size = new Size(238, 118);
            gbxInfo.TabIndex = 11;
            gbxInfo.TabStop = false;
            gbxInfo.Text = "Informações Pessoais";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(130, 68);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 15;
            label3.Text = "Pecado";
            // 
            // lblPecado
            // 
            lblPecado.AutoSize = true;
            lblPecado.Location = new Point(130, 85);
            lblPecado.Name = "lblPecado";
            lblPecado.Size = new Size(27, 15);
            lblPecado.TabIndex = 14;
            lblPecado.Text = "null";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(130, 25);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 13;
            label5.Text = "Usuário";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(130, 42);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(27, 15);
            lblUsuario.TabIndex = 12;
            lblUsuario.Text = "null";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(17, 68);
            label.Name = "label";
            label.Size = new Size(56, 15);
            label.TabIndex = 11;
            label.Text = "Telefone";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(17, 85);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(27, 15);
            lblTelefone.TabIndex = 10;
            lblTelefone.Text = "null";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 25);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 9;
            label2.Text = "Nome";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(17, 42);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(27, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "null";
            // 
            // btnContatos
            // 
            btnContatos.Location = new Point(356, 57);
            btnContatos.Name = "btnContatos";
            btnContatos.Size = new Size(80, 142);
            btnContatos.TabIndex = 12;
            btnContatos.Text = "button1";
            btnContatos.UseVisualStyleBackColor = true;
            btnContatos.Click += btnContatos_Click;
            // 
            // frmPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 353);
            Controls.Add(btnContatos);
            Controls.Add(gbxInfo);
            Controls.Add(btnExcluirCategoria);
            Controls.Add(btnEditarCategoria);
            Controls.Add(btnAdicionarCategoria);
            Controls.Add(gbxSeguranca);
            Controls.Add(btnRefreshCategorias);
            Controls.Add(dgvCategorias);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += frmPerfil_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            gbxSeguranca.ResumeLayout(false);
            gbxSeguranca.PerformLayout();
            gbxInfo.ResumeLayout(false);
            gbxInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvCategorias;
        private Button btnRefreshCategorias;
        private TextBox tbxAlterarSenha;
        private GroupBox gbxSeguranca;
        private Label label1;
        private Button btnConfirmarSenha;
        private Button btnAdicionarCategoria;
        private Button btnEditarCategoria;
        private Button btnExcluirCategoria;
        private GroupBox gbxInfo;
        private Label label3;
        private Label lblPecado;
        private Label label5;
        private Label lblUsuario;
        private Label label;
        private Label lblTelefone;
        private Label label2;
        private Label lblNome;
        private Button btnContatos;
    }
}