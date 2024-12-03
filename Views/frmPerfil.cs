using AgendaMortifera.StructureDB;
using AgendaMortifera.Views;
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

namespace AgendaMortifera.Controllers
{
    public partial class frmPerfil : Form
    {

        public frmPerfil()
        {
            InitializeComponent();
        }

        private void AtualizarDgvCategorias()
        {
            dgvCategorias.DataSource = new CategoriaController().GetCategorias();
        }

        // Validação dos dados para a troca de senha
        private void tbxAlterarSenha_TextChanged(object sender, EventArgs e)
        {
            // Mínimo para a senha é 8 caractéres

            if (tbxAlterarSenha.Text.Length >= 8)
            {
                btnConfirmarSenha.Enabled = true;
            }

            else
            {
                btnConfirmarSenha.Enabled = false;
            }
        }

        // Alterar Senha
        private void btnConfirmarSenha_Click(object sender, EventArgs e)
        {
            if (new UserController().ModifySenha(UserSession.UserInfo["usuario"].ToString()!, tbxAlterarSenha.Text))
            {
                this.Close();

                MessageBox.Show("Sua senha foi alterada com sucesso! Entre novamente.", "Sucesso!");
            }

            else
            {
                MessageBox.Show("Ocorreu um erro ao alterar sua senha. Tente novamente!", "Problemas Técnicos");
            }
        }

        // Adicionar Categoria
        private void btnAdicionarCategoria_Click(object sender, EventArgs e)
        {
            frmAddCategoria screenAddCategoria = new frmAddCategoria();

            screenAddCategoria.ShowDialog();
        }

        // Editar Categoria
        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {

        }

        // Remover Categoria
        private void btnExcluirCategoria_Click(object sender, EventArgs e)
        {

        }

        // Botão de Atualizar
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            this.AtualizarDgvCategorias();
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            this.AtualizarDgvCategorias();

            lblNome.Text = UserSession.UserInfo["nome"].ToString();

            lblUsuario.Text = UserSession.UserInfo["usuario"].ToString();

            lblTelefone.Text = UserSession.UserInfo["telefone"].ToString();

            lblPecado.Text = UserSession.UserInfo["pecado"].ToString();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            frmContatos screenContatos = new frmContatos();
            screenContatos.ShowDialog();
        }
    }
}
