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
    public partial class FrmGerenciar : Form
    {
        Form1 anterior;
        string[][] papaveis;
        public FrmGerenciar(Form1 ant, string[][] papaveis)
        {
            InitializeComponent();
            this.anterior = ant;
            this.papaveis = papaveis;
        }
        int Lenght(string[][] papaveis)
        {
            int i = 0;
            while (papaveis[i] != null)
            {
                i++;
            }
            return i;
        }


        private void FrmGerenciar_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.AtribuirPalpaveis(papaveis);
            anterior.Show();
        }
        void Atualizar()
        {
            dgvPapavel.Rows.Clear();
            for (int i = 0; i < Lenght(papaveis); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvPapavel);
                for (int j = 0; j < papaveis[i].Length; j++)
                {
                    row.Cells[j].Value = papaveis[i][j];

                }
                dgvPapavel.Rows.Add(row);

            }
        }
        int Buscar(string nome)
        {
            int i = 0;
            for (i = 0; i < Lenght(papaveis) && papaveis[i][1] != nome; i++) ;

            if (i < Lenght(papaveis)) return i;

            return -1;
        }

        private void brAdd_Click(object sender, EventArgs e)
        {

            if(Lenght(papaveis) == papaveis.Length)
            {
                MessageBox.Show("Limite de palpaveis atingido");
                return;
            }

            string nome = txtNome.Text.Trim();
            if(String.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Dê-me um nome!");
                return;
            }
            if(Buscar(nome) > -1)
            {
                MessageBox.Show("Esse nome já está cadastrado!");
                return;
            }
            int id = 1;
            if(Lenght(papaveis) > 0)
            {
                id = int.Parse(papaveis[Lenght(papaveis) - 1][0]) + 1;
            }
            papaveis[Lenght(papaveis)] = new string[] {id.ToString(), nome};
            MessageBox.Show("Papavel adicionado com sucesso!");
            txtNome.Text = "";
            Atualizar();
        }
    }
}
