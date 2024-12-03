namespace AgendaMortifera
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblTitle = new Label();
            lblMortifera = new Label();
            tbxUser = new TextBox();
            tbxPassword = new TextBox();
            btnLogin = new Button();
            pictureBox4 = new PictureBox();
            lblCadastrar = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(135, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Agenda Telefônica";
            // 
            // lblMortifera
            // 
            lblMortifera.AutoSize = true;
            lblMortifera.BackColor = Color.Transparent;
            lblMortifera.Font = new Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMortifera.ForeColor = Color.White;
            lblMortifera.Location = new Point(101, 66);
            lblMortifera.Name = "lblMortifera";
            lblMortifera.Size = new Size(324, 67);
            lblMortifera.TabIndex = 1;
            lblMortifera.Text = "MORTÍFERA";
            // 
            // tbxUser
            // 
            tbxUser.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUser.Location = new Point(101, 195);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(324, 35);
            tbxUser.TabIndex = 5;
            tbxUser.TextChanged += tbx_TextChanged;
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPassword.Location = new Point(101, 271);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.Size = new Size(324, 35);
            tbxPassword.TabIndex = 11;
            tbxPassword.TextChanged += tbx_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Enabled = false;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.IndianRed;
            btnLogin.Location = new Point(156, 336);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(209, 50);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "ENTRAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Bottom;
            pictureBox4.Image = Properties.Resources.fire2;
            pictureBox4.Location = new Point(0, 478);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(538, 119);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // lblCadastrar
            // 
            lblCadastrar.AutoSize = true;
            lblCadastrar.Cursor = Cursors.Hand;
            lblCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCadastrar.ForeColor = Color.FromArgb(224, 224, 224);
            lblCadastrar.Location = new Point(120, 439);
            lblCadastrar.Name = "lblCadastrar";
            lblCadastrar.Size = new Size(275, 21);
            lblCadastrar.TabIndex = 18;
            lblCadastrar.Text = "Ainda está no purgatório? Cadastre-se";
            lblCadastrar.Click += lblCadastrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(101, 171);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 19;
            label3.Text = "Usuário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(101, 247);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 20;
            label4.Text = "Senha";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(538, 597);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblCadastrar);
            Controls.Add(btnLogin);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUser);
            Controls.Add(lblMortifera);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda Telefônica MORTÍFERA";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblMortifera;
        private TextBox tbxUser;
        private TextBox tbxPassword;
        private Button btnLogin;
        private PictureBox pictureBox4;
        private Label lblCadastrar;
        private Label label3;
        private Label label4;
    }
}
