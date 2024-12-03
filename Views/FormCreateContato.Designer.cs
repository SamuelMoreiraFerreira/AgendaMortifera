namespace AgendaMortifera.Views
{
    partial class FormCreateContato
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            clbCategorias = new CheckedListBox();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(92, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(92, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // clbCategorias
            // 
            clbCategorias.FormattingEnabled = true;
            clbCategorias.Location = new Point(145, 244);
            clbCategorias.Name = "clbCategorias";
            clbCategorias.Size = new Size(120, 94);
            clbCategorias.TabIndex = 4;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Dock = DockStyle.Bottom;
            btnConfirmar.Location = new Point(0, 378);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(339, 72);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // FormCreateContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 450);
            Controls.Add(btnConfirmar);
            Controls.Add(clbCategorias);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormCreateContato";
            Text = "FormCreateContato";
            Load += FormCreateContato_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private CheckedListBox clbCategorias;
        private Button btnConfirmar;
    }
}