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
    public partial class Info : UserControl
    {
        int id;
        public Info(int id)
        {
            InitializeComponent();
            this.id = id;
            CargarInfo();
        }

        private void CargarInfo()
        {

            List<Punto> puntos = new List<Punto>();

            try
            {
                SqlCommand cmd;
                string aux;
                int entero;
                try
                {
                    cmd = new SqlCommand($"select nombre from eventos where id = {id}", Program.conexion);
                    aux= cmd.ExecuteScalar().ToString();
                    entero = 0;
                    foreach (char i in aux)
                    {
                        if (i != '\n')
                        {
                            if (entero<=32)
                            {
                                tx_nombre.Text += i.ToString();
                            }
                            else
                            {
                                tx_nombre.Text += i.ToString();
                                entero= 0;
                            }
                            entero++;
                        }
                        else
                        {
                        }
                    }
                    tx_nombre.Size = new Size(tx_nombre.Width, tx_nombre.Lines.Length * 26);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                //Fecha
                try
                {
                    DateTime fecha;
                    cmd = new SqlCommand($"select fecha_inicio from eventos where id = {id}", Program.conexion);
                    fecha = (DateTime.Parse(cmd.ExecuteScalar().ToString()));
                    lbl_fecha.Text = GetDia(fecha) + ". " + fecha.Day.ToString() + " " + GetMes(fecha) + " " + fecha.Year.ToString() + " @ ";
                    lbl_fecha.Text += fecha.ToString("HH") + ":" + fecha.ToString("mm") + " ";
                    if (fecha.Hour >= 12) lbl_fecha.Text += "p. m.";
                    else lbl_fecha.Text += "a. m.";
                    pic_fecha.Location = new Point(pic_fecha.Location.X, tx_nombre.Location.Y + tx_nombre.Size.Height + 24);
                    lbl_fecha.Location = new Point(pic_fecha.Location.X+pic_fecha.Size.Width, pic_fecha.Location.Y);
                }
                catch (Exception) { }
                //Ubicacion
                try
                {
                    string inmueble_id, ciudad_id, estado_id;
                    cmd = new SqlCommand($"select inmueble_id from eventos where id = {id}", Program.conexion);
                    inmueble_id = cmd.ExecuteScalar().ToString();
                    cmd = new SqlCommand($"select ciudad_id from inmuebles where id = {inmueble_id}", Program.conexion);
                    ciudad_id = cmd.ExecuteScalar().ToString();
                    cmd = new SqlCommand($"select estado_id from inmuebles where id = {inmueble_id}", Program.conexion);
                    estado_id= cmd.ExecuteScalar().ToString();
                    cmd = new SqlCommand($"select nombre from inmuebles where id = {inmueble_id}", Program.conexion);
                    lbl_inmueble.Text = cmd.ExecuteScalar().ToString();
                    cmd = new SqlCommand($"select nombre from ciudades where id = {ciudad_id}",Program.conexion);
                    lbl_ubicacion.Text = ", " + cmd.ExecuteScalar().ToString() + ", ";
                    cmd = new SqlCommand($"select abreviacion from estados where id = {estado_id}", Program.conexion);
                    lbl_ubicacion.Text += cmd.ExecuteScalar().ToString();
                    pic_ubicacion.Location = new Point(pic_ubicacion.Location.X, pic_fecha.Location.Y + pic_fecha.Size.Height + 16);
                    lbl_inmueble.Location = new Point(pic_ubicacion.Location.X + pic_ubicacion.Size.Width, pic_ubicacion.Location.Y);
                    lbl_ubicacion.Location = new Point(lbl_inmueble.Location.X + lbl_inmueble.Size.Width, lbl_inmueble.Location.Y);
                    tx_info.Location = new Point(tx_info.Location.X, pic_ubicacion.Location.Y + pic_ubicacion.Size.Height + 32);
                }
                catch (Exception) { }
                int cantidad=1;
                //Informacion del evento
                try
                {
                    cmd = new SqlCommand($"select informacion from eventos where id = {id}", Program.conexion);
                    aux = cmd.ExecuteScalar().ToString();
                    entero = 0;
                    if (aux != "")
                    {
                        puntos.Add(new Punto(0, 22));
                        tx_info.Text += "Informacion del evento" + Environment.NewLine;
                        foreach (char i in aux)
                        {
                            if (i != '\n')
                            {
                                if (entero <= 50)
                                {
                                    tx_info.Text += i.ToString();
                                }
                                else
                                {
                                    tx_info.Text += i.ToString();
                                    entero = 0;
                                }
                                entero++;
                            }
                            else
                            {
                            }
                        }
                    }
                    tx_info.Text += Environment.NewLine;
                }
                catch (Exception) { }
                //Limite de edad
                try
                {
                    cmd = new SqlCommand($"select edad from eventos where id = {id}", Program.conexion);
                    aux = cmd.ExecuteScalar().ToString();
                    entero = 0;
                    if (aux != "")
                    {
                        tx_info.Text += Environment.NewLine;
                        puntos.Add(new Punto(tx_info.Text.Length-cantidad*3, 14));
                        cantidad++;
                        tx_info.Text += "Limite de edad" + Environment.NewLine;
                        foreach (char i in aux)
                        {
                            if (i != '\n')
                            {
                                if (entero <= 50)
                                {
                                    tx_info.Text += i.ToString();
                                }
                                else
                                {
                                    tx_info.Text += i.ToString();
                                    entero = 0;
                                }
                                entero++;
                            }
                            else
                            {
                            }
                        }
                    }
                    tx_info.Text += Environment.NewLine;
                }
                catch (Exception) { }
                //Pagan a partir
                try
                {
                    cmd = new SqlCommand($"select pagan from eventos where id = {id}", Program.conexion);
                    aux = cmd.ExecuteScalar().ToString();
                    entero = 0;
                    if (aux != "")
                    {
                        tx_info.Text += Environment.NewLine;
                        puntos.Add(new Punto(tx_info.Text.Length-cantidad*3, 24));
                        cantidad++;
                        tx_info.Text += "Pagan boleto a partir de" + Environment.NewLine;
                        foreach (char i in aux)
                        {
                            if (i != '\n')
                            {
                                if (entero <= 50)
                                {
                                    tx_info.Text += i.ToString();
                                }
                                else
                                {
                                    tx_info.Text += i.ToString();
                                    entero = 0;
                                }
                                entero++;
                            }
                            else
                            {
                            }
                        }
                    }
                    tx_info.Text += Environment.NewLine;
                }
                catch (Exception) { }
                //Restricciones
                try
                {
                    cmd = new SqlCommand($"select restricciones from eventos where id = {id}", Program.conexion);
                    aux = cmd.ExecuteScalar().ToString();
                    entero = 0;
                    if (aux != "")
                    {
                        tx_info.Text += Environment.NewLine;
                        puntos.Add(new Punto(tx_info.Text.Length-cantidad*3, 13));
                        cantidad++;
                        tx_info.Text += "Restricciones" + Environment.NewLine;
                        foreach (char i in aux)
                        {
                            if (i != '\n')
                            {
                                if (entero <= 50)
                                {
                                    tx_info.Text += i.ToString();
                                }
                                else
                                {
                                    tx_info.Text += i.ToString();
                                    entero = 0;
                                }
                                entero++;
                            }
                            else
                            {
                            }
                        }
                    }
                    tx_info.Text += Environment.NewLine;
                }
                catch (Exception) { }
                //Duracion
                try
                {
                    cmd = new SqlCommand($"select tiempo from eventos where id = {id}", Program.conexion);
                    aux = cmd.ExecuteScalar().ToString();
                    entero = 0;
                    if (aux != "")
                    {
                        tx_info.Text += Environment.NewLine;
                        puntos.Add(new Punto(tx_info.Text.Length-cantidad*3, 19));
                        cantidad++;
                        tx_info.Text += "Duracion aproximada" + Environment.NewLine;
                        foreach (char i in aux)
                        {
                            if (i != '\n')
                            {
                                if (entero <= 50)
                                {
                                    tx_info.Text += i.ToString();
                                }
                                else
                                {
                                    tx_info.Text += i.ToString();
                                    entero = 0;
                                }
                                entero++;
                            }
                            else
                            {
                            }
                        }
                    }
                    tx_info.Text += Environment.NewLine;
                }
                catch (Exception) { }
                //Discapacidad
                try
                {
                    cmd = new SqlCommand($"select discapacidad from eventos where id = {id}", Program.conexion);
                    aux = cmd.ExecuteScalar().ToString();
                    entero = 0;
                    if (aux != "")
                    {
                        tx_info.Text += Environment.NewLine;
                        puntos.Add(new Punto(tx_info.Text.Length-cantidad*3, 41));
                        cantidad++;
                        tx_info.Text += "Accesibilidad a personas con discapacidad" + Environment.NewLine;
                        foreach (char i in aux)
                        {
                            if (i != '\n')
                            {
                                if (entero <= 50)
                                {
                                    tx_info.Text += i.ToString();
                                }
                                else
                                {
                                    tx_info.Text += i.ToString();
                                    entero = 0;
                                }
                                entero++;
                            }
                            else
                            {
                            }
                        }
                    }
                    tx_info.Text += Environment.NewLine;
                }
                catch (Exception) { }
                //Observaciones
                try
                {
                    cmd = new SqlCommand($"select observaciones from eventos where id = {id}", Program.conexion);
                    aux = cmd.ExecuteScalar().ToString();
                    entero = 0;
                    if (aux != "")
                    {
                        tx_info.Text += Environment.NewLine;
                        puntos.Add(new Punto(tx_info.Text.Length-cantidad*3, 13));
                        cantidad++;
                        tx_info.Text += "Observaciones" + Environment.NewLine;
                        foreach (char i in aux)
                        {
                            if (i != '\n')
                            {
                                if (entero <= 50)
                                {
                                    tx_info.Text += i.ToString();
                                }
                                else
                                {
                                    tx_info.Text += i.ToString();
                                    entero = 0;
                                }
                                entero++;
                            }
                            else
                            {
                            }
                        }
                    }
                    tx_info.Text += Environment.NewLine;
                }
                catch (Exception) { }
                Font bold = new Font("Muli", 13, FontStyle.Bold);
                foreach (Punto i in puntos)
                {
                    tx_info.Select(i.start, i.lenght);
                    tx_info.SelectionFont = bold;
                }
                //FIN
                tx_info.Size = new Size(tx_info.Width, tx_info.Lines.Length * 37);
            }
            catch (Exception) { }

        }

        private string GetMes(DateTime fecha)
        {
            switch (fecha.Month)
            {
                case 1: return "ene";
                case 2: return "feb";
                case 3: return "mar";
                case 4: return "abr";
                case 5: return "may";
                case 6: return "jun";
                case 7: return "jul";
                case 8: return "ago";
                case 9: return "sep";
                case 10: return "oct";
                case 11: return "nov";
                case 12: return "dic";
                default: return "mes";
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Program.eventoDetalle.CerrarVentana();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"select inmueble_id from eventos where id = {id}", Program.conexion);
                Program.eventoDetalle.CerrarActivo();
                Program.eventoDetalle.Hide();
                Program.InmuebleDetalle(Convert.ToInt32(cmd.ExecuteScalar()));
            }
            catch (Exception) { }
        }
    }

    class Punto
    {
        public int start;
        public int lenght;

        public Punto(int start, int lenght)
        {
            this.start = start;
            this.lenght = lenght;
        }
    }
}
