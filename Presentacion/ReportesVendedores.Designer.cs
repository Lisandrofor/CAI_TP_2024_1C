namespace Presentacion
{
    partial class ReportesVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesVendedores));
            this.btnReportes = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblReportes = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.White;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(515, 215);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(126, 93);
            this.btnReportes.TabIndex = 22;
            this.btnReportes.Text = "Reporte de Ventas por Vendedor";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(513, 213);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(131, 98);
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.BackColor = System.Drawing.Color.Transparent;
            this.lblReportes.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.ForeColor = System.Drawing.Color.White;
            this.lblReportes.Location = new System.Drawing.Point(490, 67);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(184, 61);
            this.lblReportes.TabIndex = 28;
            this.lblReportes.Text = "Reportes";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(138, 510);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(126, 56);
            this.btnVolver.TabIndex = 51;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Black;
            this.pictureBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox19.Location = new System.Drawing.Point(136, 508);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(131, 61);
            this.pictureBox19.TabIndex = 50;
            this.pictureBox19.TabStop = false;
            // 
            // ReportesVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1164, 640);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.lblReportes);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.pictureBox6);
            this.Name = "ReportesVendedores";
            this.Text = "ReportesVendedores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox19;
    }
}