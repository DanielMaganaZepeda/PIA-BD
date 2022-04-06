
namespace PIA_BD_E4.Componentes
{
    partial class Boletos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boletos));
            this.panel_linea = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_seleccion = new System.Windows.Forms.Label();
            this.linea_cantidad = new System.Windows.Forms.Panel();
            this.btn_comprar = new Guna.UI2.WinForms.Guna2Button();
            this.pic_boletos = new System.Windows.Forms.PictureBox();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.tx2 = new System.Windows.Forms.Label();
            this.tx1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_boletos)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_linea
            // 
            this.panel_linea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.panel_linea.Location = new System.Drawing.Point(0, 50);
            this.panel_linea.Name = "panel_linea";
            this.panel_linea.Size = new System.Drawing.Size(660, 1);
            this.panel_linea.TabIndex = 9;
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
            this.guna2Button1.Location = new System.Drawing.Point(3, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(45, 45);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lbl_seleccion
            // 
            this.lbl_seleccion.AutoSize = true;
            this.lbl_seleccion.Font = new System.Drawing.Font("Muli", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_seleccion.Location = new System.Drawing.Point(276, 13);
            this.lbl_seleccion.Name = "lbl_seleccion";
            this.lbl_seleccion.Size = new System.Drawing.Size(108, 24);
            this.lbl_seleccion.TabIndex = 11;
            this.lbl_seleccion.Text = "Tu selección";
            // 
            // linea_cantidad
            // 
            this.linea_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.linea_cantidad.Location = new System.Drawing.Point(0, 703);
            this.linea_cantidad.Name = "linea_cantidad";
            this.linea_cantidad.Size = new System.Drawing.Size(652, 1);
            this.linea_cantidad.TabIndex = 10;
            // 
            // btn_comprar
            // 
            this.btn_comprar.BorderRadius = 2;
            this.btn_comprar.CheckedState.Parent = this.btn_comprar;
            this.btn_comprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comprar.CustomImages.Parent = this.btn_comprar;
            this.btn_comprar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(138)))), ((int)(((byte)(9)))));
            this.btn_comprar.Font = new System.Drawing.Font("Muli ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprar.ForeColor = System.Drawing.Color.White;
            this.btn_comprar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(103)))), ((int)(((byte)(6)))));
            this.btn_comprar.HoverState.Parent = this.btn_comprar;
            this.btn_comprar.Location = new System.Drawing.Point(20, 756);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.ShadowDecoration.Parent = this.btn_comprar;
            this.btn_comprar.Size = new System.Drawing.Size(620, 35);
            this.btn_comprar.TabIndex = 12;
            this.btn_comprar.Text = "Comprar boletos";
            this.btn_comprar.TextOffset = new System.Drawing.Point(0, -1);
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // pic_boletos
            // 
            this.pic_boletos.Image = ((System.Drawing.Image)(resources.GetObject("pic_boletos.Image")));
            this.pic_boletos.Location = new System.Drawing.Point(20, 720);
            this.pic_boletos.Name = "pic_boletos";
            this.pic_boletos.Size = new System.Drawing.Size(22, 21);
            this.pic_boletos.TabIndex = 13;
            this.pic_boletos.TabStop = false;
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_x.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lbl_x.Location = new System.Drawing.Point(42, 719);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(20, 21);
            this.lbl_x.TabIndex = 14;
            this.lbl_x.Text = "×";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_cantidad.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lbl_cantidad.Location = new System.Drawing.Point(55, 719);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(22, 21);
            this.lbl_cantidad.TabIndex = 15;
            this.lbl_cantidad.Text = "N";
            // 
            // tx2
            // 
            this.tx2.AutoSize = true;
            this.tx2.Font = new System.Drawing.Font("Muli", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tx2.Location = new System.Drawing.Point(87, 49);
            this.tx2.Name = "tx2";
            this.tx2.Size = new System.Drawing.Size(486, 24);
            this.tx2.TabIndex = 18;
            this.tx2.Text = "Intenta con otra cantidad de boletos o busca en otra localidad";
            // 
            // tx1
            // 
            this.tx1.AutoSize = true;
            this.tx1.Font = new System.Drawing.Font("Muli", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tx1.Location = new System.Drawing.Point(217, 25);
            this.tx1.Name = "tx1";
            this.tx1.Size = new System.Drawing.Size(224, 24);
            this.tx1.TabIndex = 17;
            this.tx1.Text = "No se encontraron boletos";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.tx2);
            this.panel.Controls.Add(this.tx1);
            this.panel.Location = new System.Drawing.Point(0, 54);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(660, 648);
            this.panel.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 805);
            this.panel1.TabIndex = 11;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Muli", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lbl_total.Location = new System.Drawing.Point(582, 717);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(57, 24);
            this.lbl_total.TabIndex = 19;
            this.lbl_total.Text = "Total: ";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Boletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.pic_boletos);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.linea_cantidad);
            this.Controls.Add(this.lbl_seleccion);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.panel_linea);
            this.Name = "Boletos";
            this.Size = new System.Drawing.Size(660, 805);
            ((System.ComponentModel.ISupportInitialize)(this.pic_boletos)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_linea;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label lbl_seleccion;
        private System.Windows.Forms.Panel linea_cantidad;
        private Guna.UI2.WinForms.Guna2Button btn_comprar;
        private System.Windows.Forms.PictureBox pic_boletos;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label tx2;
        private System.Windows.Forms.Label tx1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_total;
    }
}
