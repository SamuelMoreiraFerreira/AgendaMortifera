namespace AgendaMortifera.Views
{
    partial class frmCategorias
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
            btnCreateCategoria = new Button();
            btnEditarCategoria = new Button();
            btnDeleteCategoria = new Button();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AllowUserToResizeColumns = false;
            dgvCategorias.AllowUserToResizeRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategorias.Location = new Point(12, 12);
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(316, 265);
            dgvCategorias.TabIndex = 0;
            // 
            // btnCreateCategoria
            // 
            btnCreateCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCreateCategoria.Font = new Font("Comic Sans MS", 12F);
            btnCreateCategoria.Location = new Point(13, 283);
            btnCreateCategoria.Name = "btnCreateCategoria";
            btnCreateCategoria.Size = new Size(101, 66);
            btnCreateCategoria.TabIndex = 2;
            btnCreateCategoria.Text = "CRIAR";
            btnCreateCategoria.UseVisualStyleBackColor = true;
            btnCreateCategoria.Click += btnCreateCategoria_Click;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEditarCategoria.Font = new Font("Comic Sans MS", 12F);
            btnEditarCategoria.Location = new Point(120, 283);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(101, 66);
            btnEditarCategoria.TabIndex = 3;
            btnEditarCategoria.Text = "EDITAR";
            btnEditarCategoria.UseVisualStyleBackColor = true;
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // btnDeleteCategoria
            // 
            btnDeleteCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDeleteCategoria.Font = new Font("Comic Sans MS", 12F);
            btnDeleteCategoria.Location = new Point(227, 283);
            btnDeleteCategoria.Name = "btnDeleteCategoria";
            btnDeleteCategoria.Size = new Size(101, 66);
            btnDeleteCategoria.TabIndex = 4;
            btnDeleteCategoria.Text = "APAGAR";
            btnDeleteCategoria.UseVisualStyleBackColor = true;
            btnDeleteCategoria.Click += btnDeleteCategoria_Click;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnFechar.Font = new Font("Comic Sans MS", 12F);
            btnFechar.Location = new Point(12, 355);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(316, 59);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 426);
            Controls.Add(btnFechar);
            Controls.Add(btnDeleteCategoria);
            Controls.Add(btnEditarCategoria);
            Controls.Add(btnCreateCategoria);
            Controls.Add(dgvCategorias);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategorias";
            Load += frmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategorias;
        private Button btnCreateCategoria;
        private Button btnEditarCategoria;
        private Button btnDeleteCategoria;
        private Button btnFechar;
    }
}