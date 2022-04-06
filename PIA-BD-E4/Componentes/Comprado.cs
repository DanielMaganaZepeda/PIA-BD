using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIA_BD_E4.Componentes
{
    public partial class Comprado : UserControl
    {
        //id es el usuario id
        string venta_id;

        public Comprado(string venta_id)
        {
            this.venta_id = venta_id;
            InitializeComponent();
            OnInit();
        }

        private void OnInit()
        {
            try
            {
                //Cmd trae el ID del asiento
                SqlCommand cmd = new SqlCommand($"select top 1 asiento_id from ventas_detalles where venta_id = {venta_id}", Program.conexion);
                string aux = cmd.ExecuteScalar().ToString();
                //Cmd trae la localidad_id
                cmd = new SqlCommand($"select localidad_id from localidades_asientos where id = {aux}",Program.conexion);
                aux = cmd.ExecuteScalar().ToString();
                //Aux trae el ID del evento
                cmd = new SqlCommand($"select evento_id from localidades where id = {aux}",Program.conexion);
                aux = cmd.ExecuteScalar().ToString();

                CargarDatos(aux);

                try
                {
                    cmd = new SqlCommand("select imagen from eventos where id = " + aux, Program.conexion);

                    byte[] imageData = (byte[])(cmd.ExecuteScalar());
                    Image newImage;
                    using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                    {
                        ms.Write(imageData, 0, imageData.Length);
                        newImage = Image.FromStream(ms, true);
                    }
                    pic_imagen.BackgroundImage = newImage;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception) { }
        }

        private string GetMes(DateTime fecha)
        {
            switch (fecha.Month)
            {
                case 1: return "ENE";
                case 2: return "FEB";
                case 3: return "MAR";
                case 4: return "ABR";
                case 5: return "MAY";
                case 6: return "JUN";
                case 7: return "JUL";
                case 8: return "AGO";
                case 9: return "SEP";
                case 10: return "OCT";
                case 11: return "NOV";
                case 12: return "DIC";
                default: return "MES";
            }
        }
        private string GetDia(DateTime fecha)
        {
            switch (fecha.DayOfWeek)
            {
                case (DayOfWeek)1: return "Lun";
                case (DayOfWeek)2: return "Mar";
                case (DayOfWeek)3: return "Mie";
                case (DayOfWeek)4: return "Jue";
                case (DayOfWeek)5: return "Vie";
                case (DayOfWeek)6: return "Sab";
                case (DayOfWeek)7: return "Dom";
                default: return "Día";
            }
        }

        private void CargarDatos(string id)
        {
            try
            {
                string aux, aux2;
                DateTime fecha;

                SqlCommand cmd = new SqlCommand($"select nombre from eventos where id = {id}", Program.conexion);
                lbl_evento.Text = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand($"select fecha_inicio from eventos where id = {id}", Program.conexion);
                fecha = (DateTime.Parse(cmd.ExecuteScalar().ToString()));

                lbl_mes.Text = GetMes(fecha);
                lbl_dia.Text = fecha.Day.ToString();
                lbl_DiaHora.Text = GetDia(fecha) + " - " + fecha.ToString("HH:mm");

                cmd = new SqlCommand($"select inmueble_id from eventos where id = {id}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand($"select nombre from inmuebles where id = {aux}", Program.conexion);
                lbl_locacion.Text = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand($"select pais_id from inmuebles where id = {aux}", Program.conexion);
                aux2 = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select nombre from paises where id = {aux2}", Program.conexion);
                lbl_locacion.Text += " - " + cmd.ExecuteScalar().ToString() + ", ";

                cmd = new SqlCommand($"select estado_id from inmuebles where id = {aux}", Program.conexion);
                aux2 = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select abreviacion from estados where id = {aux2}", Program.conexion);
                lbl_locacion.Text += cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }

        private void panel_background_Click(object sender, EventArgs e)
        {
            Program.CargarBoletos(venta_id);
        }
    }
}
