using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoElp4Paises
{
    public partial class FrmConsCidades : ProjetoElp4Paises.FrmConsultas
    {

        FrmCadCidades oFrmCadCidades;
        Cidades aCidade;
        CtrlCidades aCtrlCidades;
        public FrmConsCidades()
        {
            InitializeComponent();
        }

        protected override void Pesquisar()
        {

        }
        protected override void Incluir()
        {
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.ConhecaObj(aCidade, aCtrlCidades);
            oFrmCadCidades.ShowDialog();
            CarregaLv();
        }
        protected override void Alterar()
        {
            
            oFrmCadCidades.ConhecaObj(aCidade, aCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
        }
        protected override void Excluir()
        {
            string aux;
            oFrmCadCidades.ConhecaObj(aCidade, aCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.BloquearTxt();
            aux = oFrmCadCidades.btnSalvar.Text;
            oFrmCadCidades.btnSalvar.Text = "Excluir";
            oFrmCadCidades.ShowDialog();
            oFrmCadCidades.DesbloquearTxt();
            oFrmCadCidades.btnSalvar.Text = aux;
        }

        protected override void CarregaLv()
        {
            ListViewItem item = new ListViewItem(Convert.ToString(aCidade.Codigo));
            item.SubItems.Add(aCidade.Cidade);
            item.SubItems.Add(aCidade.Ddd);
            item.SubItems.Add(Convert.ToString(aCidade.OEstado.Codigo));
            item.SubItems.Add(aCidade.OEstado.Estado);
            ListV.Items.Add(item);
        }
        public override void setFrmCadastro(object obj)
        {
            if (obj != null)
                oFrmCadCidades = (FrmCadCidades)obj;
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                aCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrlCidades = (CtrlCidades)ctrl;
        }
    }
}

