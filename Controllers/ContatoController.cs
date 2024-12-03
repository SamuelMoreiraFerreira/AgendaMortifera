using AgendaMortifera.StructureDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMortifera.Controllers
{
    internal class ContatoController
    {
        public bool CreateContato(string nome, string telefone, int idCategoria)
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmdInsertContato = new MySqlCommand(
                        "INSERT INTO tb_contatos (nome, telefone, id_categoria) VALUES (@nome, @telefone, @idCategoria);",
                        connection
                    );

                    cmdInsertContato.Parameters.AddWithValue("@nome", nome);

                    cmdInsertContato.Parameters.AddWithValue("@telefone", telefone);

                    cmdInsertContato.Parameters.AddWithValue("@idCategoria", idCategoria);

                    if (cmdInsertContato.ExecuteNonQuery() > 0)
                    {
                        // Contato Inserido

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

        public bool DeleteContato(int idContato)
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmdDeleteContato = new MySqlCommand(
                        "DELETE FROM tb_contatos WHERE tb_contatos.id_contato = @idContato;",
                        connection
                    );

                    cmdDeleteContato.Parameters.AddWithValue("@idContato", idContato);

                    if (cmdDeleteContato.ExecuteNonQuery() > 0)
                    {
                        // Contato apagado

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

        public bool ModifyContato(int idContato, string nome, string telefone, int idCategoria)
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmdUpdateContato = new MySqlCommand(
                        "UPDATE tb_contatos SET tb_contatos.nome = @nome, tb_contatos.telefone = @telefone, tb_contatos.id_categoria = @idCategoria WHERE tb_contatos.id_contato = @idContato;",
                        connection
                    );

                    cmdUpdateContato.Parameters.AddWithValue("@nome", nome);

                    cmdUpdateContato.Parameters.AddWithValue("@telefone", telefone);

                    cmdUpdateContato.Parameters.AddWithValue("@idCategoria", idCategoria);

                    cmdUpdateContato.Parameters.AddWithValue("@idContato", idContato);

                    if (cmdUpdateContato.ExecuteNonQuery() > 0)
                    {
                        // Informações do contato alterados

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

        public DataTable GetContatos()
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlDataAdapter adpGetContatos = new MySqlDataAdapter(
                        "SELECT tb_contatos.id_contato AS 'ID', tb_contatos.nome AS 'Nome', tb_contatos.telefone AS 'Telefone', tb_categorias.categoria AS 'Categoria' FROM tb_contatos INNER JOIN tb_categorias ON tb_contatos.id_categoria = tb_categorias.id_categoria WHERE tb_contatos.usuario = SUBSTRING_INDEX(USER(), '@', 1);",
                        connection
                    );

                    DataTable table = new DataTable();

                    adpGetContatos.Fill(table);

                    // Tabela contendo os contatos
                    return table;
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);

                    return new DataTable();
                }

                finally
                {
                    connection.Close();
                }
            }

            else
            {
                return new DataTable();
            }
        }
    }
}
