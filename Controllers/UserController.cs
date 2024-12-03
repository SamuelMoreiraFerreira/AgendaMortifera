using MySql.Data.MySqlClient;
using AgendaMortifera.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data;
using AgendaMortifera.StructureDB;

namespace AgendaMortifera.Controllers
{
    internal class UserController
    {
        public bool CreateUser(string pecado, string nome, string usuario, string senha, string? telefone)
        {
            MySqlConnection connection = ConexaoDB.Connection();

            try
            {
                connection.Open();

                MySqlCommand cmdInsertUser = new MySqlCommand(
                    $@"
                        INSERT INTO tb_usuarios VALUES (@pecado, @nome, @usuario, @telefone, @senha);
                        CREATE USER '{usuario}'@'%' IDENTIFIED BY '{senha}';
                        GRANT ALL PRIVILEGES ON db_agenda.* TO '{usuario}'@'%';
                    ",
                    connection
                );

                cmdInsertUser.Parameters.AddWithValue("@pecado", pecado);

                cmdInsertUser.Parameters.AddWithValue("@nome", nome);

                cmdInsertUser.Parameters.AddWithValue("@usuario", usuario);

                cmdInsertUser.Parameters.AddWithValue("@telefone", telefone);

                cmdInsertUser.Parameters.AddWithValue("@senha", senha);

                // Retornará a quantidade de linhas afetadas (ExecuteNonQuery)

                if (cmdInsertUser.ExecuteNonQuery() > 0)
                {
                    // Usuário Inserido

                    return true;
                }

                else
                {
                    // Erro

                    return false;
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                return false;
            }

            finally
            {
                connection.Close();
            }
        }

        public bool DeleteUser(string usuario)
        {
            MySqlConnection connection = ConexaoDB.Connection();

            try
            {
                connection.Open();

                MySqlCommand cmdDeleteUser = new MySqlCommand(
                    $@"
                        DELETE FROM tb_usuarios WHERE tb_usuarios.usuario = @usuario;
                        DROP USER '{usuario}'@'%';
                    ",
                    connection
                );

                cmdDeleteUser.Parameters.AddWithValue("@usuario", usuario);

                cmdDeleteUser.ExecuteNonQuery();

                // Usuário Deletado

                return true;
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                return false;
            }

            finally
            {
                connection.Close();
            }
        }

        public bool ModifySenha(string usuario, string novaSenha)
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmdUpdatePassword = new MySqlCommand(
                        $@"
                            UPDATE tb_usuarios SET tb_usuarios.senha = @novaSenha WHERE tb_usuarios.usuario = @usuario;
                            ALTER USER '{usuario}'@'%' IDENTIFIED BY '{novaSenha}'
                        ",
                        connection
                    );

                    cmdUpdatePassword.Parameters.AddWithValue("@usuario", usuario);

                    cmdUpdatePassword.Parameters.AddWithValue("@novaSenha", novaSenha);

                    if (cmdUpdatePassword.ExecuteNonQuery() > 0)
                    {
                        // Senha do usuário alterada

                        return true;
                    }

                    else
                    {
                        // Erro

                        return false;
                    }

                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);

                    return false;
                }

                finally
                {
                    connection.Close();
                }
            }

            else
            {
                return false;
            }
        }

        public Dictionary<string, object>? GetUser(string usuario)
        {
            MySqlConnection connection = ConexaoDB.Connection();

            try
            {
                connection.Open();

                MySqlCommand cmdGetUser = new MySqlCommand(
                    "SELECT tb_usuarios.pecado, tb_usuarios.nome, tb_usuarios.usuario, tb_usuarios.telefone, tb_usuarios.senha FROM tb_usuarios WHERE tb_usuarios.usuario = @usuario;",
                    connection
                );

                cmdGetUser.Parameters.AddWithValue("@usuario", usuario);

                MySqlDataReader result = cmdGetUser.ExecuteReader();

                if (result.Read())
                {
                    // Passando os dados do MySqlDataReader para um Dictionary para manter os dados após o fechamento da conexão.

                    // Tipo Object -> Armazena qualquer tipo de dado
                    Dictionary<string, object> returnValue = new Dictionary<string, object>();

                    for (int i = 0; i < result.FieldCount; i++)
                    {
                        returnValue[result.GetName(i)] = result.GetValue(i);
                    }

                    // Dicionário com as informações do usuário

                    return returnValue;
                }

                else
                {
                    // Erro

                    return null;
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                return null;
            }

            finally
            {
                connection.Close();
            }
        }

        public bool ValidateUser(string usuario, string senha)
        {
            MySqlConnection connection = ConexaoDB.Connection();

            try
            {
                connection.Open();

                MySqlCommand cmdSelectUser = new MySqlCommand(
                    "SELECT * FROM tb_usuarios WHERE BINARY tb_usuarios.usuario = @usuario AND BINARY tb_usuarios.senha = @senha;",
                    connection
                );

                cmdSelectUser.Parameters.AddWithValue("@usuario", usuario);

                cmdSelectUser.Parameters.AddWithValue("@senha", senha);

                // Retorna o conjunto dos resultados gerados (ExecuteReader)
                MySqlDataReader result = cmdSelectUser.ExecuteReader();

                if (result.Read())
                {
                    // Usuário Validado

                    return true;
                }

                else
                {
                    // Usuário Não Validado

                    return false;
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                return false;
            }

            finally
            {
                connection.Close();
            }
        }
    }
}
