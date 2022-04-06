
namespace PIA_BD_E4.Componentes
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.lbl_seleccion = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel_linea = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.tx_info = new System.Windows.Forms.RichTextBox();
            this.lbl_ubicacion = new System.Windows.Forms.Label();
            this.pic_ubicacion = new System.Windows.Forms.PictureBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.pic_fecha = new System.Windows.Forms.PictureBox();
            this.lbl_inmueble = new System.Windows.Forms.LinkLabel();
            this.tx_nombre = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ubicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fecha)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_seleccion
            // 
            this.lbl_seleccion.AutoSize = true;
            this.lbl_seleccion.Font = new System.Drawing.Font("Muli", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_seleccion.Location = new System.Drawing.Point(233, 12);
            this.lbl_seleccion.Name = "lbl_seleccion";
            this.lbl_seleccion.Size = new System.Drawing.Size(194, 24);
            this.lbl_seleccion.TabIndex = 14;
            this.lbl_seleccion.Text = "Información del evento";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(6, 12);
            this.guna2Button1.Location = new System.Drawing.Point(3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(45, 45);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel_linea
            // 
            this.panel_linea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.panel_linea.Location = new System.Drawing.Point(0, 49);
            this.panel_linea.Name = "panel_linea";
            this.panel_linea.Size = new System.Drawing.Size(660, 1);
            this.panel_linea.TabIndex = 12;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.tx_info);
            this.panel.Controls.Add(this.lbl_ubicacion);
            this.panel.Controls.Add(this.pic_ubicacion);
            this.panel.Controls.Add(this.lbl_fecha);
            this.panel.Controls.Add(this.pic_fecha);
            this.panel.Controls.Add(this.lbl_inmueble);
            this.panel.Controls.Add(this.tx_nombre);
            this.panel.Location = new System.Drawing.Point(0, 53);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(660, 752);
            this.panel.TabIndex = 16;
            // 
            // tx_info
            // 
            this.tx_info.BackColor = System.Drawing.Color.White;
            this.tx_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_info.Font = new System.Drawing.Font("Muli", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tx_info.Location = new System.Drawing.Point(16, 275);
            this.tx_info.Name = "tx_info";
            this.tx_info.Size = new System.Drawing.Size(612, 96);
            this.tx_info.TabIndex = 22;
            this.tx_info.Text = "";
            // 
            // lbl_ubicacion
            // 
            this.lbl_ubicacion.AutoSize = true;
            this.lbl_ubicacion.Font = new System.Drawing.Font("Muli SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ubicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_ubicacion.Location = new System.Drawing.Point(139, 160);
            this.lbl_ubicacion.Name = "lbl_ubicacion";
            this.lbl_ubicacion.Size = new System.Drawing.Size(180, 21);
            this.lbl_ubicacion.TabIndex = 21;
            this.lbl_ubicacion.Text = "Información del evento";
            // 
            // pic_ubicacion
            // 
            this.pic_ubicacion.Image = ((System.Drawing.Image)(resources.GetObject("pic_ubicacion.Image")));
            this.pic_ubicacion.Location = new System.Drawing.Point(17, 160);
            this.pic_ubicacion.Name = "pic_ubicacion";
            this.pic_ubicacion.Size = new System.Drawing.Size(22, 24);
            this.pic_ubicacion.TabIndex = 20;
            this.pic_ubicacion.TabStop = false;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Muli SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_fecha.Location = new System.Drawing.Point(46, 130);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(180, 21);
            this.lbl_fecha.TabIndex = 19;
            this.lbl_fecha.Text = "Información del evento";
            // 
            // pic_fecha
            // 
            this.pic_fecha.Image = ((System.Drawing.Image)(resources.GetObject("pic_fecha.Image")));
            this.pic_fecha.Location = new System.Drawing.Point(16, 130);
            this.pic_fecha.Name = "pic_fecha";
            this.pic_fecha.Size = new System.Drawing.Size(24, 24);
            this.pic_fecha.TabIndex = 18;
            this.pic_fecha.TabStop = false;
            // 
            // lbl_inmueble
            // 
            this.lbl_inmueble.AutoSize = true;
            this.lbl_inmueble.Font = new System.Drawing.Font("Muli SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inmueble.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(108)))), ((int)(((byte)(223)))));
            this.lbl_inmueble.Location = new System.Drawing.Point(46, 160);
            this.lbl_inmueble.Name = "lbl_inmueble";
            this.lbl_inmueble.Size = new System.Drawing.Size(87, 21);
            this.lbl_inmueble.TabIndex = 15;
            this.lbl_inmueble.TabStop = true;
            this.lbl_inmueble.Text = "linkLabel1";
            this.lbl_inmueble.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(108)))), ((int)(((byte)(223)))));
            this.lbl_inmueble.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tx_nombre
            // 
            this.tx_nombre.BackColor = System.Drawing.Color.White;
            this.tx_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nombre.Font = new System.Drawing.Font("Muli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tx_nombre.Location = new System.Drawing.Point(15, 15);
            this.tx_nombre.Name = "tx_nombre";
            this.tx_nombre.Size = new System.Drawing.Size(612, 42);
            this.tx_nombre.TabIndex = 17;
            this.tx_nombre.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 805);
            this.panel1.TabIndex = 18;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_seleccion);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.panel_linea);
            this.Controls.Add(this.panel);
            this.Name = "Info";
            this.Size = new System.Drawing.Size(660, 805);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ubicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_seleccion;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel_linea;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RichTextBox tx_nombre;
        private System.Windows.Forms.LinkLabel lbl_inmueble;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_fecha;
        private System.Windows.Forms.Label lbl_ubicacion;
        private System.Windows.Forms.PictureBox pic_ubicacion;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.RichTextBox tx_info;
    }
}
