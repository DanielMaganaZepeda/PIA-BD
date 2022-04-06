using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PIA_BD_E4.Componentes
{
    public partial class CardEvento : UserControl
    {
        private int id;
        public CardEvento(int id,bool completo)
        {
            InitializeComponent();
            this.id = id;
            if (completo)
            {
                Size = new Size(1819, Size.Height);
                btn_ver.Location = new Point(1619, 27);
            }
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                string aux,aux2;
                DateTime fecha;

                SqlCommand cmd = new SqlCommand($"select nombre from eventos where id = {id}",Program.conexion);
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

        private void btn_ver_Click(object sender, EventArgs e)
        {
            Program.eventos.Hide();
            Program.EventoDetalle(id);
        }
    }
}
