namespace Metodista.EsqueciSenha
{
    partial class Frm_EsqueciSenha
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
            this.tNovaSenha = new System.Windows.Forms.Label();
            this.tSenha = new System.Windows.Forms.TextBox();
            this.btnNovaSenha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tNovaSenha
            // 
            this.tNovaSenha.AutoSize = true;
            this.tNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNovaSenha.Location = new System.Drawing.Point(12, 183);
            this.tNovaSenha.Name = "tNovaSenha";
            this.tNovaSenha.Size = new System.Drawing.Size(130, 17);
            this.tNovaSenha.TabIndex = 17;
            this.tNovaSenha.Text = "Digite Nova Senha:";
            // 
            // tSenha
            // 
            this.tSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSenha.ForeColor = System.Drawing.Color.Navy;
            this.tSenha.Location = new System.Drawing.Point(149, 183);
            this.tSenha.Name = "tSenha";
            this.tSenha.PasswordChar = '*';
            this.tSenha.Size = new System.Drawing.Size(175, 23);
            this.tSenha.TabIndex = 19;
            // 
            // btnNovaSenha
            // 
            this.btnNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaSenha.Image = global::Metodista.Properties.Resources.password;
            this.btnNovaSenha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovaSenha.Location = new System.Drawing.Point(146, 240);
            this.btnNovaSenha.Name = "btnNovaSenha";
            this.btnNovaSenha.Size = new System.Drawing.Size(96, 52);
            this.btnNovaSenha.TabIndex = 20;
            this.btnNovaSenha.Text = "Criar Usuário";
            this.btnNovaSenha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovaSenha.Click += new System.EventHandler(this.btnNovaSenha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Metodista.Properties.Resources.metodista;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::Metodista.Properties.Resources.voltar;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(248, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 52);
            this.label4.TabIndex = 21;
            this.label4.Text = "Voltar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 73);
            this.label5.TabIndex = 22;
            this.label5.Text = "Esqueci a minha Senha";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tUsuario
            // 
            this.tUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUsuario.ForeColor = System.Drawing.Color.Navy;
            this.tUsuario.Location = new System.Drawing.Point(129, 138);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(195, 23);
            this.tUsuario.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Digite o usuário:";
            // 
            // Frm_EsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 328);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNovaSenha);
            this.Controls.Add(this.tSenha);
            this.Controls.Add(this.tNovaSenha);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_EsqueciSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_EsqueciSenha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tNovaSenha;
        private System.Windows.Forms.TextBox tSenha;
        private System.Windows.Forms.Label btnNovaSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.Label label6;
    }
}