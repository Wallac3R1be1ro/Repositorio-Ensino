namespace Metodista.Login
{
    partial class Frm_Login
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
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tSenha = new System.Windows.Forms.TextBox();
            this.lblEsqueciSenha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSair = new System.Windows.Forms.Label();
            this.lblEntrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tela de Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "RA do Usuário";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tUsuario
            // 
            this.tUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUsuario.ForeColor = System.Drawing.Color.Navy;
            this.tUsuario.Location = new System.Drawing.Point(12, 215);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(366, 23);
            this.tUsuario.TabIndex = 2;
            this.tUsuario.Text = "WALLACE";
            this.tUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tSenha
            // 
            this.tSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSenha.ForeColor = System.Drawing.Color.Navy;
            this.tSenha.Location = new System.Drawing.Point(12, 297);
            this.tSenha.Name = "tSenha";
            this.tSenha.PasswordChar = '*';
            this.tSenha.Size = new System.Drawing.Size(366, 23);
            this.tSenha.TabIndex = 8;
            this.tSenha.Text = "123";
            this.tSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEsqueciSenha
            // 
            this.lblEsqueciSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEsqueciSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEsqueciSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueciSenha.Location = new System.Drawing.Point(12, 375);
            this.lblEsqueciSenha.Name = "lblEsqueciSenha";
            this.lblEsqueciSenha.Size = new System.Drawing.Size(366, 28);
            this.lblEsqueciSenha.TabIndex = 12;
            this.lblEsqueciSenha.Text = "Esqueci minha senha";
            this.lblEsqueciSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEsqueciSenha.Click += new System.EventHandler(this.lblEsqueciSenha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Metodista.Properties.Resources.metodista;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblSair
            // 
            this.lblSair.BackColor = System.Drawing.Color.Transparent;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.Image = global::Metodista.Properties.Resources.sair;
            this.lblSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSair.Location = new System.Drawing.Point(214, 323);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(72, 40);
            this.lblSair.TabIndex = 11;
            this.lblSair.Text = "Sair";
            this.lblSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // lblEntrar
            // 
            this.lblEntrar.BackColor = System.Drawing.Color.Transparent;
            this.lblEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrar.Image = global::Metodista.Properties.Resources.entrar;
            this.lblEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEntrar.Location = new System.Drawing.Point(106, 323);
            this.lblEntrar.Name = "lblEntrar";
            this.lblEntrar.Size = new System.Drawing.Size(80, 40);
            this.lblEntrar.TabIndex = 10;
            this.lblEntrar.Text = "Entrar";
            this.lblEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEntrar.Click += new System.EventHandler(this.lblEntrar_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEsqueciSenha);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.lblEntrar);
            this.Controls.Add(this.tSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tSenha;
        private System.Windows.Forms.Label lblEntrar;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblEsqueciSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}