using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoElp4Paises
{
    public partial class FrmConsultas : ProjetoElp4Paises.Frm
    {
        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {

        }
        protected virtual void Pesquisar() 
        {   
        
        }
        protected virtual void Incluir()
        {
        
        }
        protected virtual void Alterar() 
        {
        }
        protected virtual void Excluir() 
        {
        }

        protected virtual void CarregaLv()
        {

        }
        public virtual void setFrmCadastro(object obj) 
        { 
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}
