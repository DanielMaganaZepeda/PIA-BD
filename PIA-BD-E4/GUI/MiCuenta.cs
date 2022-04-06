using PIA_BD_E4.Componentes;
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
    public partial class MiCuenta : Form
    {
        List<string> ids;

        List<Comprado> cards = new List<Comprado>();
        Comprado ultimo;

        public MiCuenta()
        {
            InitializeComponent();
            OnInit();
        }

        private void OnInit()
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            Cargar(true);
        }

        private void Cargar(bool proximos)
        {
            try
            {
                ids = new List<string>();
                foreach(Comprado card in cards)
                {
                    card.Dispose();
                }
                cards.Clear();
                ultimo = null;
                Comprado aux2;
                string aux;
                SqlCommand cmd = new SqlCommand($"select * from ventas where usuario_id = {Program.logeado}", Program.conexion);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ids.Add(reader["id"].ToString());
                    }
                    reader.Close();

                    foreach(string venta_id in ids)
                    {
                        //Aux trae el asiento id
                        cmd = new SqlCommand($"select top 1 asiento_id from ventas_detalles where venta_id = {venta_id}",Program.conexion);
                        aux = cmd.ExecuteScalar().ToString();

                        //Aux trae localidad_id
                        cmd = new SqlCommand($"select localidad_id from localidades_asientos where id = {aux}", Program.conexion);
                        aux = cmd.ExecuteScalar().ToString();

                        //aux trae el evento_id
                        cmd = new SqlCommand($"select evento_id from localidades where id = {aux}",Program.conexion);
                        aux = cmd.ExecuteScalar().ToString();

                        cmd = new SqlCommand($"select fecha_inicio from eventos where id = {aux}", Program.conexion);
                        aux = cmd.ExecuteScalar().ToString();

                        DateTime fecha = DateTime.Parse(aux);
                        if(proximos == true)
                        {
                            if (fecha > DateTime.Now)
                            {
                                //693,313
                                aux2 = new Comprado(venta_id);
                                Controls.Add(aux2);
                                aux2.BringToFront();
                                if (ultimo == null)
                                {
                                    aux2.Location = new Point(693, 313);
                                }
                                else
                                {
                                    aux2.Location = new Point(693, ultimo.Location.Y + ultimo.Size.Height + 5);
                                }
                                ultimo = aux2;
                                cards.Add(aux2);
                            }
                        }
                        else
                        {
                            if(fecha < DateTime.Now)
                            {
                                aux2 = new Comprado(venta_id);
                                Controls.Add(aux2);
                                aux2.BringToFront();
                                if (ultimo == null)
                                {
                                    aux2.Location = new Point(693, 313);
                                }
                                else
                                {
                                    aux2.Location = new Point(693, ultimo.Location.Y + ultimo.Size.Height + 5);
                                }
                                ultimo = aux2;
                                cards.Add(aux2);
                            }
                        }

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_proximos_Click(object sender, EventArgs e)
        {
            Cargar(true);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Cargar(false);
        }

        private void btn_cuenta_Click(object sender, EventArgs e)
        {
            if (Program.logeado == null)
            {
                Program.AbrirLogin();
                if (Program.logeado != null)
                {
                    this.Hide();
                    Program.AbrirCuenta();
                }
            }
            else
            {
                this.Hide();
                Program.AbrirCuenta();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                this.Hide();
                Program.Deslogear();
            }
        }

        private void MiCuenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Program.actual == this)
            {
                Application.Exit();
            }
        }

        private void btn_eventos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.EventosLista(0);
        }

        private void btn_inmuebles_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.InmueblesLista();
        }

        private void btn_artistas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ArtistasLista();
        }
    }
}
