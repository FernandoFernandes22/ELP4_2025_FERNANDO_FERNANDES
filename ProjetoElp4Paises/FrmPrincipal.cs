using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoElp4Paises
{
    public partial class FrmPrincipal : Form
    {
        Interfaces aInter = new Interfaces();
        Paises oPais = new Paises();
        Controller aCtrl = new Controller();
        Estados oEstado = new Estados();
        Cidades aCidade = new Cidades();
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            aInter.PecaPaises(oPais, aCtrl);
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            aInter.PecaEstados(oEstado,aCtrl);
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaCidades(aCidade, aCtrl);
        }
    }
}
