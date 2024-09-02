using Metodista.BancoDados;
using Metodista.EsqueciSenha;
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

namespace Metodista.Login
{
    public partial class Frm_Login : Form
    {
        // atributo
        public ConexaoBancoDados db = new ConexaoBancoDados();
        public MySqlDataReader reader = null;
        public string sql;

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void bSair_Click(object sender, EventArgs e)
        {
            // Fechando a aplicação com o
            // botao sair da tela de login
            if (db.conn != null) { db.conn.Close(); db.conn = null; }
            Application.Exit();
        }

        private void lblEntrar_Click(object sender, EventArgs e)
        {
            // verificar se o usuario digitou os campos necessarios
            if (String.IsNullOrEmpty(tUsuario.Text))
            {
                MessageBox.Show("Digite o usuário");
                tUsuario.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tSenha.Text))
            {
                MessageBox.Show("Digite a senha");
                tSenha.Focus();
                return;
            }

            try
            {
                
                // executando o metodo
                db.ConectarBancoDados();

                if (db.conn != null)
                {
                    
                    // verificando se o objeto está sendo usado
                    if (reader != null) { reader.Close(); reader = null; }

                    // preparando a query na tabela do banco de dados
                    sql = "select * from tab_usuarios " +
                          "where " +
                          "usuario = '" + tUsuario.Text + "' and " +
                          "senha = '" + tSenha.Text + "'; ";

                    // busca usuario e senha atraves do metodo
                    reader = db.SelectDados(sql);

                    // verificar se encontrou algo (usuario,senha) no banco de dados
                    if (reader.HasRows) // return true ou false
                    {
                        // fecha a conexao
                        db.conn.Close();

                        // esconder a tela de login
                        Frm_Login.ActiveForm.Hide();

                        // abrir tela principal
                        Frm_Principal principal = new Frm_Principal(tUsuario.Text);
                        principal.ShowDialog();

                        // fechando a aplicacao
                        if (db.conn != null) { db.conn.Close(); db.conn = null; }
                        Application.Exit();

                    } else
                    {
                        MessageBox.Show("Usuario/Senha não encontrado!");
                        return;
                    }             
                      
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro de autenticação " + ex.Message);
                if (db.conn != null) { db.conn.Close(); db.conn = null; }
                return;
            }
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            // Fechando a aplicação com o
            // botao sair da tela de login
            if (db.conn != null) { db.conn.Close(); db.conn = null; }
            Application.Exit();
        }

        private void lblEsqueciSenha_Click(object sender, EventArgs e)
        {
        
            Frm_EsqueciSenha esqueci = new Frm_EsqueciSenha();
            esqueci.ShowDialog();
            esqueci.Close();

        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
