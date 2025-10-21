using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoElp4Paises
{
    public partial class FrmConsEstados : ProjetoElp4Paises.FrmConsultas
    {
        FrmCadEstados oFrmCadEstados;
        Estados oEstado;
        CtrlEstados aCtrlEstados;
        public FrmConsEstados()
        {
            InitializeComponent();
        }

        protected override void Pesquisar()
        {

        }
        protected override void Incluir()
        {
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);
            oFrmCadEstados.ShowDialog();
            this.CarregaLv();
        }
        protected override void Alterar()
        {
            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
        }
        protected override void Excluir()
        {
            string aux;
            oFrmCadEstados.ConhecaObj(oEstado, aCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.BloquearTxt();
            aux = oFrmCadEstados.btnSalvar.Text;
            oFrmCadEstados.btnSalvar.Text = "Excluir";
            oFrmCadEstados.ShowDialog();
            oFrmCadEstados.DesbloquearTxt();
            oFrmCadEstados.btnSalvar.Text = aux;
        }
        protected override void CarregaLv()
        {
            ListViewItem item = new ListViewItem(Convert.ToString(oEstado.Codigo));
            item.SubItems.Add(oEstado.Estado);
            item.SubItems.Add(oEstado.Uf);
            item.SubItems.Add(Convert.ToString(oEstado.OPais.Codigo));
            item.SubItems.Add(oEstado.OPais.Pais);
            ListV.Items.Add(item);
        }
        public override void setFrmCadastro(object obj)
        {
            if (obj != null)
                oFrmCadEstados = (FrmCadEstados)obj;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oEstado = (Estados)obj;
            if (ctrl != null)
                aCtrlEstados = (CtrlEstados)ctrl;
        }
    }
}

