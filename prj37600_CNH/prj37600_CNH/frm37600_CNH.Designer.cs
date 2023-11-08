namespace prj37600_CNH
{
    partial class frm37600_CNH
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCNH = new System.Windows.Forms.Label();
            this.mtbCNH = new System.Windows.Forms.MaskedTextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCNH
            // 
            this.lblCNH.AutoSize = true;
            this.lblCNH.Location = new System.Drawing.Point(22, 9);
            this.lblCNH.Name = "lblCNH";
            this.lblCNH.Size = new System.Drawing.Size(30, 13);
            this.lblCNH.TabIndex = 0;
            this.lblCNH.Text = "CNH";
            // 
            // mtbCNH
            // 
            this.mtbCNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCNH.Location = new System.Drawing.Point(25, 27);
            this.mtbCNH.Mask = "00000000000";
            this.mtbCNH.Name = "mtbCNH";
            this.mtbCNH.Size = new System.Drawing.Size(114, 26);
            this.mtbCNH.TabIndex = 1;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(21, 56);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(72, 20);
            this.lblSituacao.TabIndex = 2;
            this.lblSituacao.Text = "Situação";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(145, 27);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 26);
            this.btnValidar.TabIndex = 3;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // frm37600_CNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 83);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.mtbCNH);
            this.Controls.Add(this.lblCNH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm37600_CNH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm37600_CNH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm37600_CNH_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCNH;
        private System.Windows.Forms.MaskedTextBox mtbCNH;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnValidar;
    }
}

