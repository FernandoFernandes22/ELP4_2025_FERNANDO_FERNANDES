namespace ProjetoElp4Paises
{
    partial class FrmConsEstados
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
            this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodigoPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListV
            // 
            this.ListV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEstado,
            this.colUf,
            this.colCodigoPais,
            this.colPais});
            // 
            // colEstado
            // 
            this.colEstado.Text = "Estado";
            this.colEstado.Width = 200;
            // 
            // colUf
            // 
            this.colUf.Text = "Uf";
            this.colUf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colCodigoPais
            // 
            this.colCodigoPais.Text = "código";
            this.colCodigoPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colPais
            // 
            this.colPais.Text = "Pais";
            this.colPais.Width = 200;
            // 
            // FrmConsEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmConsEstados";
            this.Text = "Consulta Estados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ColumnHeader colEstado;
        protected System.Windows.Forms.ColumnHeader colUf;
        protected System.Windows.Forms.ColumnHeader colCodigoPais;
        protected System.Windows.Forms.ColumnHeader colPais;
    }
}
