
namespace PIA_BD_E4.Componentes
{
    partial class CardArtista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardArtista));
            this.panel_linea = new System.Windows.Forms.Panel();
            this.foto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.btn_info = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_linea
            // 
            this.panel_linea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.panel_linea.Location = new System.Drawing.Point(0, 149);
            this.panel_linea.Name = "panel_linea";
            this.panel_linea.Size = new System.Drawing.Size(1842, 1);
            this.panel_linea.TabIndex = 7;
            // 
            // foto
            // 
            this.foto.BackColor = System.Drawing.Color.Transparent;
            this.foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.foto.BorderRadius = 5;
            this.foto.Location = new System.Drawing.Point(8, 9);
            this.foto.Name = "foto";
            this.foto.ShadowDecoration.Parent = this.foto;
            this.foto.Size = new System.Drawing.Size(180, 132);
            this.foto.TabIndex = 8;
            this.foto.TabStop = false;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Muli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbl_nombre.Location = new System.Drawing.Point(210, 46);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(181, 26);
            this.lbl_nombre.TabIndex = 9;
            this.lbl_nombre.Text = "Nombre del artista";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cantidad.Font = new System.Drawing.Font("Averta Demo PE", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lbl_cantidad.Location = new System.Drawing.Point(211, 77);
            this.lbl_cantidad.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(193, 25);
            this.lbl_cantidad.TabIndex = 10;
            this.lbl_cantidad.Text = "Cantidad de eventos";
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.Color.Transparent;
            this.btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_info.BorderRadius = 2;
            this.btn_info.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(167)))));
            this.btn_info.CheckedState.Parent = this.btn_info;
            this.btn_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_info.CustomImages.Parent = this.btn_info;
            this.btn_info.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(108)))), ((int)(((byte)(223)))));
            this.btn_info.Font = new System.Drawing.Font("Muli", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_info.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(167)))));
            this.btn_info.HoverState.Parent = this.btn_info;
            this.btn_info.Image = ((System.Drawing.Image)(resources.GetObject("btn_info.Image")));
            this.btn_info.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_info.ImageOffset = new System.Drawing.Point(147, 0);
            this.btn_info.ImageSize = new System.Drawing.Size(6, 12);
            this.btn_info.Location = new System.Drawing.Point(1618, 48);
            this.btn_info.Margin = new System.Windows.Forms.Padding(0);
            this.btn_info.Name = "btn_info";
            this.btn_info.ShadowDecoration.Parent = this.btn_info;
            this.btn_info.Size = new System.Drawing.Size(185, 42);
            this.btn_info.TabIndex = 13;
            this.btn_info.Text = "Información   ";
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // CardArtista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.panel_linea);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.foto);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "CardArtista";
            this.Size = new System.Drawing.Size(1819, 150);
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_linea;
        private Guna.UI2.WinForms.Guna2PictureBox foto;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_cantidad;
        private Guna.UI2.WinForms.Guna2Button btn_info;
    }
}
