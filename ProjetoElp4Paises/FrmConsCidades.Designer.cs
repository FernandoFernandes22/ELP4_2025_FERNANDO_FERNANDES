namespace ProjetoElp4Paises
{
    partial class FrmConsCidades
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
            this.colCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodigoEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.colCidade,
            this.colDdi,
            this.colCodigoEstado,
            this.colEstado});
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 3;
            // 
            // colCidade
            // 
            this.colCidade.Text = "Cidade";
            this.colCidade.Width = 200;
            // 
            // colDdi
            // 
            this.colDdi.Text = "DDI";
            this.colDdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colCodigoEstado
            // 
            this.colCodigoEstado.Text = "código";
            this.colCodigoEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            this.colEstado.Width = 200;
            // 
            // FrmConsCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmConsCidades";
            this.Text = "Consulta de Cidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ColumnHeader colCidade;
        protected System.Windows.Forms.ColumnHeader colDdi;
        protected System.Windows.Forms.ColumnHeader colCodigoEstado;
        protected System.Windows.Forms.ColumnHeader colEstado;
    }
}
