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
        CtrlPaises aCtrlPaises;
        public FrmConsPaises()
        {
            InitializeComponent();
        }
        protected override void Pesquisar()
        {

        }
        protected override void Incluir()
        {
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPaises.ShowDialog();
            this.CarregaLv();
        }
        protected override void Alterar()
        {
            oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
        }
        protected override void Excluir()
        {
            string aux;
            oFrmCadPaises.ConhecaObj(oPais, aCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.BloquearTxt();
            aux = oFrmCadPaises.btnSalvar.Text;
            oFrmCadPaises.btnSalvar.Text = "Excluir";
            oFrmCadPaises.ShowDialog();
            oFrmCadPaises.DesbloquearTxt();
            oFrmCadPaises.btnSalvar.Text = aux;
        }

        protected override void CarregaLv()
        {
            //   foreach (var o in aCtrlPaises.TodosPaises())
           // {
                ListViewItem item = new ListViewItem(Convert.ToString(oPais.Codigo));
                item.SubItems.Add(oPais.Pais);
                item.SubItems.Add(oPais.Sigla);
                item.SubItems.Add(oPais.Ddi);
                item.SubItems.Add(oPais.Moeda);
                ListV.Items.Add(item);
           // } 
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
                aCtrlPaises = (CtrlPaises) ctrl;
        }
    }
}
