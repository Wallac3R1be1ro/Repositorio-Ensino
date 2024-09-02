
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodista.BancoDados
{
    public class ConexaoBancoDados
    {
        // atributos
        public MySqlConnection conn;            // objeto resp. pela conexao com o banco de dados
        public MySqlTransaction transaction;    // objeto resp. pela transaçao no banco de dados
        public MySqlCommand cmd;                // objeto resp. pelas linhas de comando com o banco de dados
        public MySqlDataReader reader;

        // construtor vazio da classe
        public ConexaoBancoDados()
        {
        }

        // metodo para conectar o banco de dados (autenticação)
        public void ConectarBancoDados()
        {

            try
            { 
                // execução dos comandos
                
                // dataSorce da conexao (configuração)
                string data_source = "datasource=127.0.0.1;username='root';password='';" +
                                     "database='metodista'; Allow Zero Datetime=true";

                // criando a conexão 
                conn = new MySqlConnection( data_source );  // instancia da classe MySqlConnection
                
                // criando a linha de comando sql
                cmd = conn.CreateCommand();

                // abrindo o banco de dados
                conn.Open();

                // pedir uma transaçao com o banco de dados
                transaction = conn.BeginTransaction();

                // Deve atribuir o objeto de transação e a conexão ao objeto
                // Command para uma transação local pendente
                cmd.Connection = conn;
                cmd.CommandTimeout = 99999;
                cmd.Transaction = transaction;

            } catch (Exception ex)
            {
                // erro
                MessageBox.Show("Erro de conexão com o banco de dados!" + ex.Message);
                if (conn != null) { conn.Close(); conn = null; }
                return;
            }

        }

        // metodo commit
        public void CommitBanco()
        {
            transaction.Commit();
        }

        // metodo de busca de registo no banco de dados
        public MySqlDataReader SelectDados(string sql)
        {
            try
            {
                // executar o comando insert no banco
                cmd = new MySqlCommand(sql, conn);

                // executar a query
                reader = cmd.ExecuteReader();

                return reader;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de busca!!!");
                reader = null;
                return reader;
            }
        }

        // metodo update
        public void UpdateDados(string sql)
        {

            try
            {
                // executar o comando insert no banco
                cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (MySqlException ex1)
                {
                    MessageBox.Show(ex1.ToString());
                }
               
            }
        }

        // metodo de apagar/excluir
        public bool DeleteDados(string sql)
        {
            try
            {
                // executar o comando insert no banco
                cmd = new MySqlCommand(sql, conn);

                // executar a query
                reader = cmd.ExecuteReader();

                return true;
            }
            catch (Exception)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (MySqlException ex1)
                {
                    MessageBox.Show(ex1.ToString());
                    return false;
                }
            }
            return false;
        }

        // metodo de incluir
        public bool InsertDados(string sql)
        {
            try
            {
                // executar o comando insert no banco
                cmd = new MySqlCommand(sql, conn);

                // executar a query
                reader = cmd.ExecuteReader();
                return true;

            }
            catch (Exception)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (MySqlException ex1)
                {
                    MessageBox.Show(ex1.ToString());
                    return false;
                }
            }
            return false;
        }

    }
}
