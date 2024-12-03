using AgendaMortifera.Controllers;
using AgendaMortifera.Data;
using AgendaMortifera.StructureDB;
using MySql.Data.MySqlClient;
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
    public partial class frmFormsCategoria : Form
    {
        public int editCategoriaID = 0;
        public string presetName = "";

        public frmFormsCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCreateCategoria_Load(object sender, EventArgs e)
        {
            if (this.editCategoriaID != 0)
            {
                // Editando Categoria

                this.Text = "Editando Categoria";

                tbxNomeCategoria.Text = this.presetName;
            }

            else
            {
                // Inserindo Categoria

                this.Text = "Adicionar Categoria";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.editCategoriaID != 0)
            {
                // Editando Categoria

                if (new CategoriaController().ModifyCategoria(this.editCategoriaID, tbxNomeCategoria.Text))
                {
                    // Sucesso

                    MessageBox.Show("Nome da categoria alterada no Banco de Dados do Inferno!", "Sucesso");

                    this.Close();
                }

                else
                {
                    // Erro

                    MessageBox.Show("Ocorreu um erro ao editar. Tente novamente!", "Problemas Técnicos");

                }
            }

            else
            {
                // Inserindo Categoria

                if (new CategoriaController().CreateCategoria(tbxNomeCategoria.Text))
                {
                    // Sucesso

                    MessageBox.Show("Categoria cadastrada no Banco de Dados do Inferno!", "Sucesso");

                    this.Close();

                }

                else
                {
                    // Erro

                    MessageBox.Show("Ocorreu um erro ao inserir. Tente novamente!", "Problemas Técnicos");

                }
            }
        }
    }
}
