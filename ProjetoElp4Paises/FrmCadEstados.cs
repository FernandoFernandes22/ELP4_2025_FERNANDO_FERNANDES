using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoElp4Paises
{
    public partial class FrmCadEstados : ProjetoElp4Paises.FrmCadastros
    {
        FrmConsPaises oFrmConsPaises;
        Estados oEstado;
        CtrlEstados aCtrlEstados;
        CtrlPaises aCtrlPaises;
        public FrmCadEstados()
        {
            InitializeComponent();
        }


        public void setFrmConsPaises(object obj)
        {
            if (obj != null)
            {
                oFrmConsPaises = (FrmConsPaises)obj; 
            }
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oEstado = (Estados)obj;
            if (ctrl != null)
            {
                aCtrlEstados = (CtrlEstados)ctrl;
            }
        }

        public override void Salvar()
        {
            // if ( MessageDlg("Confirma (S/N)") == "S" )
            oEstado.Codigo = Convert.ToInt32(txtCodigo.Text);
            oEstado.Estado = txtEstado.Text;
            oEstado.Uf = txtUf.Text;
            MessageBox.Show(aCtrlEstados.Salvar(oEstado.Clone()));


        }
        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oEstado.Codigo);
            this.txtEstado.Text = oEstado.Estado;
            this.txtUf.Text = oEstado.Uf;
            

        }

        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtEstado.Clear();
            this.txtUf.Clear();
            
        }
        public override void BloquearTxt()
        {
            this.txtEstado.Enabled = false;
            this.txtUf.Enabled = false;
        }
        public override void DesbloquearTxt()
        {
            this.txtEstado.Enabled = true;
            this.txtUf.Enabled = true;
           
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string btnSair = oFrmConsPaises.btnSair.Text;
            oFrmConsPaises.btnSair.Text = "Selecionar";
            oFrmConsPaises.ConhecaObj(oEstado.OPais, aCtrlPaises);
            oFrmConsPaises.ShowDialog();
            this.txtCodigoPais.Text = Convert.ToString(oEstado.OPais.Codigo);
            this.txtPais.Text = oEstado.OPais.Pais.ToString();
            oFrmConsPaises.btnSair.Text = btnSair;
        }
    }
}

