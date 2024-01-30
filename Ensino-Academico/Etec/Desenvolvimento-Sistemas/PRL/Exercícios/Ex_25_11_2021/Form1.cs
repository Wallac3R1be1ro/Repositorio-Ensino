using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_25_11_2021
{

    public partial class Form1 : Form
    {
        string[,] Jogadores = new string[11, 2];
        int ContadorJogador = 0;
        int ContadorFaltas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        


        private void BtnFaltas_Click(object sender, EventArgs e)
        {
            if (ContadorFaltas <= 10 && txtFaltas.Text != " ")
            {
                Jogadores[ContadorFaltas, 1] = txtFaltas.Text;
                ContadorFaltas++;
                txtFaltas.Text = null;
            }
            else
            {
                BtnFaltas.Enabled = false;
            }


        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
            ListaJogadores.Items.Clear();
            for (int i = 0; i < ContadorJogador; i++)
            {
                ListaJogadores.Items.Add(Jogadores[i, 0] + " - Total Faltas: " + Jogadores[i, 1]);
            }

        }

        private void BtnJogador_Click_1(object sender, EventArgs e)
        {
            if (ContadorJogador <= 10 && txtJogador.Text != " ")
            {
                Jogadores[ContadorJogador, 0] = txtJogador.Text;
                ContadorJogador++;
                txtJogador.Text = null;
            }
            else
            {
                BtnJogador.Enabled = false;
            }
        }
    }
}
