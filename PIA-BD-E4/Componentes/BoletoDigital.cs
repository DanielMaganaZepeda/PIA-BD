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

namespace PIA_BD_E4.Componentes
{
    public partial class BoletoDigital : UserControl
    {
        public BoletoDigital(string asiento_id)
        {
            InitializeComponent();
            try
            {
                lbl_id.Text = asiento_id;
                string aux;
                SqlCommand cmd = new SqlCommand($"select fila from localidades_asientos where id = {asiento_id}", Program.conexion);
                lbl_fila.Text = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select asiento from localidades_asientos where id = {asiento_id}", Program.conexion);
                lbl_asiento.Text = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select localidad_id from localidades_asientos where id = {asiento_id}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select nombre from localidades where id = {aux}", Program.conexion);
                lbl_localidad.Text = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select precio from localidades where id = {aux}",Program.conexion);
                double precio = Convert.ToDouble(cmd.ExecuteScalar());
                lbl_precio.Text = "$" + string.Format("{0:0.00}", precio);
                cmd = new SqlCommand($"select evento_id from localidades where id = {aux}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select nombre from eventos where id = {aux}", Program.conexion);
                lbl_evento.Text = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select fecha_inicio from eventos where id = {aux}", Program.conexion);
                DateTime fecha = DateTime.Parse(cmd.ExecuteScalar().ToString());
                lbl_fecha.Text = fecha.ToString("dd/MM/yyyy") + "@" + fecha.ToString("HH:mm");
                cmd = new SqlCommand($"select inmueble_id from eventos where id = {aux}",Program.conexion);
                aux = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select nombre from inmuebles where id = {aux}",Program.conexion);
                lbl_inmueble.Text = cmd.ExecuteScalar().ToString();
            }
            catch (Exception) { }
        }
    }
}
