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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Program.AbrirLogin();
        }

        private void Validar()
        {
            if(tx_nombre.Text == "")
            {
                tx_nombre.BorderColor = Color.Red;
                MessageBox.Show("Debe introducir al menos un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tx_ap_paterno.Text == "")
            {
                tx_ap_paterno.BorderColor = Color.Red;
                MessageBox.Show("Debe introducir un apellido paterno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tx_ap_materno.Text == "")
            {
                tx_ap_materno.BorderColor = Color.Red;
                MessageBox.Show("Debe introducir al menos un apellido materno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tx_user.Text == "")
            {
                tx_user.BorderColor = Color.Red;
                MessageBox.Show("Debe introducir al menos un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tx_correo.Text == "")
            {
                tx_correo.BorderColor = Color.Red;
                MessageBox.Show("Debe introducir al menos un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tx_contra.Text == "")
            {
                tx_contra.BorderColor = Color.Red;
                MessageBox.Show("Debe introducir una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tx_contra2.Text == "")
            {
                tx_contra2.BorderColor = Color.Red;
                MessageBox.Show("Debe introducir al menos un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tx_contra.Text != tx_contra2.Text)
            {
                tx_contra2.BorderColor = Color.Red;
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SqlCommand cmd = new SqlCommand($"select count(*) from usuarios where user = '{tx_user.Text}'", Program.conexion);
                if (Convert.ToInt32(cmd.ExecuteScalar())>0)
                {
                    tx_user.BorderColor = Color.Red;
                    MessageBox.Show("Ya existe un usuario con este nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    cmd = new SqlCommand($"select count(*) from usuarios where correo = '{tx_correo.Text}'", Program.conexion);
                    if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                    {
                        tx_correo.BorderColor = Color.Red;
                        MessageBox.Show("Ya existe un usuario con este correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        cmd = new SqlCommand($"insert into usuarios values('{tx_user.Text}','{tx_contra.Text}','{tx_ap_paterno.Text}','{tx_ap_materno.Text}'," +
                            $"'{tx_nombre.Text}','{tx_correo.Text}',0)", Program.conexion);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se ha registrado el usuario con exito!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        cmd = new SqlCommand($"select id from usuarios where username = {tx_user.Text}",Program.conexion);
                        Program.Logear(cmd.ExecuteScalar().ToString());
                    }
                }
            }
            catch (Exception) { }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Validar();
        }
    }
}
