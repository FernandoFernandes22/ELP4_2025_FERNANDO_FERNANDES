using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoElp4Paises
{
    public partial class FrmConsPaises : ProjetoElp4Paises.FrmConsultas
    {
        FrmCadPaises oFrmCadPaises;
        Paises oPais;
        Controller aCtrl;
        public FrmConsPaises()
        {
            InitializeComponent();
            oFrmCadPaises = new FrmCadPaises();
        }
        protected override void Pesquisar()
        {

        }
        protected override void Incluir()
        {
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.ShowDialog();
        }
        protected override void Alterar()
        {
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
        }
        protected override void Excluir()
        {
            string aux;
            oFrmCadPaises.ConhecaObj(oPais, aCtrl);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.BloquearTxt();
            aux = oFrmCadPaises.btnSalvar.Text;
            oFrmCadPaises.btnSalvar.Text = "Excluir";
            oFrmCadPaises.ShowDialog();
            oFrmCadPaises.DesbloquearTxt();
            oFrmCadPaises.btnSalvar.Text = aux;
        }
        public override void setFrmCadastro(object obj)
        {
            if (obj != null) 
                oFrmCadPaises = (FrmCadPaises) obj;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if(obj != null)
                oPais = (Paises) obj;
            if(ctrl != null)
                aCtrl = (Controller) ctrl;
        }
    }
}
