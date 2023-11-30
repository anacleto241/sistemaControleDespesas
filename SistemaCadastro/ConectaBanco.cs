using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaCadastro
{
    internal class ConectaBanco
    {
        // String de conexão
        MySqlConnection conexao = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10665627;password=8FBApiplrQ;database=sql10665627");
        public string mensagem;
        // Método no Conecta Banco

        public bool insereDespesas(Despesas novaDespesas)
        {
            try
            {
                conexao.Close();
                conexao.Open();
                MySqlCommand cmd =
                    new MySqlCommand("sp_insereDespesas", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("descricaoDespesa", novaDespesas.DescricaoDespesa1);
                cmd.Parameters.AddWithValue("fk_categoria", novaDespesas.CategoriaID1);
                cmd.Parameters.AddWithValue("Valor", novaDespesas.Valor1);

                cmd.ExecuteNonQuery();//executar no banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }

        }// fim do insereCategoriaDespesas
        public bool insereCategoriaDespesas(CategoriaDespesas novaCategoriaDespesas)
        {
            try
            {
                //conexao.Close();
                conexao.Open();
                MySqlCommand cmd =
                    new MySqlCommand("sp_insereCategoriaDespesas", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nomeCategoria", novaCategoriaDespesas.NomeCategoria);
                cmd.Parameters.AddWithValue("descricaoCategoria", novaCategoriaDespesas.DescricaoCategoria);
                cmd.ExecuteNonQuery();//executar no banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }

        }// fim do insereCategoriaDespesas

        public DataTable listaCategorias()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("sp_listaCategorias", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista_categorias

         public DataTable listaDespesas()
         {
             MySqlCommand cmd = new MySqlCommand("sp_listaDespesas", conexao);
             cmd.CommandType = CommandType.StoredProcedure;
             try
             {
                 conexao.Open();
                 MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                 DataTable tabela = new DataTable();
                 da.Fill(tabela);
                 return tabela;
             }// fim try
             catch (MySqlException e)
             {
                 mensagem = "Erro:" + e.Message;
                 return null;
             }
             finally
             {
                 conexao.Close();
             }

         }// fim lista_Despesas

        public bool deletaDespesa(int idRemoveDespesa)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removeDespesa", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idDespesa", idRemoveDespesa);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deletaBanda 

        public bool alteraDespesas(Despesas novaDespesas, int idDespesa)
        {
            try
            {
                conexao.Close();
                conexao.Open();
                MySqlCommand cmd =
                    new MySqlCommand("sp_alteraDespesa", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", idDespesa);
                cmd.Parameters.AddWithValue("descricao", novaDespesas.DescricaoDespesa1);
                cmd.Parameters.AddWithValue("categoria", novaDespesas.CategoriaID1);
                cmd.Parameters.AddWithValue("Valor", novaDespesas.Valor1);

                cmd.ExecuteNonQuery();//executar no banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = "Erro: " + erro.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }

        }// fim do insereCategoriaDespesas

        public bool deletaCategoria(int idRemoveCategoria)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removeCategoria", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idCategoria", idRemoveCategoria);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deletaCategoria
        public bool alteraCategoria(CategoriaDespesas novaCategoria, int idCategoria)
        {
            try
            {
                conexao.Close();
                conexao.Open();
                MySqlCommand cmd =
                    new MySqlCommand("sp_alteraCategoria", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idCategoria", idCategoria);
                cmd.Parameters.AddWithValue("nomeCategoria", novaCategoria.NomeCategoria);
                cmd.Parameters.AddWithValue("descricaoCategoria", novaCategoria.DescricaoCategoria);

                cmd.ExecuteNonQuery();//executar no banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = "Erro: " + erro.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }

        }// fim do insereCategoriaDespesas

        public bool verifica(string user, string pass)
        {
            string senhaHash = Biblioteca.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("consultaLogin", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("usuario", user);
            cmd.Parameters.AddWithValue("senha", senhaHash);
            try
            {
                conexao.Open();//abrindo a conexão;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();// tabela virtual
                da.Fill(ds); //passando os valores consultados para o DataSet
                if (ds.Tables[0].Rows.Count > 0) // verifica se houve retorno
                    return true;
                else
                    return false;

            }
            catch (MySqlException er)
            {
                mensagem = "Erro" + er.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

    }//fim classe
}
