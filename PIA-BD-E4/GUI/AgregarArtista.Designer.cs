
namespace PIA_BD_E4.GUI
{
    partial class AgregarArtista
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
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_error1 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tx_biografia = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pic_imagen = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.warning = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Averta Demo PE", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(108)))), ((int)(((byte)(223)))));
            this.label4.Location = new System.Drawing.Point(808, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "*= Campos Requeridos";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.guna2Panel1.BorderThickness = 4;
            this.guna2Panel1.Controls.Add(this.warning);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.tx_error1);
            this.guna2Panel1.Controls.Add(this.label28);
            this.guna2Panel1.Controls.Add(this.tx_biografia);
            this.guna2Panel1.Controls.Add(this.label10);
            this.guna2Panel1.Controls.Add(this.pic_imagen);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.tx_nombre);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 45);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(960, 353);
            this.guna2Panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(653, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Haz click aqui para seleccionar una imagen";
            this.label2.Click += new System.EventHandler(this.pic_imagen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(108)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(639, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "*";
            // 
            // tx_error1
            // 
            this.tx_error1.AutoSize = true;
            this.tx_error1.BackColor = System.Drawing.Color.Transparent;
            this.tx_error1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tx_error1.Font = new System.Drawing.Font("Averta Demo PE", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_error1.ForeColor = System.Drawing.Color.Red;
            this.tx_error1.Location = new System.Drawing.Point(17, 604);
            this.tx_error1.Margin = new System.Windows.Forms.Padding(0);
            this.tx_error1.Name = "tx_error1";
            this.tx_error1.Size = new System.Drawing.Size(0, 20);
            this.tx_error1.TabIndex = 34;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label28.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label28.Location = new System.Drawing.Point(17, 60);
            this.label28.Margin = new System.Windows.Forms.Padding(0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 21);
            this.label28.TabIndex = 23;
            this.label28.Text = "Biografía";
            // 
            // tx_biografia
            // 
            this.tx_biografia.Animated = true;
            this.tx_biografia.AutoScroll = true;
            this.tx_biografia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.tx_biografia.BorderRadius = 1;
            this.tx_biografia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_biografia.DefaultText = "";
            this.tx_biografia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_biografia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_biografia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_biografia.DisabledState.Parent = this.tx_biografia;
            this.tx_biografia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_biografia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_biografia.FocusedState.Parent = this.tx_biografia;
            this.tx_biografia.Font = new System.Drawing.Font("Muli", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_biografia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tx_biografia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_biografia.HoverState.Parent = this.tx_biografia;
            this.tx_biografia.Location = new System.Drawing.Point(112, 60);
            this.tx_biografia.Margin = new System.Windows.Forms.Padding(4);
            this.tx_biografia.MaxLength = 1000;
            this.tx_biografia.Multiline = true;
            this.tx_biografia.Name = "tx_biografia";
            this.tx_biografia.PasswordChar = '\0';
            this.tx_biografia.PlaceholderText = "";
            this.tx_biografia.SelectedText = "";
            this.tx_biografia.ShadowDecoration.Parent = this.tx_biografia;
            this.tx_biografia.Size = new System.Drawing.Size(432, 243);
            this.tx_biografia.TabIndex = 6;
            this.tx_biografia.Enter += new System.EventHandler(this.tx_biografia_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label10.Location = new System.Drawing.Point(578, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Imagen";
            // 
            // pic_imagen
            // 
            this.pic_imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_imagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_imagen.FillColor = System.Drawing.Color.Transparent;
            this.pic_imagen.InitialImage = null;
            this.pic_imagen.Location = new System.Drawing.Point(581, 58);
            this.pic_imagen.Name = "pic_imagen";
            this.pic_imagen.ShadowDecoration.Parent = this.pic_imagen;
            this.pic_imagen.Size = new System.Drawing.Size(356, 245);
            this.pic_imagen.TabIndex = 16;
            this.pic_imagen.TabStop = false;
            this.pic_imagen.BackgroundImageChanged += new System.EventHandler(this.pic_imagen_BackgroundImageChanged);
            this.pic_imagen.Click += new System.EventHandler(this.pic_imagen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(108)))), ((int)(((byte)(223)))));
            this.label6.Location = new System.Drawing.Point(80, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label5.Location = new System.Drawing.Point(17, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre";
            // 
            // tx_nombre
            // 
            this.tx_nombre.Animated = true;
            this.tx_nombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.tx_nombre.BorderRadius = 1;
            this.tx_nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_nombre.DefaultText = "";
            this.tx_nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_nombre.DisabledState.Parent = this.tx_nombre;
            this.tx_nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_nombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_nombre.FocusedState.Parent = this.tx_nombre;
            this.tx_nombre.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tx_nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_nombre.HoverState.Parent = this.tx_nombre;
            this.tx_nombre.Location = new System.Drawing.Point(112, 23);
            this.tx_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_nombre.MaxLength = 100;
            this.tx_nombre.Name = "tx_nombre";
            this.tx_nombre.PasswordChar = '\0';
            this.tx_nombre.PlaceholderText = "";
            this.tx_nombre.SelectedText = "";
            this.tx_nombre.ShadowDecoration.Parent = this.tx_nombre;
            this.tx_nombre.Size = new System.Drawing.Size(432, 29);
            this.tx_nombre.TabIndex = 1;
            this.tx_nombre.WordWrap = false;
            this.tx_nombre.Enter += new System.EventHandler(this.tx_nombre_Enter);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.guna2Panel2.Font = new System.Drawing.Font("Averta Demo PE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.guna2Panel2.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(203, 66);
            this.guna2Panel2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Averta Demo PE", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.label3.Location = new System.Drawing.Point(9, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Información del artista";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 7;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(108)))), ((int)(((byte)(223)))));
            this.guna2Button2.Font = new System.Drawing.Font("Muli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(754, 404);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(106, 26);
            this.guna2Button2.TabIndex = 24;
            this.guna2Button2.Text = "Cancelar";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 7;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(108)))), ((int)(((byte)(223)))));
            this.guna2Button1.Font = new System.Drawing.Font("Muli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(161)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(866, 404);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(106, 26);
            this.guna2Button1.TabIndex = 23;
            this.guna2Button1.Text = "Continuar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.BackColor = System.Drawing.Color.Transparent;
            this.warning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warning.Font = new System.Drawing.Font("Averta Demo PE", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(17, 320);
            this.warning.Margin = new System.Windows.Forms.Padding(0);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(0, 20);
            this.warning.TabIndex = 37;
            // 
            // AgregarArtista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 439);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarArtista";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label tx_error1;
        private System.Windows.Forms.Label label28;
        private Guna.UI2.WinForms.Guna2TextBox tx_biografia;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2PictureBox pic_imagen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox tx_nombre;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label warning;
    }
}