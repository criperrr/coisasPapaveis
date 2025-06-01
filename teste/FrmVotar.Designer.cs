namespace teste
{
    partial class FrmVotar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbxCardeais = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbxCardeais
            // 
            this.lbxCardeais.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCardeais.FormattingEnabled = true;
            this.lbxCardeais.ItemHeight = 36;
            this.lbxCardeais.Location = new System.Drawing.Point(16, 80);
            this.lbxCardeais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxCardeais.Name = "lbxCardeais";
            this.lbxCardeais.Size = new System.Drawing.Size(548, 364);
            this.lbxCardeais.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 498);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Votar!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmVotar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbxCardeais);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmVotar";
            this.Text = "FrmVotar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxCardeais;
        private System.Windows.Forms.Button button1;
    }
}