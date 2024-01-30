
namespace Ex_25_11_2021
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFaltas = new System.Windows.Forms.TextBox();
            this.BtnJogador = new System.Windows.Forms.Button();
            this.BtnFaltas = new System.Windows.Forms.Button();
            this.BtnArray = new System.Windows.Forms.Button();
            this.ListaJogadores = new System.Windows.Forms.ListBox();
            this.txtJogador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faltas:";
            // 
            // txtFaltas
            // 
            this.txtFaltas.Location = new System.Drawing.Point(89, 40);
            this.txtFaltas.Name = "txtFaltas";
            this.txtFaltas.Size = new System.Drawing.Size(321, 20);
            this.txtFaltas.TabIndex = 3;
            // 
            // BtnJogador
            // 
            this.BtnJogador.Location = new System.Drawing.Point(416, 9);
            this.BtnJogador.Name = "BtnJogador";
            this.BtnJogador.Size = new System.Drawing.Size(75, 23);
            this.BtnJogador.TabIndex = 4;
            this.BtnJogador.Text = "Jogador";
            this.BtnJogador.UseVisualStyleBackColor = true;
            this.BtnJogador.Click += new System.EventHandler(this.BtnJogador_Click_1);
            // 
            // BtnFaltas
            // 
            this.BtnFaltas.Location = new System.Drawing.Point(416, 38);
            this.BtnFaltas.Name = "BtnFaltas";
            this.BtnFaltas.Size = new System.Drawing.Size(75, 23);
            this.BtnFaltas.TabIndex = 5;
            this.BtnFaltas.Text = "Faltas";
            this.BtnFaltas.UseVisualStyleBackColor = true;
            this.BtnFaltas.Click += new System.EventHandler(this.BtnFaltas_Click);
            // 
            // BtnArray
            // 
            this.BtnArray.Location = new System.Drawing.Point(416, 65);
            this.BtnArray.Name = "BtnArray";
            this.BtnArray.Size = new System.Drawing.Size(75, 23);
            this.BtnArray.TabIndex = 6;
            this.BtnArray.Text = "Array";
            this.BtnArray.UseVisualStyleBackColor = true;
            this.BtnArray.Click += new System.EventHandler(this.BtnArray_Click);
            // 
            // ListaJogadores
            // 
            this.ListaJogadores.FormattingEnabled = true;
            this.ListaJogadores.Location = new System.Drawing.Point(15, 127);
            this.ListaJogadores.Name = "ListaJogadores";
            this.ListaJogadores.Size = new System.Drawing.Size(476, 238);
            this.ListaJogadores.TabIndex = 7;
            // 
            // txtJogador
            // 
            this.txtJogador.Location = new System.Drawing.Point(89, 11);
            this.txtJogador.Name = "txtJogador";
            this.txtJogador.Size = new System.Drawing.Size(321, 20);
            this.txtJogador.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 442);
            this.Controls.Add(this.txtJogador);
            this.Controls.Add(this.ListaJogadores);
            this.Controls.Add(this.BtnArray);
            this.Controls.Add(this.BtnFaltas);
            this.Controls.Add(this.BtnJogador);
            this.Controls.Add(this.txtFaltas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ex35 Array Jogadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFaltas;
        private System.Windows.Forms.Button BtnJogador;
        private System.Windows.Forms.Button BtnFaltas;
        private System.Windows.Forms.Button BtnArray;
        private System.Windows.Forms.ListBox ListaJogadores;
        private System.Windows.Forms.TextBox txtJogador;
    }
}

