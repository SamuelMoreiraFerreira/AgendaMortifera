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
    public partial class frmFormsContato : Form
    {
        public int editContatoID = 0;
        public string presetNome = "";
        public string presetTelefone = "";
        public string presetCategoria = "";

        public frmFormsContato()
        {
            InitializeComponent();
        }

        private void FormCreateContato_Load(object sender, EventArgs e)
        {
            cbxCategorias.DataSource = new CategoriaController().GetCategorias();

            cbxCategorias.DisplayMember = "Categoria";
            cbxCategorias.ValueMember = "ID";

            if (this.editContatoID != 0)
            {
                // Editando Contato

                this.Text = "Editando Contato";

                tbxNome.Text = this.presetNome;

                tbxTelefone.Text = this.presetTelefone;

                cbxCategorias.Text = this.presetCategoria;
            }

            else
            {
                // Inserindo Contato

                this.Text = "Criando Contato";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.editContatoID != 0)
            {
                // Editando Contato

                if (new ContatoController().ModifyContato(this.editContatoID, tbxNome.Text, tbxTelefone.Text, Convert.ToInt32(cbxCategorias.SelectedValue)))
                {
                    // Sucesso

                    MessageBox.Show("Contato alterado no Banco de Dados do Inferno!", "Sucesso");

                    this.Close();
                }

                else
                {
                    // Erro

                    MessageBox.Show("Ocorreu um erro ao alterar o contato. Tente novamente!", "Problemas Técnicos");

                }
            }

            else
            {
                // Inserindo Contato

                if (new ContatoController().CreateContato(tbxNome.Text, tbxTelefone.Text, Convert.ToInt32(cbxCategorias.SelectedValue)))
                {
                    // Sucesso

                    MessageBox.Show("Contato inserido no Banco de Dados do Inferno!", "Sucesso");

                    this.Close();
                }

                else
                {
                    // Erro

                    MessageBox.Show("Ocorreu um erro ao inserir o contato. Tente novamente!", "Problemas Técnicos");

                }
            }
        }

        private void tbx_TextChanged(object sender, EventArgs e)
        {
            // Validação dos Dados

            if (
                tbxNome.Text.Length > 0
                && tbxTelefone.Text.Length > 0
                && cbxCategorias.Text != null
            )

            {
                btnConfirmar.Enabled = true;
            }

            else
            {
                btnConfirmar.Enabled = false;
            }
        }
    }
}
