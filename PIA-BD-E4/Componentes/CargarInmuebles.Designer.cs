
namespace PIA_BD_E4.Componentes
{
    partial class CargarInmuebl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CargarInmuebl));
            this.panel_background = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.pb_cantidad = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.btn_mas = new Guna.UI2.WinForms.Guna2Button();
            this.panel_background.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_background
            // 
            this.panel_background.BorderRadius = 4;
            this.panel_background.Controls.Add(this.lbl_cantidad);
            this.panel_background.Controls.Add(this.pb_cantidad);
            this.panel_background.Controls.Add(this.btn_mas);
            this.panel_background.FillColor = System.Drawing.Color.White;
            this.panel_background.Location = new System.Drawing.Point(0, 0);
            this.panel_background.Margin = new System.Windows.Forms.Padding(0);
            this.panel_background.Name = "panel_background";
            this.panel_background.ShadowDecoration.Parent = this.panel_background;
            this.panel_background.Size = new System.Drawing.Size(1819, 130);
            this.panel_background.TabIndex = 0;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Averta Demo PE", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lbl_cantidad.Location = new System.Drawing.Point(800, 17);
            this.lbl_cantidad.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(228, 17);
            this.lbl_cantidad.TabIndex = 2;
            this.lbl_cantidad.Text = "Cargando ## de ### inmuebles";
            this.lbl_cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_cantidad
            // 
            this.pb_cantidad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pb_cantidad.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pb_cantidad.Location = new System.Drawing.Point(769, 43);
            this.pb_cantidad.Name = "pb_cantidad";
            this.pb_cantidad.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(108)))), ((int)(((byte)(223)))));
            this.pb_cantidad.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(108)))), ((int)(((byte)(223)))));
            this.pb_cantidad.ShadowDecoration.Parent = this.pb_cantidad;
            this.pb_cantidad.Size = new System.Drawing.Size(281, 4);
            this.pb_cantidad.TabIndex = 1;
            this.pb_cantidad.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btn_mas
            // 
            this.btn_mas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(107)))), ((int)(((byte)(221)))));
            this.btn_mas.BorderRadius = 20;
            this.btn_mas.BorderThickness = 1;
            this.btn_mas.CheckedState.Parent = this.btn_mas;
            this.btn_mas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mas.CustomImages.Parent = this.btn_mas;
            this.btn_mas.FillColor = System.Drawing.Color.White;
            this.btn_mas.Font = new System.Drawing.Font("Muli ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(107)))), ((int)(((byte)(221)))));
            this.btn_mas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(167)))));
            this.btn_mas.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(167)))));
            this.btn_mas.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_mas.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btn_mas.HoverState.Image")));
            this.btn_mas.HoverState.Parent = this.btn_mas;
            this.btn_mas.Image = ((System.Drawing.Image)(resources.GetObject("btn_mas.Image")));
            this.btn_mas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_mas.ImageOffset = new System.Drawing.Point(215, 0);
            this.btn_mas.ImageSize = new System.Drawing.Size(12, 6);
            this.btn_mas.Location = new System.Drawing.Point(739, 63);
            this.btn_mas.Margin = new System.Windows.Forms.Padding(0);
            this.btn_mas.Name = "btn_mas";
            this.btn_mas.ShadowDecoration.Parent = this.btn_mas;
            this.btn_mas.Size = new System.Drawing.Size(341, 42);
            this.btn_mas.TabIndex = 0;
            this.btn_mas.Text = "Más inmuebles     ";
            this.btn_mas.Click += new System.EventHandler(this.btn_mas_Click);
            // 
            // CargarInmuebles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel_background);
            this.Name = "CargarInmuebles";
            this.Size = new System.Drawing.Size(1819, 130);
            this.panel_background.ResumeLayout(false);
            this.panel_background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_background;
        private System.Windows.Forms.Label lbl_cantidad;
        private Guna.UI2.WinForms.Guna2ProgressBar pb_cantidad;
        private Guna.UI2.WinForms.Guna2Button btn_mas;
    }
}
