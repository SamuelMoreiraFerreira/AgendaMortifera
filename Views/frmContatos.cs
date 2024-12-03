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
    public partial class frmContatos : Form
    {
        public frmContatos()
        {
            InitializeComponent();
        }

        private void AtualizarDgvContatos()
        {
            dgvContatos.DataSource = new ContatoController().GetContatos();
        }

        private void frmContatos_Load(object sender, EventArgs e)
        {
            this.AtualizarDgvContatos();
        }

        // Adicionar Contato
        private void btnAdicionarContato_Click(object sender, EventArgs e)
        {
            frmFormsContato screenFormsContato = new frmFormsContato();

            screenFormsContato.ShowDialog();
            this.AtualizarDgvContatos();
        }

        // Remover Contato
        private void btnEditarContato_Click(object sender, EventArgs e)
        {
            frmFormsContato screenFormsContato = new frmFormsContato
            {
                editContatoID = Convert.ToInt32(dgvContatos.SelectedRows[0].Cells["ID"].Value),
                presetNome = dgvContatos.SelectedRows[0].Cells["Nome"].Value.ToString()!,
                presetTelefone = dgvContatos.SelectedRows[0].Cells["Telefone"].Value.ToString()!,
                presetCategoria = dgvContatos.SelectedRows[0].Cells["Categoria"].Value.ToString()!,
            };

            screenFormsContato.ShowDialog();
            this.AtualizarDgvContatos();
        }

        // Editar Contato
        private void btnDeleteContato_Click(object sender, EventArgs e)
        {
            if (dgvContatos.SelectedRows.Count > 0)
            {
                new ContatoController().DeleteContato(Convert.ToInt32(dgvContatos.SelectedRows[0].Cells["ID"].Value));
                this.AtualizarDgvContatos();
            }

            else
            {
                MessageBox.Show("Selecione na tabela o contato à ser apagado.", "Aviso!");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
