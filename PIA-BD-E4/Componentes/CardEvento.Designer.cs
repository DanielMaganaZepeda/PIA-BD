
namespace PIA_BD_E4.Componentes
{
    partial class CardEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardEvento));
            this.btn_ver = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_mes = new System.Windows.Forms.Label();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.lbl_DiaHora = new System.Windows.Forms.Label();
            this.lbl_evento = new System.Windows.Forms.Label();
            this.lbl_locacion = new System.Windows.Forms.Label();
            this.panel_linea = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_ver
            // 
            this.btn_ver.BackColor = System.Drawing.Color.Transparent;
            this.btn_ver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ver.BorderRadius = 2;
            this.btn_ver.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(81)))), ((int)(((byte)(167)))));
            this.btn_ver.CheckedState.Parent = this.btn_ver;
            this.btn_ver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ver.CustomImages.Parent = this.btn_ver;
            this.btn_ver.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(108)))), ((int)(((byte)(223)))));
            this.btn_ver.Font = new System.Drawing.Font("Muli", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ver.HoverState.Parent = this.btn_ver;
            this.btn_ver.Image = ((System.Drawing.Image)(resources.GetObject("btn_ver.Image")));
            this.btn_ver.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ver.ImageOffset = new System.Drawing.Point(147, 0);
            this.btn_ver.ImageSize = new System.Drawing.Size(6, 12);
            this.btn_ver.Location = new System.Drawing.Point(1269, 27);
            this.btn_ver.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.ShadowDecoration.Parent = this.btn_ver;
            this.btn_ver.Size = new System.Drawing.Size(185, 42);
            this.btn_ver.TabIndex = 0;
            this.btn_ver.Text = "Buscar boletos    ";
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // lbl_mes
            // 
            this.lbl_mes.AutoSize = true;
            this.lbl_mes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mes.Font = new System.Drawing.Font("Averta Demo PE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lbl_mes.Location = new System.Drawing.Point(30, 15);
            this.lbl_mes.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(41, 21);
            this.lbl_mes.TabIndex = 1;
            this.lbl_mes.Text = "ABR";
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dia.Font = new System.Drawing.Font("Averta Demo PE", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbl_dia.Location = new System.Drawing.Point(32, 32);
            this.lbl_dia.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(38, 27);
            this.lbl_dia.TabIndex = 2;
            this.lbl_dia.Text = "30";
            this.lbl_dia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DiaHora
            // 
            this.lbl_DiaHora.AutoSize = true;
            this.lbl_DiaHora.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DiaHora.Font = new System.Drawing.Font("Averta Demo PE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lbl_DiaHora.Location = new System.Drawing.Point(99, 15);
            this.lbl_DiaHora.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_DiaHora.Name = "lbl_DiaHora";
            this.lbl_DiaHora.Size = new System.Drawing.Size(91, 21);
            this.lbl_DiaHora.TabIndex = 3;
            this.lbl_DiaHora.Text = "Vie - 20:00";
            // 
            // lbl_evento
            // 
            this.lbl_evento.AutoSize = true;
            this.lbl_evento.BackColor = System.Drawing.Color.Transparent;
            this.lbl_evento.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbl_evento.Location = new System.Drawing.Point(99, 35);
            this.lbl_evento.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_evento.Name = "lbl_evento";
            this.lbl_evento.Size = new System.Drawing.Size(409, 21);
            this.lbl_evento.TabIndex = 4;
            this.lbl_evento.Text = "¡Que Nos Coge...La Pandemia! \"Como Anillo al Dedo\"";
            // 
            // lbl_locacion
            // 
            this.lbl_locacion.AutoSize = true;
            this.lbl_locacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_locacion.Font = new System.Drawing.Font("Averta Demo PE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_locacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lbl_locacion.Location = new System.Drawing.Point(100, 57);
            this.lbl_locacion.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_locacion.Name = "lbl_locacion";
            this.lbl_locacion.Size = new System.Drawing.Size(275, 21);
            this.lbl_locacion.TabIndex = 5;
            this.lbl_locacion.Text = "Teatro Ramiro Jiménez - México, DF";
            // 
            // panel_linea
            // 
            this.panel_linea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.panel_linea.Location = new System.Drawing.Point(0, 95);
            this.panel_linea.Name = "panel_linea";
            this.panel_linea.Size = new System.Drawing.Size(1475, 1);
            this.panel_linea.TabIndex = 6;
            // 
            // CardEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_linea);
            this.Controls.Add(this.lbl_locacion);
            this.Controls.Add(this.lbl_evento);
            this.Controls.Add(this.lbl_DiaHora);
            this.Controls.Add(this.lbl_dia);
            this.Controls.Add(this.lbl_mes);
            this.Controls.Add(this.btn_ver);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CardEvento";
            this.Size = new System.Drawing.Size(1469, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_ver;
        private System.Windows.Forms.Label lbl_mes;
        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.Label lbl_DiaHora;
        private System.Windows.Forms.Label lbl_evento;
        private System.Windows.Forms.Label lbl_locacion;
        private System.Windows.Forms.Panel panel_linea;
    }
}
