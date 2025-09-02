namespace ProjetoElp4Paises
{
    partial class FrmCadastros
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodUsu = new System.Windows.Forms.TextBox();
            this.txtUltAlt = new System.Windows.Forms.TextBox();
            this.txtDatCad = new System.Windows.Forms.TextBox();
            this.lblDatCad = new System.Windows.Forms.Label();
            this.lblUltAlt = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(15, 28);
            this.txtCodigo.TabIndex = 9;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(609, 416);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtCodUsu
            // 
            this.txtCodUsu.Location = new System.Drawing.Point(424, 415);
            this.txtCodUsu.Name = "txtCodUsu";
            this.txtCodUsu.Size = new System.Drawing.Size(100, 22);
            this.txtCodUsu.TabIndex = 8;
            // 
            // txtUltAlt
            // 
            this.txtUltAlt.Location = new System.Drawing.Point(296, 416);
            this.txtUltAlt.Name = "txtUltAlt";
            this.txtUltAlt.Size = new System.Drawing.Size(100, 22);
            this.txtUltAlt.TabIndex = 7;
            // 
            // txtDatCad
            // 
            this.txtDatCad.Location = new System.Drawing.Point(172, 417);
            this.txtDatCad.Name = "txtDatCad";
            this.txtDatCad.Size = new System.Drawing.Size(100, 22);
            this.txtDatCad.TabIndex = 6;
            // 
            // lblDatCad
            // 
            this.lblDatCad.AutoSize = true;
            this.lblDatCad.Location = new System.Drawing.Point(172, 395);
            this.lblDatCad.Name = "lblDatCad";
            this.lblDatCad.Size = new System.Drawing.Size(56, 16);
            this.lblDatCad.TabIndex = 7;
            this.lblDatCad.Text = "Dat Cad";
            // 
            // lblUltAlt
            // 
            this.lblUltAlt.AutoSize = true;
            this.lblUltAlt.Location = new System.Drawing.Point(296, 394);
            this.lblUltAlt.Name = "lblUltAlt";
            this.lblUltAlt.Size = new System.Drawing.Size(65, 16);
            this.lblUltAlt.TabIndex = 8;
            this.lblUltAlt.Text = "Dat Ult Alt";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(424, 393);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario";
            // 
            // FrmCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblUltAlt);
            this.Controls.Add(this.lblDatCad);
            this.Controls.Add(this.txtDatCad);
            this.Controls.Add(this.txtUltAlt);
            this.Controls.Add(this.txtCodUsu);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FrmCadastros";
            this.Text = "Cadastros";
            this.Load += new System.EventHandler(this.FrmCadastros_Load);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodUsu, 0);
            this.Controls.SetChildIndex(this.txtUltAlt, 0);
            this.Controls.SetChildIndex(this.txtDatCad, 0);
            this.Controls.SetChildIndex(this.lblDatCad, 0);
            this.Controls.SetChildIndex(this.lblUltAlt, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodUsu;
        private System.Windows.Forms.TextBox txtUltAlt;
        private System.Windows.Forms.TextBox txtDatCad;
        private System.Windows.Forms.Label lblDatCad;
        private System.Windows.Forms.Label lblUltAlt;
        private System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Button btnSalvar;
    }
}
