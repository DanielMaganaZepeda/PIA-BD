
namespace PIA_BD_E4.GUI
{
    partial class BoletosDigitales
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
            this.lbl_fechaa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_fechaa
            // 
            this.lbl_fechaa.AutoSize = true;
            this.lbl_fechaa.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(124)))), ((int)(((byte)(226)))));
            this.lbl_fechaa.Location = new System.Drawing.Point(12, 9);
            this.lbl_fechaa.Name = "lbl_fechaa";
            this.lbl_fechaa.Size = new System.Drawing.Size(147, 21);
            this.lbl_fechaa.TabIndex = 1;
            this.lbl_fechaa.Text = "Fecha de compra: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(124)))), ((int)(((byte)(226)))));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total de la compra:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_total.Location = new System.Drawing.Point(172, 30);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(153, 21);
            this.lbl_total.TabIndex = 9;
            this.lbl_total.Text = "Nombre del evento";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_fecha.Location = new System.Drawing.Point(172, 9);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(153, 21);
            this.lbl_fecha.TabIndex = 10;
            this.lbl_fecha.Text = "Nombre del evento";
            // 
            // BoletosDigitales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 761);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_fechaa);
            this.Name = "BoletosDigitales";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_fechaa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_fecha;
    }
}