using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Form1 : Form
    {
        string[][] papaveis;
        public Form1()
        {
            InitializeComponent();
            papaveis = new string[300][];
        }

        private void btGerenciar_Click(object sender, EventArgs e)
        {
            FrmGerenciar f = new FrmGerenciar(this, papaveis);
            f.ShowDialog();
        }
        public void AtribuirPalpaveis(string[][] papaveis)
        {
            this.papaveis = papaveis;
        }

        private void btResult_Click(object sender, EventArgs e)
        {

        }

        private void btVotar_Click(object sender, EventArgs e)
        {
            FrmVotar f = new FrmVotar(this, papaveis);
            f.ShowDialog();
        }
    }
}
