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
            var result = MessageBox.Show("Resultados:\n\n" + " " + "\n\n Deseja encerrar?", "Resultados", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                int sum = 0;
                int count = Funcoes.Lenght(papaveis);
                int[] votos = new int[count];
                for (int i = 0; i < count; i++)
                {
                    if (papaveis[i] != null && papaveis[i].Length > 1 && int.TryParse(papaveis[i][1], out int voto))
                    {
                        votos[i] = voto;
                        sum += voto;
                    }
                    else
                    {
                        votos[i] = 0;
                    }
                }

                int doisTerco = (int)Math.Ceiling(sum * 2.0 / 3.0);
                int vencedorIndex = -1;
                for (int i = 0; i < count; i++)
                {
                    if (votos[i] >= doisTerco && papaveis[i] != null && !string.IsNullOrEmpty(papaveis[i][0]))
                    {
                        vencedorIndex = i;
                        break;
                    }
                }

                if (vencedorIndex == -1)
                {
                    MessageBox.Show("Não houve vitorioso. Todos os votos foram zerados.", "Sem vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = 0; i < count; i++)
                    {
                        if (papaveis[i] != null && papaveis[i].Length > 1)
                            papaveis[i][1] = "0";
                    }
                }
                else
                {
                    string nomeVencedor = papaveis[vencedorIndex][0];
                    var aceitou = MessageBox.Show($"O eleito foi: {nomeVencedor}\n\nVocê aceita a eleição canônica à Sumo Pontífice?", "Eleição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (aceitou == DialogResult.Yes)
                    {
                        MessageBox.Show("HABEMUS PAPAM", "Conclave", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        for (int i = 0; i < papaveis.Length; i++)
                        {
                            papaveis[i] = null;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            if (papaveis[i] != null && papaveis[i].Length > 1)
                                papaveis[i][1] = "0";
                        }
                    }
                }
            }
        }

        private void btVotar_Click(object sender, EventArgs e)
        {
            FrmVotar f = new FrmVotar(this, papaveis);
            f.ShowDialog();
        }
    }
}
