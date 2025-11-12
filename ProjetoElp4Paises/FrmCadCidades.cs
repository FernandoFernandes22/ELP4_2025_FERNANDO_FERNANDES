using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoElp4Paises
{
    public partial class FrmCadCidades : ProjetoElp4Paises.FrmCadastros
    {
        FrmConsEstados oFrmConsEstados;
        Cidades aCidade;
        CtrlCidades aCtrlCidades;
       
        public FrmCadCidades()
        {
            InitializeComponent();
            
        }

        public  void setFrmConsEstados(object obj)
        {
            if(obj != null)
            {
                oFrmConsEstados = (FrmConsEstados) obj;  
            }
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                aCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrlCidades = (CtrlCidades)ctrl;
        }
        public override void Salvar()
        {
            // if ( MessageDlg("Confirma (S/N)") == "S" )
            aCidade.Codigo = Convert.ToInt32(txtCodigo.Text);
            aCidade.Cidade = txtCidade.Text;
            aCidade.Ddd = txtDdd.Text;
            aCidade.OEstado.Codigo = Convert.ToInt32(txtCodigoEstado.Text);
            aCidade.OEstado.Estado = txtEstado.Text;
            
            if (btnSalvar.Text == "&Salvar")
            {
                MessageBox.Show(aCtrlCidades.Salvar(aCidade.Clone()));
                

            }
            if (btnSalvar.Text == "Excluir")
            {
                MessageBox.Show(aCtrlCidades.Excluir(aCidade));

            }
           
        }
        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(aCidade.Codigo);
            this.txtCidade.Text = aCidade.Cidade;
            this.txtDdd.Text = aCidade.Ddd;
            this.txtCodigoEstado.Text = Convert.ToString(aCidade.OEstado.Codigo);
            this.txtEstado.Text = aCidade.OEstado.Estado;


        }

        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtCidade.Clear();
            this.txtDdd.Clear();
            this.txtCodigoEstado.Text = "0";
            this.txtEstado.Clear();

        }
        public override void BloquearTxt()
        {
            this.txtCodigo.Enabled = false;
            this.txtCidade.Enabled = false;
            this.txtDdd.Enabled = false;
            this.txtCodigoEstado.Enabled = false;
            this.txtEstado.Enabled = false;
        }
        public override void DesbloquearTxt()
        {
            this.txtCodigo.Enabled = true;
            this.txtCidade.Enabled = true;
            this.txtDdd.Enabled = true;
            this.txtCodigoEstado.Enabled = true;
            this.txtEstado.Enabled = true;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string btnSair = oFrmConsEstados.btnSair.Text;
            oFrmConsEstados.btnSair.Text = "Selecionar";
            oFrmConsEstados.ConhecaObj(aCidade.OEstado, aCtrlCidades.ACtrlEstados);
            oFrmConsEstados.ShowDialog();
            this.txtCodigoEstado.Text = Convert.ToString(aCidade.OEstado.Codigo);
            this.txtEstado.Text = aCidade.OEstado.Estado.ToString();
            oFrmConsEstados.btnSair.Text = btnSair;
        }
    }
}


