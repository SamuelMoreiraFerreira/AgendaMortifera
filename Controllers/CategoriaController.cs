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
    internal class CategoriaController
    {
        public bool CreateCategoria(string categoria)
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmdInsertCategoria = new MySqlCommand(
                        "INSERT INTO tb_categorias (categoria) VALUES (@categoria);",
                        connection
                    );

                    cmdInsertCategoria.Parameters.AddWithValue("@categoria", categoria);

                    if (cmdInsertCategoria.ExecuteNonQuery() > 0)
                    {
                        // Categoria criada

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

        public bool DeleteCategoria(int idCategoria)
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmdDeleteCategoria = new MySqlCommand(
                        "DELETE FROM tb_categorias WHERE tb_categorias.id_categoria = @idCategoria;",
                        connection
                    );

                    cmdDeleteCategoria.Parameters.AddWithValue("@idCategoria", idCategoria);

                    if (cmdDeleteCategoria.ExecuteNonQuery() > 0)
                    {
                        // Categoria excluída

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

        public bool ModifyCategoria(int idCategoria, string novoNome)
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmdUpdateCategoria = new MySqlCommand(
                        "UPDATE tb_categorias SET tb_categorias.categoria = @novoNome WHERE tb_categorias.id_categoria = @idCategoria;",
                        connection
                    );

                    cmdUpdateCategoria.Parameters.AddWithValue("@novoNome", novoNome);

                    cmdUpdateCategoria.Parameters.AddWithValue("@idCategoria", idCategoria);

                    if (cmdUpdateCategoria.ExecuteNonQuery() > 0)
                    {
                        // Nome da categoria alterado

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

        public DataTable GetCategorias()
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    // Ponte entre a aplicação e a database, permite trabalhar com dados em memória (MySqlDataAdapter)

                    MySqlDataAdapter adpGetCategorias = new MySqlDataAdapter (
                        "SELECT tb_categorias.id_categoria AS 'ID', tb_categorias.categoria AS 'Categoria' FROM tb_categorias WHERE tb_categorias.usuario = SUBSTRING_INDEX(USER(), '@', 1);",
                        connection
                    );

                    DataTable table = new DataTable();

                    // Inserindo os dados na tabela criada
                    adpGetCategorias.Fill(table);

                    // Tabela contendo as categorias
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
