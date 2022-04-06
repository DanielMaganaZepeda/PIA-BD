
namespace PIA_BD_E4.GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_user = new Guna.UI2.WinForms.Guna2TextBox();
            this.tx_contra = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ingresar = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Muli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicia sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Muli SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(42, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Utiliza tu cuenta de Megatickets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Muli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(134)))), ((int)(((byte)(146)))));
            this.label3.Location = new System.Drawing.Point(42, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correo o usuario";
            // 
            // tx_user
            // 
            this.tx_user.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(134)))), ((int)(((byte)(146)))));
            this.tx_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_user.DefaultText = "";
            this.tx_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_user.DisabledState.Parent = this.tx_user;
            this.tx_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_user.FocusedState.Parent = this.tx_user;
            this.tx_user.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tx_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_user.HoverState.Parent = this.tx_user;
            this.tx_user.Location = new System.Drawing.Point(46, 159);
            this.tx_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_user.Name = "tx_user";
            this.tx_user.PasswordChar = '\0';
            this.tx_user.PlaceholderText = "";
            this.tx_user.SelectedText = "";
            this.tx_user.ShadowDecoration.Parent = this.tx_user;
            this.tx_user.Size = new System.Drawing.Size(448, 36);
            this.tx_user.TabIndex = 4;
            this.tx_user.Enter += new System.EventHandler(this.tx_user_Enter);
            // 
            // tx_contra
            // 
            this.tx_contra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(134)))), ((int)(((byte)(146)))));
            this.tx_contra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_contra.DefaultText = "";
            this.tx_contra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tx_contra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tx_contra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_contra.DisabledState.Parent = this.tx_contra;
            this.tx_contra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tx_contra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_contra.FocusedState.Parent = this.tx_contra;
            this.tx_contra.Font = new System.Drawing.Font("Muli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_contra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.tx_contra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tx_contra.HoverState.Parent = this.tx_contra;
            this.tx_contra.Location = new System.Drawing.Point(47, 230);
            this.tx_contra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_contra.Name = "tx_contra";
            this.tx_contra.PasswordChar = '\0';
            this.tx_contra.PlaceholderText = "";
            this.tx_contra.SelectedText = "";
            this.tx_contra.ShadowDecoration.Parent = this.tx_contra;
            this.tx_contra.Size = new System.Drawing.Size(448, 36);
            this.tx_contra.TabIndex = 6;
            this.tx_contra.UseSystemPasswordChar = true;
            this.tx_contra.Enter += new System.EventHandler(this.tx_contra_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Muli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(134)))), ((int)(((byte)(146)))));
            this.label4.Location = new System.Drawing.Point(43, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.CheckedState.Parent = this.btn_ingresar;
            this.btn_ingresar.CustomImages.Parent = this.btn_ingresar;
            this.btn_ingresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(108)))), ((int)(((byte)(223)))));
            this.btn_ingresar.Font = new System.Drawing.Font("Muli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_ingresar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(81)))), ((int)(((byte)(167)))));
            this.btn_ingresar.HoverState.Parent = this.btn_ingresar;
            this.btn_ingresar.Location = new System.Drawing.Point(47, 329);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.ShadowDecoration.Parent = this.btn_ingresar;
            this.btn_ingresar.Size = new System.Drawing.Size(448, 38);
            this.btn_ingresar.TabIndex = 7;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Muli", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(105, 433);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "¿Nuevo en Megaticket?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Muli", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(124)))), ((int)(((byte)(226)))));
            this.linkLabel1.Location = new System.Drawing.Point(294, 433);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(138, 24);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Crea una cuenta";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(124)))), ((int)(((byte)(226)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(493, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 515);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.panel3.Location = new System.Drawing.Point(-2, 513);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 1);
            this.panel3.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.panel2.Location = new System.Drawing.Point(539, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 515);
            this.panel2.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(540, 1);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.panel5.Location = new System.Drawing.Point(0, 514);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(540, 1);
            this.panel5.TabIndex = 14;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 515);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.tx_contra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tx_user;
        private Guna.UI2.WinForms.Guna2TextBox tx_contra;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btn_ingresar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}