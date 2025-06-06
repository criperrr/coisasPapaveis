﻿using System;
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
            Atualizar();
        }

        private void FrmGerenciar_FormClosing(object sender, FormClosingEventArgs e)
        {
            anterior.AtribuirPalpaveis(papaveis);
            anterior.Show();
        }
        void Atualizar()
        {
            dgvPapavel.Rows.Clear();
            for (int i = 0; i < Funcoes.Lenght(papaveis); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvPapavel);
                row.Cells[0].Value = papaveis[i][0];
                dgvPapavel.Rows.Add(row);
            }
        }
        private void brAdd_Click(object sender, EventArgs e)
        {
            if (Funcoes.Lenght(papaveis) == papaveis.Length)
            {
                MessageBox.Show("Limite de palpaveis atingido");
                return;
            }

            string nome = txtNome.Text.Trim();
            if (String.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Dê-me um nome!");
                return;
            }
            if (Funcoes.Buscar(papaveis, nome) > -1)
            {
                MessageBox.Show("Esse nome já está cadastrado!");
                return;
            }
            papaveis[Funcoes.Lenght(papaveis)] = new string[] { nome, "0" };
            MessageBox.Show("Papavel adicionado com sucesso!");
            txtNome.Text = "";
            Atualizar();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (dgvPapavel.SelectedCells.Count == 0)
            {
                MessageBox.Show("Selecione um papavel para remover.");
                return;
            }

            int rowIndex = dgvPapavel.SelectedCells[0].RowIndex;

            if (rowIndex < 0 || rowIndex >= Funcoes.Lenght(papaveis))
            {
                MessageBox.Show("Seleção inválida.");
                return;
            }
            for (int i = rowIndex; i < Funcoes.Lenght(papaveis) - 1; i++)
            {
                papaveis[i] = papaveis[i + 1];
            }
            papaveis[Funcoes.Lenght(papaveis) - 1] = null;

            Atualizar();
        }
    }
}
