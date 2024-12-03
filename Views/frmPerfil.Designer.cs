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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfil));
            tbxAlterarSenha = new TextBox();
            gbxSeguranca = new GroupBox();
            btnConfirmarSenha = new Button();
            label1 = new Label();
            gbxInfo = new GroupBox();
            label3 = new Label();
            lblPecado = new Label();
            label5 = new Label();
            lblUsuario = new Label();
            label = new Label();
            lblTelefone = new Label();
            label2 = new Label();
            lblNome = new Label();
            btnScreenCategorias = new Button();
            btnDesconectar = new Button();
            gbxFuncionalidades = new GroupBox();
            btnScreenContatos = new Button();
            gbxSeguranca.SuspendLayout();
            gbxInfo.SuspendLayout();
            gbxFuncionalidades.SuspendLayout();
            SuspendLayout();
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
            gbxSeguranca.Location = new Point(12, 12);
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
            gbxInfo.Location = new Point(12, 140);
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
            // btnScreenCategorias
            // 
            btnScreenCategorias.BackColor = Color.DarkOrange;
            btnScreenCategorias.FlatStyle = FlatStyle.Popup;
            btnScreenCategorias.Font = new Font("Comic Sans MS", 12F);
            btnScreenCategorias.ForeColor = Color.White;
            btnScreenCategorias.Location = new Point(20, 45);
            btnScreenCategorias.Name = "btnScreenCategorias";
            btnScreenCategorias.Size = new Size(186, 71);
            btnScreenCategorias.TabIndex = 12;
            btnScreenCategorias.Text = "Categorias";
            btnScreenCategorias.UseVisualStyleBackColor = false;
            btnScreenCategorias.Click += btnScreenCategorias_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.BackColor = Color.Brown;
            btnDesconectar.FlatStyle = FlatStyle.Popup;
            btnDesconectar.Font = new Font("Comic Sans MS", 12F);
            btnDesconectar.ForeColor = Color.White;
            btnDesconectar.Location = new Point(12, 264);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(238, 48);
            btnDesconectar.TabIndex = 13;
            btnDesconectar.Text = "DESCONECTAR";
            btnDesconectar.UseVisualStyleBackColor = false;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // gbxFuncionalidades
            // 
            gbxFuncionalidades.Controls.Add(btnScreenContatos);
            gbxFuncionalidades.Controls.Add(btnScreenCategorias);
            gbxFuncionalidades.Location = new Point(309, 12);
            gbxFuncionalidades.Name = "gbxFuncionalidades";
            gbxFuncionalidades.Size = new Size(234, 246);
            gbxFuncionalidades.TabIndex = 14;
            gbxFuncionalidades.TabStop = false;
            gbxFuncionalidades.Text = "Funcionalidades";
            // 
            // btnScreenContatos
            // 
            btnScreenContatos.BackColor = Color.LimeGreen;
            btnScreenContatos.FlatStyle = FlatStyle.Popup;
            btnScreenContatos.Font = new Font("Comic Sans MS", 12F);
            btnScreenContatos.ForeColor = Color.White;
            btnScreenContatos.Location = new Point(20, 140);
            btnScreenContatos.Name = "btnScreenContatos";
            btnScreenContatos.Size = new Size(186, 71);
            btnScreenContatos.TabIndex = 13;
            btnScreenContatos.Text = "Contatos";
            btnScreenContatos.UseVisualStyleBackColor = false;
            btnScreenContatos.Click += btnScreenContatos_Click;
            // 
            // frmPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 324);
            Controls.Add(gbxFuncionalidades);
            Controls.Add(btnDesconectar);
            Controls.Add(gbxInfo);
            Controls.Add(gbxSeguranca);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += frmPerfil_Load;
            gbxSeguranca.ResumeLayout(false);
            gbxSeguranca.PerformLayout();
            gbxInfo.ResumeLayout(false);
            gbxInfo.PerformLayout();
            gbxFuncionalidades.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox tbxAlterarSenha;
        private GroupBox gbxSeguranca;
        private Label label1;
        private Button btnConfirmarSenha;
        private GroupBox gbxInfo;
        private Label label3;
        private Label lblPecado;
        private Label label5;
        private Label lblUsuario;
        private Label label;
        private Label lblTelefone;
        private Label label2;
        private Label lblNome;
        private Button btnScreenCategorias;
        private Button btnDesconectar;
        private GroupBox gbxFuncionalidades;
        private Button btnScreenContatos;
    }
}