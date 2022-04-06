
namespace PIA_BD_E4.Componentes
{
    partial class CardLocalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardLocalidad));
            this.panel_linea = new System.Windows.Forms.Panel();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_siguiente = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_linea
            // 
            this.panel_linea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.panel_linea.Location = new System.Drawing.Point(0, 99);
            this.panel_linea.Name = "panel_linea";
            this.panel_linea.Size = new System.Drawing.Size(650, 1);
            this.panel_linea.TabIndex = 8;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_nombre.Font = new System.Drawing.Font("Muli", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbl_nombre.Location = new System.Drawing.Point(26, 24);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(200, 24);
            this.lbl_nombre.TabIndex = 10;
            this.lbl_nombre.Text = "Nombre de la localidad";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_precio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_precio.Font = new System.Drawing.Font("Muli", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(167)))));
            this.lbl_precio.Location = new System.Drawing.Point(26, 48);
            this.lbl_precio.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(148, 24);
            this.lbl_precio.TabIndex = 11;
            this.lbl_precio.Text = "Precio por boleto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(592, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(6, 12);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.BackColor = System.Drawing.Color.Transparent;
            this.btn_siguiente.BorderColor = System.Drawing.Color.Transparent;
            this.btn_siguiente.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btn_siguiente.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btn_siguiente.CheckedState.Parent = this.btn_siguiente;
            this.btn_siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_siguiente.CustomImages.Parent = this.btn_siguiente;
            this.btn_siguiente.FillColor = System.Drawing.Color.Transparent;
            this.btn_siguiente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_siguiente.ForeColor = System.Drawing.Color.Transparent;
            this.btn_siguiente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btn_siguiente.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btn_siguiente.HoverState.Parent = this.btn_siguiente;
            this.btn_siguiente.Location = new System.Drawing.Point(0, 0);
            this.btn_siguiente.Margin = new System.Windows.Forms.Padding(0);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.ShadowDecoration.Parent = this.btn_siguiente;
            this.btn_siguiente.Size = new System.Drawing.Size(650, 100);
            this.btn_siguiente.TabIndex = 13;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            this.btn_siguiente.MouseEnter += new System.EventHandler(this.btn_siguiente_MouseEnter);
            this.btn_siguiente.MouseLeave += new System.EventHandler(this.btn_siguiente_MouseLeave);
            // 
            // CardLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_linea);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_siguiente);
            this.Name = "CardLocalidad";
            this.Size = new System.Drawing.Size(650, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_linea;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_siguiente;
    }
}
