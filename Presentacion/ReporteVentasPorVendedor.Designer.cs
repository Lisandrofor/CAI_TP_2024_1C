namespace Presentacion
{
    partial class ReporteVentasPorVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentasPorVendedor));
            this.lblReporteventasporvendedor = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReporteventasporvendedor
            // 
            this.lblReporteventasporvendedor.AutoSize = true;
            this.lblReporteventasporvendedor.BackColor = System.Drawing.Color.Transparent;
            this.lblReporteventasporvendedor.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporteventasporvendedor.ForeColor = System.Drawing.Color.White;
            this.lblReporteventasporvendedor.Location = new System.Drawing.Point(399, 60);
            this.lblReporteventasporvendedor.Name = "lblReporteventasporvendedor";
            this.lblReporteventasporvendedor.Size = new System.Drawing.Size(390, 61);
            this.lblReporteventasporvendedor.TabIndex = 4;
            this.lblReporteventasporvendedor.Text = "Ventas Por Vendedor";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(103, 539);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(126, 56);
            this.btnVolver.TabIndex = 53;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Black;
            this.pictureBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox19.Location = new System.Drawing.Point(101, 537);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(131, 61);
            this.pictureBox19.TabIndex = 52;
            this.pictureBox19.TabStop = false;
            // 
            // ReporteVentasPorVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 620);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.lblReporteventasporvendedor);
            this.Name = "ReporteVentasPorVendedor";
            this.Text = "ReporteVentasPorVendedor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReporteventasporvendedor;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox19;
    }
}