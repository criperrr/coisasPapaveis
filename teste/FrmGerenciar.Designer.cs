namespace teste
{
    partial class FrmGerenciar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPapavel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.brAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapavel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPapavel
            // 
            this.dgvPapavel.AllowUserToAddRows = false;
            this.dgvPapavel.AllowUserToDeleteRows = false;
            this.dgvPapavel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPapavel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome});
            this.dgvPapavel.Location = new System.Drawing.Point(12, 12);
            this.dgvPapavel.Name = "dgvPapavel";
            this.dgvPapavel.ReadOnly = true;
            this.dgvPapavel.Size = new System.Drawing.Size(373, 426);
            this.dgvPapavel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(562, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // brAdd
            // 
            this.brAdd.Location = new System.Drawing.Point(528, 136);
            this.brAdd.Name = "brAdd";
            this.brAdd.Size = new System.Drawing.Size(96, 26);
            this.brAdd.TabIndex = 3;
            this.brAdd.Text = "Adicionar";
            this.brAdd.UseVisualStyleBackColor = true;
            this.brAdd.Click += new System.EventHandler(this.brAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(528, 412);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(96, 26);
            this.btRemove.TabIndex = 4;
            this.btRemove.Text = "Excluir";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // FrmGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.brAdd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPapavel);
            this.Name = "FrmGerenciar";
            this.Text = "FrmGerenciar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGerenciar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapavel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPapavel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button brAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}