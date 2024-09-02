using Metodista.BancoDados;
using Metodista.ConsultarProduto;
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

namespace Metodista.Principal
{
    public partial class Frm_Principal : Form
    {
        private ConexaoBancoDados db = new ConexaoBancoDados();

        public Frm_Principal(string usuario)
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            // fechando o banco de dados
            if (db.conn != null) { db.conn.Close(); db.conn = null; }
            // fechando a tela (form) principal
            Frm_Principal.ActiveForm.Close();
        }

        private void SMConsultarProduto_Click(object sender, EventArgs e)
        {
            // chamar o formulario consultar produto
            Frm_ConsultarProduto consultarProduto = new Frm_ConsultarProduto();
            consultarProduto.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
