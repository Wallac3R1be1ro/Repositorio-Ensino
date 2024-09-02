using Metodista.BancoDados;
using Metodista.Login;
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

namespace Metodista.EsqueciSenha
{
    public partial class Frm_EsqueciSenha : Form
    {

        public ConexaoBancoDados db = new ConexaoBancoDados();
        public MySqlDataReader reader = null;
        public string sql;        

        public Frm_EsqueciSenha()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (db.conn != null) { db.conn.Close(); db.conn = null; }
            Frm_EsqueciSenha.ActiveForm.Close();
        }

        private void btnNovaSenha_Click(object sender, EventArgs e)
        {
            // verificar se ha algo digitado no usuario
            if (String.IsNullOrEmpty(tUsuario.Text))
            {
                MessageBox.Show("Digite o usuário");
                tUsuario.Focus();
                return;
            }
            /*if (String.IsNullOrEmpty(tSenha.Text))
            {
                MessageBox.Show("Digite a senha");
                tSenha.Focus();
                return;
            }*/
            if (String.IsNullOrEmpty(tSenha.Text))
            {
                MessageBox.Show("Digite a nova senha");
                tSenha.Focus();
                return;
            }

            // verificar se ha algo digitado na senha

            // fazer a query de update do usuario
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
                          "update tab_usuarios" +
                          "set senha = " + tSenha.Text +
                          "where usuario = '" + tUsuario.Text + "'; ";

                    reader = db.SelectDados(sql);

                    if (reader.HasRows) // return true ou false
                    {
                        // fecha a conexao
                        db.conn.Close();

                        /* esconder a tela de login
                        Frm_Login.ActiveForm.Hide();

                        // abrir tela principal
                        Frm_Principal principal = new Frm_Principal(tUsuario.Text);
                        principal.ShowDialog();

                        // fechando a aplicacao
                        if (db.conn != null) { db.conn.Close(); db.conn = null; }
                        Application.Exit();*/
                        }
                        else
                        {
                            MessageBox.Show("Usuario/Senha não encontrado!");
                            return;
                        } 
                }
                // preparando a query na tabela do banco de dados
                sql = "usar update";

                // salvar o banco de dados (commit) criar o metodo na classe

                // fechar o banco

                // enviar msg para usuario de Usuario/Senha criada

                // fechar o formulario

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro de autenticação " + ex.Message);
                if (db.conn != null) { db.conn.Close(); db.conn = null; }
                return;
            }
        }

        private void Frm_EsqueciSenha_Load(object sender, EventArgs e)
        {

        }
    }
}
