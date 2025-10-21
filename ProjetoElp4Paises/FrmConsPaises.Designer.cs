namespace ProjetoElp4Paises
{
    partial class FrmConsPaises
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
            this.colPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSigla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDDI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoeda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.TabIndex = 0;
            // 
            // btnAlterar
            // 
            this.btnAlterar.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.TabIndex = 4;
            // 
            // ListV
            // 
            this.ListV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPais,
            this.colSigla,
            this.colDDI,
            this.colMoeda});
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 3;
            // 
            // colPais
            // 
            this.colPais.Text = "Pais";
            this.colPais.Width = 200;
            // 
            // colSigla
            // 
            this.colSigla.Text = "Sigla";
            this.colSigla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colDDI
            // 
            this.colDDI.Text = "DDI";
            this.colDDI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colMoeda
            // 
            this.colMoeda.Text = "Moeda";
            this.colMoeda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmConsPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmConsPaises";
            this.Text = "Consulta de Paises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ColumnHeader colPais;
        protected System.Windows.Forms.ColumnHeader colSigla;
        protected System.Windows.Forms.ColumnHeader colDDI;
        protected System.Windows.Forms.ColumnHeader colMoeda;
    }
}
