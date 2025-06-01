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
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.brAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
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
            this.dgvPapavel.Location = new System.Drawing.Point(16, 15);
            this.dgvPapavel.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPapavel.Name = "dgvPapavel";
            this.dgvPapavel.ReadOnly = true;
            this.dgvPapavel.RowHeadersWidth = 51;
            this.dgvPapavel.Size = new System.Drawing.Size(497, 524);
            this.dgvPapavel.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(668, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(749, 102);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(132, 22);
            this.txtNome.TabIndex = 2;
            // 
            // brAdd
            // 
            this.brAdd.Location = new System.Drawing.Point(704, 167);
            this.brAdd.Margin = new System.Windows.Forms.Padding(4);
            this.brAdd.Name = "brAdd";
            this.brAdd.Size = new System.Drawing.Size(128, 32);
            this.brAdd.TabIndex = 3;
            this.brAdd.Text = "&Adicionar";
            this.brAdd.UseVisualStyleBackColor = true;
            this.brAdd.Click += new System.EventHandler(this.brAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(704, 507);
            this.btRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(128, 32);
            this.btRemove.TabIndex = 4;
            this.btRemove.Text = "&Excluir";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // FrmGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.brAdd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPapavel);
            this.Margin = new System.Windows.Forms.Padding(4);
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