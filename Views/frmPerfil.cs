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

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            // Nome

            lblNome.Text = UserSession.UserInfo["nome"].ToString();

            // Usuário

            lblUsuario.Text = UserSession.UserInfo["usuario"].ToString();

            // Telefone

            lblTelefone.Text = UserSession.UserInfo["telefone"].ToString();

            // Pecado

            lblPecado.Text = UserSession.UserInfo["pecado"].ToString();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnScreenContatos_Click(object sender, EventArgs e)
        {
            frmContatos screenContatos = new frmContatos();
            screenContatos.ShowDialog();
        }

        private void btnScreenCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias screenCategorias = new frmCategorias();
            screenCategorias.ShowDialog();
        }
    }
}
