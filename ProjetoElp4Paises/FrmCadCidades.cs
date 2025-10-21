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
        CtrlEstados aCtrlEstados;
        public FrmCadCidades()
        {
            InitializeComponent();
            oFrmConsEstados = new FrmConsEstados();
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
            MessageBox.Show(aCtrlCidades.Salvar(aCidade.Clone()));
        }
        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(aCidade.Codigo);
            this.txtCidade.Text = aCidade.Cidade;
            this.txtDdd.Text = aCidade.Ddd;


        }

        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtCidade.Clear();
            this.txtDdd.Clear();

        }
        public override void BloquearTxt()
        {
            this.txtCidade.Enabled = false;
            this.txtDdd.Enabled = false;
        }
        public override void DesbloquearTxt()
        {
            this.txtCidade.Enabled = true;
            this.txtDdd.Enabled = true;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string btnSair = oFrmConsEstados.btnSair.Text;
            oFrmConsEstados.btnSair.Text = "Selecionar";
            oFrmConsEstados.ConhecaObj(aCidade.OEstado, aCtrlEstados);
            oFrmConsEstados.ShowDialog();
            this.txtCodigoEstado.Text = Convert.ToString(aCidade.OEstado.Codigo);
            this.txtEstado.Text = aCidade.OEstado.Estado.ToString();
            oFrmConsEstados.btnSair.Text = btnSair;
        }
    }
}


