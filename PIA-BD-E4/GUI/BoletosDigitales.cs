using PIA_BD_E4.Componentes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PIA_BD_E4.GUI
{
    public partial class BoletosDigitales : Form
    {
        public BoletosDigitales(string venta_id)
        {
            InitializeComponent();
            try
            {
                SqlCommand cmd = new SqlCommand($"select total from ventas where id={venta_id}", Program.conexion);
                lbl_total.Text = " $" + cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select fecha from ventas where id = {venta_id}", Program.conexion);
                DateTime fecha = DateTime.Parse(cmd.ExecuteScalar().ToString());
                lbl_fecha.Text = fecha.ToString("dd/MM/yyyy");

                List<string> asientos_id = new List<string>();
                cmd = new SqlCommand($"select * from ventas_detalles where venta_id = {venta_id}",Program.conexion);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        asientos_id.Add(reader["asiento_id"].ToString());
                    }
                    reader.Close();
                }

                List<BoletoDigital> cards = new List<BoletoDigital>();
                BoletoDigital ultimo = null;
                BoletoDigital aux;

                foreach(string asiento_id in asientos_id)
                {
                    aux = new BoletoDigital(asiento_id);
                    Controls.Add(aux);
                    aux.BringToFront();
                    if (ultimo == null)
                    {
                        aux.Location = new Point(10, 60);
                    }
                    else
                    {
                        aux.Location = new Point(10, ultimo.Location.Y + ultimo.Size.Height + 5);
                    }
                    ultimo = aux;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + "BOLETOS DIGITALES"); }
        }
    }
}
