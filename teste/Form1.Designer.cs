namespace teste
{
    partial class Form1
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
            this.btGerenciar = new System.Windows.Forms.Button();
            this.btVotar = new System.Windows.Forms.Button();
            this.btResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGerenciar
            // 
            this.btGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerenciar.Location = new System.Drawing.Point(16, 15);
            this.btGerenciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGerenciar.Name = "btGerenciar";
            this.btGerenciar.Size = new System.Drawing.Size(1035, 113);
            this.btGerenciar.TabIndex = 0;
            this.btGerenciar.Text = "&Gerenciar Papaveis";
            this.btGerenciar.UseVisualStyleBackColor = true;
            this.btGerenciar.Click += new System.EventHandler(this.btGerenciar_Click);
            // 
            // btVotar
            // 
            this.btVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVotar.Location = new System.Drawing.Point(16, 215);
            this.btVotar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btVotar.Name = "btVotar";
            this.btVotar.Size = new System.Drawing.Size(1035, 113);
            this.btVotar.TabIndex = 1;
            this.btVotar.Text = "&Votar";
            this.btVotar.UseVisualStyleBackColor = true;
            this.btVotar.Click += new System.EventHandler(this.btVotar_Click);
            // 
            // btResult
            // 
            this.btResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResult.Location = new System.Drawing.Point(16, 426);
            this.btResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(1035, 113);
            this.btResult.TabIndex = 2;
            this.btResult.Text = "&Resultados";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.btVotar);
            this.Controls.Add(this.btGerenciar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGerenciar;
        private System.Windows.Forms.Button btVotar;
        private System.Windows.Forms.Button btResult;
    }
}

