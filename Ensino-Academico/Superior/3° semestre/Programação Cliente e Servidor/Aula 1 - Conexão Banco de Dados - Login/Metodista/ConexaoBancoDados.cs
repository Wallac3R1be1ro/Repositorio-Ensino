using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MasterSenerII
{
    public class ConexaoBancoDados
    {
        // Objeto Conexao
        public MySqlConnection conn = null;

        // classes do banco de dados
        public MySqlTransaction transaction = null;
        public MySqlCommand cmd = null;
        public MySqlDataReader reader = null;

        // construtor
        public ConexaoBancoDados()
        {

        }

        // SobreCarga
        public void ConectarBancoDados(string usu, string sen)
        {

            try
            {
                // dataSorce da conexao
                string data_source = "datasource=172.18.2.12;username='" + 
                                        usu.Trim().ToLower() + "';password='" + 
                                        sen.Trim().ToLower() + "';database='mastersener'; Allow Zero Datetime=true";

                // criando a conexão 
                conn = new MySqlConnection(data_source);
                cmd = conn.CreateCommand();

                // e abrindo o banco de dados
                conn.Open();
                transaction = conn.BeginTransaction();

                // Deve atribuir o objeto de transação e a conexão ao objeto Command para uma transação local pendente
                cmd.Connection = conn;
                cmd.CommandTimeout = 99999;
                cmd.Transaction = transaction;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();
                conn = null;
                return;

            }

        }

        public void ConectarBancoDadosDP(string usu, string sen)
        {

            try
            {
                // dataSorce da conexao
                string data_source = "datasource=172.18.2.12;username='" +
                                        usu.Trim().ToLower() + "';password='" +
                                        sen.Trim().ToLower() + "';database='snrbrasil'; Allow Zero Datetime=true";

                // criando a conexão 
                conn = new MySqlConnection(data_source);
                cmd = conn.CreateCommand();

                // e abrindo o banco de dados
                conn.Open();
                transaction = conn.BeginTransaction();

                // Deve atribuir o objeto de transação e a conexão ao objeto Command para uma transação local pendente
                cmd.Connection = conn;
                cmd.CommandTimeout = 99999;
                cmd.Transaction = transaction;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();
                conn = null;
                return;

            }

        }

        // Commit o banco de dados
        public void CommitBanco()
        {
            transaction.Commit();

        }

        // Insere registro no banco de dados
        public bool InsertRegistros(string sql)
        {
            try
            {
                // Deve atribuir o objeto de transação e a conexão ao objeto Command para uma transação local pendente
                cmd = new MySqlCommand(sql, conn);

                // executa a query
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);

                // Executando o roll back da transaction. Voltar tudo que fez
                try
                {
                    // volta a tudo que fez no banco (não grava)
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    /*
                    Este bloco de captura lidará com quaisquer erros que possam ter ocorrido
                    no servidor que faria com que a reversão falhasse, como uma conexão fechada. 
                    */

                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }

            }

            return false;

        }

        // Update registro no banco de dados
        public bool UpdateRegistros(string sql)
        {
            try
            {
                // Deve atribuir o objeto de transação e a conexão ao objeto Command para uma transação local pendente
                cmd = new MySqlCommand(sql, conn);

                // executa a query
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);

                // Executando o roll back da transaction. Voltar tudo que fez
                try
                {
                    // volta a tudo que fez no banco (não grava)
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    /*
                    Este bloco de captura lidará com quaisquer erros que possam ter ocorrido
                    no servidor que faria com que a reversão falhasse, como uma conexão fechada. 
                    */

                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }

            }

            return false;

        }

        // Delete registro no banco de dados
        public bool DeleteRegistros(string sql)
        {
            try
            {
                // Deve atribuir o objeto de transação e a conexão ao objeto Command para uma transação local pendente
                cmd = new MySqlCommand(sql, conn);

                // executa a query
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            return false;
        }

        // Busca registros no banco de dados
        public MySqlDataReader BuscaRegistros(string sql)
        {

            try
            {

                // executar o comando insert no banco
                cmd = new MySqlCommand(sql, conn);

                // executar a query
                reader = cmd.ExecuteReader();

                return reader;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public MySqlDataReader BuscaRegistrosBanco(string sql, string parametros)
        {
            string[] param;

            try
            {

                // definimos a variavel pra executar a consulta da respectiva conexao 
                cmd = new MySqlCommand(sql, conn);


                // dizemos qual é o tipo de consulta 
                cmd.CommandType = CommandType.StoredProcedure;
                param = parametros.Split(';');
                for (int i = 0; i < param.Length; i++)
                {
                    if (!param[i].Equals(""))
                        cmd.Parameters.AddWithValue("item", param[i]);
                }

                // executa consulta
                reader = cmd.ExecuteReader();

                return reader;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

    }
}
