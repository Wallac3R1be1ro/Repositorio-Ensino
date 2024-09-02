namespace Metodista.Principal
{
    partial class Frm_Principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MPrincipal = new System.Windows.Forms.MenuStrip();
            this.MCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.SMConsultarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.SMAlterarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.SMExcluirProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.SMIncluirProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.SMRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSair = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(13, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 321);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(107, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(787, 73);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sistema Acadêmico Metodista";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MPrincipal
            // 
            this.MPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MPrincipal.AutoSize = false;
            this.MPrincipal.BackColor = System.Drawing.Color.Navy;
            this.MPrincipal.Dock = System.Windows.Forms.DockStyle.None;
            this.MPrincipal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.MPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MCadastro,
            this.MRelatorios});
            this.MPrincipal.Location = new System.Drawing.Point(13, 97);
            this.MPrincipal.Name = "MPrincipal";
            this.MPrincipal.Size = new System.Drawing.Size(931, 42);
            this.MPrincipal.TabIndex = 18;
            this.MPrincipal.Text = "menuStrip1";
            // 
            // MCadastro
            // 
            this.MCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMConsultarProduto,
            this.toolStripSeparator1,
            this.SMAlterarProduto,
            this.toolStripSeparator2,
            this.SMExcluirProduto,
            this.toolStripSeparator3,
            this.SMIncluirProduto});
            this.MCadastro.ForeColor = System.Drawing.Color.White;
            this.MCadastro.Name = "MCadastro";
            this.MCadastro.Size = new System.Drawing.Size(80, 38);
            this.MCadastro.Text = "Cadastro";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(194, 6);
            // 
            // MRelatorios
            // 
            this.MRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMRelatorios});
            this.MRelatorios.ForeColor = System.Drawing.Color.White;
            this.MRelatorios.Name = "MRelatorios";
            this.MRelatorios.Size = new System.Drawing.Size(88, 38);
            this.MRelatorios.Text = "Relatórios";
            // 
            // SMConsultarProduto
            // 
            this.SMConsultarProduto.ForeColor = System.Drawing.Color.Navy;
            this.SMConsultarProduto.Image = global::Metodista.Properties.Resources.select;
            this.SMConsultarProduto.Name = "SMConsultarProduto";
            this.SMConsultarProduto.Size = new System.Drawing.Size(197, 24);
            this.SMConsultarProduto.Text = "Consultar Produto";
            this.SMConsultarProduto.Click += new System.EventHandler(this.SMConsultarProduto_Click);
            // 
            // SMAlterarProduto
            // 
            this.SMAlterarProduto.ForeColor = System.Drawing.Color.Navy;
            this.SMAlterarProduto.Image = global::Metodista.Properties.Resources.update;
            this.SMAlterarProduto.Name = "SMAlterarProduto";
            this.SMAlterarProduto.Size = new System.Drawing.Size(197, 24);
            this.SMAlterarProduto.Text = "Alterar Produto";
            // 
            // SMExcluirProduto
            // 
            this.SMExcluirProduto.ForeColor = System.Drawing.Color.Navy;
            this.SMExcluirProduto.Image = global::Metodista.Properties.Resources.delete;
            this.SMExcluirProduto.Name = "SMExcluirProduto";
            this.SMExcluirProduto.Size = new System.Drawing.Size(197, 24);
            this.SMExcluirProduto.Text = "Excluir Produto";
            // 
            // SMIncluirProduto
            // 
            this.SMIncluirProduto.ForeColor = System.Drawing.Color.Navy;
            this.SMIncluirProduto.Image = global::Metodista.Properties.Resources.insert;
            this.SMIncluirProduto.Name = "SMIncluirProduto";
            this.SMIncluirProduto.Size = new System.Drawing.Size(197, 24);
            this.SMIncluirProduto.Text = "Incluir Produto";
            // 
            // SMRelatorios
            // 
            this.SMRelatorios.ForeColor = System.Drawing.Color.Navy;
            this.SMRelatorios.Image = global::Metodista.Properties.Resources.Excel;
            this.SMRelatorios.Name = "SMRelatorios";
            this.SMRelatorios.Size = new System.Drawing.Size(112, 24);
            this.SMRelatorios.Text = "Excel";
            // 
            // lblSair
            // 
            this.lblSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSair.BackColor = System.Drawing.Color.Transparent;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.Image = global::Metodista.Properties.Resources.sair;
            this.lblSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSair.Location = new System.Drawing.Point(900, 12);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(44, 73);
            this.lblSair.TabIndex = 17;
            this.lblSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Metodista.Properties.Resources.metodista;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(956, 475);
            this.Controls.Add(this.MPrincipal);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.MPrincipal;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MPrincipal.ResumeLayout(false);
            this.MPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.MenuStrip MPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MCadastro;
        private System.Windows.Forms.ToolStripMenuItem SMConsultarProduto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SMAlterarProduto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SMExcluirProduto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem SMIncluirProduto;
        private System.Windows.Forms.ToolStripMenuItem MRelatorios;
        private System.Windows.Forms.ToolStripMenuItem SMRelatorios;
    }
}