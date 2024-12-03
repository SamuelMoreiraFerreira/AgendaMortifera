using AgendaMortifera.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMortifera.Views
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void AtualizarDgvCategorias()
        {
            dgvCategorias.DataSource = new CategoriaController().GetCategorias();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            this.AtualizarDgvCategorias();
        }

        // Criar Categoria
        private void btnCreateCategoria_Click(object sender, EventArgs e)
        {
            frmFormsCategoria screenCreateCategoria = new frmFormsCategoria();

            screenCreateCategoria.ShowDialog();
            this.AtualizarDgvCategorias();
        }

        // Editar Categoria
        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                frmFormsCategoria screenCreateCategoria = new frmFormsCategoria
                {
                    editCategoriaID = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["ID"].Value),
                    presetName = dgvCategorias.SelectedRows[0].Cells["Categoria"].Value.ToString()!
                };

                screenCreateCategoria.ShowDialog();
                this.AtualizarDgvCategorias();
            }

            else
            {
                MessageBox.Show("Selecione na tabela a categoria à ser editada.", "Aviso!");
            }
        }

        // Deletar Categoria
        private void btnDeleteCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {
                new CategoriaController().DeleteCategoria(Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["ID"].Value));
                this.AtualizarDgvCategorias();
            }

            else
            {
                MessageBox.Show("Selecione na tabela a categoria à ser apagada.", "Aviso!");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
