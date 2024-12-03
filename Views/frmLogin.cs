using AgendaMortifera.Controllers;
using AgendaMortifera.Data;
using AgendaMortifera.StructureDB;
using MySql.Data.MySqlClient;
using System.Xml.Linq;

namespace AgendaMortifera
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void tbx_TextChanged(object sender, EventArgs e)
        {
            // Validação dos dados dos TextBox's

            if (tbxUser.Text != "" && tbxPassword.Text.Length >= 8)
            {
                btnLogin.Enabled = true;
            }

            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (new UserController().ValidateUser(tbxUser.Text, tbxPassword.Text))
            {
                // Usuário Validado

                tbxUser.Text = "";
                tbxPassword.Text = "";

                UserSession.Conexao = ConexaoDB.Connection(tbxUser.Text, tbxPassword.Text)!;

                UserSession.UserInfo = new UserController().GetUser(tbxUser.Text)!;

                frmPerfil screenPerfil = new frmPerfil();

                this.Hide();

                screenPerfil.ShowDialog();

                this.Show();
            }

            else
            {
                // Usuário Não Validado

                MessageBox.Show("Usuário ou senha incorreta.", "Tente Novamente!");
            }
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrar screenCadastro = new frmCadastrar();

            screenCadastro.ShowDialog();
        }
    }
}
