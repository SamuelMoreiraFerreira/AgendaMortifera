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
            dataGridView1 = new DataGridView();
            btnAdicionarContato = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(366, 352);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdicionarContato
            // 
            btnAdicionarContato.Location = new Point(12, 370);
            btnAdicionarContato.Name = "btnAdicionarContato";
            btnAdicionarContato.Size = new Size(366, 53);
            btnAdicionarContato.TabIndex = 1;
            btnAdicionarContato.Text = "Criar Contato";
            btnAdicionarContato.UseVisualStyleBackColor = true;
            btnAdicionarContato.Click += btnAdicionarContato_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 429);
            button1.Name = "button1";
            button1.Size = new Size(366, 53);
            button1.TabIndex = 5;
            button1.Text = "Apagar Contato";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 488);
            button2.Name = "button2";
            button2.Size = new Size(366, 53);
            button2.TabIndex = 6;
            button2.Text = "Editar Contato";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmContatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(390, 554);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAdicionarContato);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmContatos";
            Text = "frmContatos";
            Load += frmContatos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdicionarContato;
        private Button button1;
        private Button button2;
    }
}