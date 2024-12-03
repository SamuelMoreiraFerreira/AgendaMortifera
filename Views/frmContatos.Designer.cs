namespace AgendaMortifera.Views
{
    partial class frmContatos
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
            btnFechar = new Button();
            btnDeleteContato = new Button();
            btnEditarContato = new Button();
            btnCreateContato = new Button();
            dgvContatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvContatos).BeginInit();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnFechar.Font = new Font("Comic Sans MS", 12F);
            btnFechar.Location = new Point(12, 355);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(316, 59);
            btnFechar.TabIndex = 10;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnDeleteContato
            // 
            btnDeleteContato.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteContato.Font = new Font("Comic Sans MS", 12F);
            btnDeleteContato.Location = new Point(227, 283);
            btnDeleteContato.Name = "btnDeleteContato";
            btnDeleteContato.Size = new Size(101, 66);
            btnDeleteContato.TabIndex = 9;
            btnDeleteContato.Text = "APAGAR";
            btnDeleteContato.UseVisualStyleBackColor = true;
            // 
            // btnEditarContato
            // 
            btnEditarContato.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEditarContato.Font = new Font("Comic Sans MS", 12F);
            btnEditarContato.Location = new Point(120, 283);
            btnEditarContato.Name = "btnEditarContato";
            btnEditarContato.Size = new Size(101, 66);
            btnEditarContato.TabIndex = 8;
            btnEditarContato.Text = "EDITAR";
            btnEditarContato.UseVisualStyleBackColor = true;
            // 
            // btnCreateContato
            // 
            btnCreateContato.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCreateContato.Font = new Font("Comic Sans MS", 12F);
            btnCreateContato.Location = new Point(13, 283);
            btnCreateContato.Name = "btnCreateContato";
            btnCreateContato.Size = new Size(101, 66);
            btnCreateContato.TabIndex = 7;
            btnCreateContato.Text = "CRIAR";
            btnCreateContato.UseVisualStyleBackColor = true;
            // 
            // dgvContatos
            // 
            dgvContatos.AllowUserToAddRows = false;
            dgvContatos.AllowUserToDeleteRows = false;
            dgvContatos.AllowUserToResizeColumns = false;
            dgvContatos.AllowUserToResizeRows = false;
            dgvContatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvContatos.Location = new Point(12, 12);
            dgvContatos.MultiSelect = false;
            dgvContatos.Name = "dgvContatos";
            dgvContatos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContatos.Size = new Size(316, 265);
            dgvContatos.TabIndex = 6;
            // 
            // frmContatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(340, 426);
            Controls.Add(btnFechar);
            Controls.Add(btnDeleteContato);
            Controls.Add(btnEditarContato);
            Controls.Add(btnCreateContato);
            Controls.Add(dgvContatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmContatos";
            Text = "Dashboard - Contatos";
            Load += frmContatos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnFechar;
        private Button btnDeleteContato;
        private Button btnEditarContato;
        private Button btnCreateContato;
        private DataGridView dgvContatos;
    }
}