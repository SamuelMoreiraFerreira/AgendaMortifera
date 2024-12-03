namespace AgendaMortifera.Views
{
    partial class frmFormsContato
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
            tbxNome = new TextBox();
            tbxTelefone = new TextBox();
            btnConfirmar = new Button();
            lblNome = new Label();
            lblTelefone = new Label();
            lblCategoria = new Label();
            cbxCategorias = new ComboBox();
            SuspendLayout();
            // 
            // tbxNome
            // 
            tbxNome.Font = new Font("Comic Sans MS", 20.25F);
            tbxNome.Location = new Point(35, 70);
            tbxNome.Name = "tbxNome";
            tbxNome.Size = new Size(269, 45);
            tbxNome.TabIndex = 0;
            tbxNome.TextChanged += tbx_TextChanged;
            // 
            // tbxTelefone
            // 
            tbxTelefone.Font = new Font("Comic Sans MS", 20.25F);
            tbxTelefone.Location = new Point(35, 160);
            tbxTelefone.MaxLength = 15;
            tbxTelefone.Name = "tbxTelefone";
            tbxTelefone.Size = new Size(269, 45);
            tbxTelefone.TabIndex = 1;
            tbxTelefone.TextChanged += tbx_TextChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.IndianRed;
            btnConfirmar.Dock = DockStyle.Bottom;
            btnConfirmar.Enabled = false;
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(0, 347);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(339, 72);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.TextChanged += tbx_TextChanged;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNome.Location = new Point(35, 46);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 21);
            lblNome.TabIndex = 20;
            lblNome.Text = "Nome";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTelefone.Location = new Point(35, 136);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(76, 21);
            lblTelefone.TabIndex = 21;
            lblTelefone.Text = "Telefone";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCategoria.Location = new Point(35, 230);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(84, 21);
            lblCategoria.TabIndex = 22;
            lblCategoria.Text = "Categoria";
            // 
            // cbxCategorias
            // 
            cbxCategorias.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxCategorias.FormattingEnabled = true;
            cbxCategorias.Location = new Point(35, 254);
            cbxCategorias.Name = "cbxCategorias";
            cbxCategorias.Size = new Size(269, 46);
            cbxCategorias.TabIndex = 23;
            // 
            // frmFormsContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(339, 419);
            Controls.Add(cbxCategorias);
            Controls.Add(lblCategoria);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(btnConfirmar);
            Controls.Add(tbxTelefone);
            Controls.Add(tbxNome);
            Name = "frmFormsContato";
            Text = "FormCreateContato";
            Load += FormCreateContato_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNome;
        private TextBox tbxTelefone;
        private Button btnConfirmar;
        private Label lblNome;
        private Label lblTelefone;
        private Label lblCategoria;
        private ComboBox cbxCategorias;
    }
}