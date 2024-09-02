using Metodista.BancoDados;
using Metodista.Principal;
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

namespace Metodista.ConsultarProduto
{
    public partial class Frm_ConsultarProduto : Form
    {
        // atributo
        private ConexaoBancoDados db = new ConexaoBancoDados();
        private MySqlDataReader reader;
        private string sql;


        // construtor
        public Frm_ConsultarProduto()
        {
            InitializeComponent();
        }

        // o metodo Load é resp. por preparar a tela (componetes) 
        // para o usuario antes de aparecer a tela final
        private void Frm_ConsultarProduto_Load(object sender, EventArgs e)
        {

            try
            {
                // abrindo o banco de dados
                db.ConectarBancoDados();

                // verificando se o objeto está sendo usado
                if (reader != null) { reader.Close(); reader = null; }

                // preparando a query
                sql = "select * from categoria;";

                // selecionando dados da tabela categoria
                reader = db.SelectDados(sql);

                // verifica se encontrou algum registro no banco de dados
                if (reader.HasRows) // true ou false
                {
                    // limpar o combobox
                    cbCategoria.Items.Clear();

                    while (reader.Read())
                    {
                        cbCategoria.Items.Add(reader.GetString(0) + " - " + reader.GetString(1));
                    }
                }
                // verificando se o objeto está sendo usado
                if (reader != null) { reader.Close(); reader = null; }
                // fechando o banco de dados
                if (db.conn != null) { db.conn.Close(); db.conn = null; }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                // fechando o banco de dados
                if (db.conn != null) { db.conn.Close(); db.conn = null; }
                return;                
            }

        }

        // metodo
        private void lblSair_Click(object sender, EventArgs e)
        {
            // fechando o banco de dados
            if (db.conn != null) { db.conn.Close(); db.conn = null; }
            // fechando a tela (form) principal
            Frm_ConsultarProduto.ActiveForm.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cate;

            try
            {
                // o valor escolhido 
                cate = cbCategoria.Text;

                // retirando o texto do codigo categoria
                // 100 - TINTAS
                cate = cate.Split('-')[0].Trim(); // resultado 100

                // abrindo o banco de dados
                db.ConectarBancoDados();

                // verificando se o objeto está sendo usado
                if (reader != null) { reader.Close(); reader = null; }

                // preparando a query
                sql = "select codigo, nomeproduto from produtos " +
                      " where codcate = '" + cate + "'; ";

                // selecionando dados da tabela categoria
                reader = db.SelectDados(sql);

                // verifica se encontrou algum registro no banco de dados
                if (reader.HasRows) // true ou false
                {
                    // limpar o combobox
                    cbProdutos.Items.Clear();

                    while (reader.Read())
                    {
                        cbProdutos.Items.Add(reader.GetString(0) + " - " + reader.GetString(1));
                    }
                }
                // verificando se o objeto está sendo usado
                if (reader != null) { reader.Close(); reader = null; }
                // fechando o banco de dados
                if (db.conn != null) { db.conn.Close(); db.conn = null; }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                // fechando o banco de dados
                if (db.conn != null) { db.conn.Close(); db.conn = null; }
                return;
            }

        }

        private void cbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prod;
            string[] result = new string[4];

            try
            {
                // o valor escolhido 
                prod = cbProdutos.Text;

                // retirando o texto do codigo categoria
                // 10 - PAREDE E TETO
                prod = prod.Split('-')[0].Trim(); // resultado 10

                // abrindo o banco de dados
                db.ConectarBancoDados();

                // verificando se o objeto está sendo usado
                if (reader != null) { reader.Close(); reader = null; }

                // preparando a query
                sql = "select * from precoproduto " +
                      " where codprod = '" + prod + "'; ";

                // selecionando dados da tabela categoria
                reader = db.SelectDados(sql);

                // verifica se encontrou algum registro no banco de dados
                if (reader.HasRows) // true ou false
                {
                    // limpar o DataGridView
                    dgvDados.Rows.Clear();

                    // limpar o vetor
                    Array.Clear(result, 0, result.Length);

                    while (reader.Read())
                    {
                        result[0] = reader.GetString(0);
                        result[1] = reader.GetString(1);
                        result[2] = reader.GetString(2);
                        result[3] = reader.GetString(3);

                        dgvDados.Rows.Add(result);

                    }
                }
                // verificando se o objeto está sendo usado
                if (reader != null) { reader.Close(); reader = null; }
                // fechando o banco de dados
                if (db.conn != null) { db.conn.Close(); db.conn = null; }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                // fechando o banco de dados
                if (db.conn != null) { db.conn.Close(); db.conn = null; }
                return;
            }

        }
    }
}
