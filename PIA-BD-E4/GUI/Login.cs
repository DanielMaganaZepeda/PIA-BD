using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIA_BD_E4.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool Validar()
        {
            bool validar = true;
            if(tx_user.Text == "")
            {
                tx_user.BorderColor = Color.Red;
                MessageBox.Show("Debe introducir un nombre de usuario o contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validar = false;
                return validar;
            }
            if (tx_contra.Text == "")
            {
                tx_contra.BorderColor = Color.Red;
                MessageBox.Show("Debe introducir una contraseña de usuario o contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validar = false;
                return validar;
            }
            try
            {
                SqlCommand cmd = new SqlCommand($"select count(*) from usuarios where username='{tx_user.Text}' or correo = '{tx_user.Text}'", Program.conexion);
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    string user = cmd.ExecuteScalar().ToString();
                    cmd = new SqlCommand($"select count(*) from usuarios where (username='{tx_user.Text}' and contra='{tx_contra.Text}') or (correo='{tx_user}' and contra='{tx_contra.Text}')", Program.conexion);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    {
                        cmd = new SqlCommand($"select nombre + ' ' + ap_paterno from usuarios where (username='{tx_user.Text}' and contra='{tx_contra.Text}') or (correo='{tx_user.Text}' and contra='{tx_contra.Text}')", Program.conexion);
                        MessageBox.Show($"Bienvenido {cmd.ExecuteScalar()}!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        cmd = new SqlCommand($"select id from usuarios where (username='{tx_user.Text}' and contra='{tx_contra.Text}') or (correo='{tx_user.Text}' and contra='{tx_contra.Text}')", Program.conexion);
                        Program.Logear(cmd.ExecuteScalar().ToString());
                        this.Hide();
                    }
                    else
                    {
                        tx_contra.BorderColor = Color.Red;
                        MessageBox.Show("La contraseña introducia es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validar = false;
                        return validar;
                    }
                }
                else
                {
                    tx_user.BorderColor = Color.Red;
                    MessageBox.Show("No existe ningun usuario con este nombre de usuario o contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validar = false;
                    return validar;
                }
            }
            catch (Exception) { }
            return validar;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Validar();
        }

        private void tx_user_Enter(object sender, EventArgs e)
        {
            if(tx_user.BorderColor == Color.Red)
            {
                tx_user.BorderColor = Color.FromArgb(118, 134, 146);
            }
        }

        private void tx_contra_Enter(object sender, EventArgs e)
        {
            if (tx_contra.BorderColor == Color.Red)
            {
                tx_contra.BorderColor = Color.FromArgb(118, 134, 146);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Program.AbrirRegistrarse();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
