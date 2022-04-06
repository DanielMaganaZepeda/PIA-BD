
namespace PIA_BD_E4.Componentes
{
    partial class Comprado
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprado));
            this.panel_background = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_locacion = new System.Windows.Forms.Label();
            this.lbl_evento = new System.Windows.Forms.Label();
            this.lbl_DiaHora = new System.Windows.Forms.Label();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.lbl_mes = new System.Windows.Forms.Label();
            this.pic_imagen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_background
            // 
            this.panel_background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_background.BackgroundImage")));
            this.panel_background.Controls.Add(this.pictureBox1);
            this.panel_background.Controls.Add(this.lbl_locacion);
            this.panel_background.Controls.Add(this.lbl_evento);
            this.panel_background.Controls.Add(this.lbl_DiaHora);
            this.panel_background.Controls.Add(this.lbl_dia);
            this.panel_background.Controls.Add(this.lbl_mes);
            this.panel_background.Controls.Add(this.pic_imagen);
            this.panel_background.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_background.Location = new System.Drawing.Point(0, 0);
            this.panel_background.Name = "panel_background";
            this.panel_background.ShadowDecoration.Parent = this.panel_background;
            this.panel_background.Size = new System.Drawing.Size(900, 134);
            this.panel_background.TabIndex = 0;
            this.panel_background.Click += new System.EventHandler(this.panel_background_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(867, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 28);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_locacion
            // 
            this.lbl_locacion.AutoSize = true;
            this.lbl_locacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_locacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_locacion.Font = new System.Drawing.Font("Averta Demo PE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_locacion.ForeColor = System.Drawing.Color.White;
            this.lbl_locacion.Location = new System.Drawing.Point(277, 76);
            this.lbl_locacion.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_locacion.Name = "lbl_locacion";
            this.lbl_locacion.Size = new System.Drawing.Size(275, 21);
            this.lbl_locacion.TabIndex = 20;
            this.lbl_locacion.Text = "Teatro Ramiro Jiménez - México, DF";
            // 
            // lbl_evento
            // 
            this.lbl_evento.AutoSize = true;
            this.lbl_evento.BackColor = System.Drawing.Color.Transparent;
            this.lbl_evento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_evento.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evento.ForeColor = System.Drawing.Color.White;
            this.lbl_evento.Location = new System.Drawing.Point(276, 54);
            this.lbl_evento.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_evento.Name = "lbl_evento";
            this.lbl_evento.Size = new System.Drawing.Size(409, 21);
            this.lbl_evento.TabIndex = 19;
            this.lbl_evento.Text = "¡Que Nos Coge...La Pandemia! \"Como Anillo al Dedo\"";
            // 
            // lbl_DiaHora
            // 
            this.lbl_DiaHora.AutoSize = true;
            this.lbl_DiaHora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DiaHora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_DiaHora.Font = new System.Drawing.Font("Averta Demo PE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaHora.ForeColor = System.Drawing.Color.White;
            this.lbl_DiaHora.Location = new System.Drawing.Point(276, 34);
            this.lbl_DiaHora.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_DiaHora.Name = "lbl_DiaHora";
            this.lbl_DiaHora.Size = new System.Drawing.Size(91, 21);
            this.lbl_DiaHora.TabIndex = 18;
            this.lbl_DiaHora.Text = "Vie - 20:00";
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_dia.Font = new System.Drawing.Font("Averta Demo PE", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dia.ForeColor = System.Drawing.Color.White;
            this.lbl_dia.Location = new System.Drawing.Point(209, 51);
            this.lbl_dia.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(38, 27);
            this.lbl_dia.TabIndex = 17;
            this.lbl_dia.Text = "30";
            this.lbl_dia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mes
            // 
            this.lbl_mes.AutoSize = true;
            this.lbl_mes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_mes.Font = new System.Drawing.Font("Averta Demo PE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mes.ForeColor = System.Drawing.Color.White;
            this.lbl_mes.Location = new System.Drawing.Point(207, 34);
            this.lbl_mes.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(41, 21);
            this.lbl_mes.TabIndex = 16;
            this.lbl_mes.Text = "ABR";
            // 
            // pic_imagen
            // 
            this.pic_imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.pic_imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_imagen.BorderRadius = 7;
            this.pic_imagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_imagen.FillColor = System.Drawing.Color.Transparent;
            this.pic_imagen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pic_imagen.Location = new System.Drawing.Point(26, 24);
            this.pic_imagen.Name = "pic_imagen";
            this.pic_imagen.ShadowDecoration.Parent = this.pic_imagen;
            this.pic_imagen.Size = new System.Drawing.Size(150, 85);
            this.pic_imagen.TabIndex = 15;
            this.pic_imagen.TabStop = false;
            // 
            // Comprado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_background);
            this.Name = "Comprado";
            this.Size = new System.Drawing.Size(900, 134);
            this.panel_background.ResumeLayout(false);
            this.panel_background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panel_background;
        private Guna.UI2.WinForms.Guna2PictureBox pic_imagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_locacion;
        private System.Windows.Forms.Label lbl_evento;
        private System.Windows.Forms.Label lbl_DiaHora;
        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.Label lbl_mes;
    }
}
