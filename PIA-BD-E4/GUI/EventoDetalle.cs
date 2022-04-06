using PIA_BD_E4.Componentes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PIA_BD_E4.GUI
{
    public partial class EventoDetalle : Form
    {
        int id;
        List<CardLocalidad> cards = new List<CardLocalidad>();
        CardLocalidad ultimo;
        int cantidad = 2;

        Info info;

        UserControl activo;
        bool visible = false;

        Boletos boletos;

        public EventoDetalle(int id)
        {
            InitializeComponent();
            this.id = id;
            OnInit();
        }
        public void AbrirInfo()
        {
            activo = info;
            reloj.Start();
        }
        public void AbrirBoletos(int localidad_id)
        {
            if(activo!=null)
            activo.Dispose();
            boletos = new Boletos(localidad_id, cantidad);
            Controls.Add(boletos);
            activo = boletos;
            boletos.BringToFront();
            boletos.Location = new Point(1920, 210);
            reloj.Start();
        }
        public void CerrarVentana()
        {
            reloj.Start();
        }

        private void OnInit()
        {
            if (Program.logeado != null)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand($"select isAdmin from usuarios where id = {Program.logeado}", Program.conexion);
                    if (cmd.ExecuteScalar().ToString() != "True")
                    {
                        btn_modificar.Visible = false;
                        guna2Button2.Visible = false;
                    }
                }
                catch (Exception) { }
            }
            else
            {
                btn_modificar.Visible = false;
                guna2Button2.Visible = false;
            }
            try
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                string aux;
                DateTime fecha;
                SqlCommand cmd = new SqlCommand($"select tipo_id from eventos where id = {id}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select nombre from tipos where id = {aux}", Program.conexion);
                lbl_categoria.Text = cmd.ExecuteScalar().ToString();
                lbl_guion.Location = new Point(lbl_categoria.Location.X+lbl_categoria.Size.Width - 5, lbl_guion.Location.Y);
                cmd = new SqlCommand($"select nombre from eventos where id = {id}", Program.conexion);
                lbl_evento.Text = cmd.ExecuteScalar().ToString();
                lbl_evento.Location = new Point(lbl_guion.Location.X+lbl_guion.Size.Width-5,lbl_evento.Location.Y);
                lbl_evento2.Text = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select fecha_inicio from eventos where id = {id}", Program.conexion);
                fecha = (DateTime.Parse(cmd.ExecuteScalar().ToString()));
                lbl_info.Text = GetDia(fecha) + ". " + fecha.Day.ToString() + " " + GetMes(fecha) + " " + fecha.Year.ToString() + " @ ";
                lbl_info.Text += fecha.ToString("HH") + ":" + fecha.ToString("mm") + " ";
                if (fecha.Hour >= 12) lbl_info.Text += "p. m. | ";
                else lbl_info.Text += "a. m. | ";
                cmd = new SqlCommand($"select inmueble_id from eventos where id = {id}",Program.conexion);
                aux = cmd.ExecuteScalar().ToString(); //aux tiene inmueble_id
                cmd = new SqlCommand($"select nombre from inmuebles where id = {aux}",Program.conexion);
                lbl_info.Text += cmd.ExecuteScalar().ToString()+", ";
                cmd = new SqlCommand($"select ciudad_id from inmuebles where id = {aux}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();//aux trae ciudad_id
                cmd = new SqlCommand($"select nombre from ciudades where id = {aux}", Program.conexion);
                lbl_info.Text += cmd.ExecuteScalar().ToString()+", ";
                cmd = new SqlCommand($"select inmueble_id from eventos where id = {id}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();//aux trae inmueble_id
                cmd = new SqlCommand($"select estado_id from inmuebles where id = {aux}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();//aux trae estado_id
                cmd = new SqlCommand($"select abreviacion from estados where id = {aux}",Program.conexion);
                lbl_info.Text += cmd.ExecuteScalar().ToString();
                CargarImagen();

                cmd = new SqlCommand($"select id from localidades where evento_id = {id} order by precio", Program.conexion);
                
                CardLocalidad aux2;
                List<int> ids = new List<int>();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ids.Add(Convert.ToInt16(reader["id"]));
                    }
                    reader.Close();
                }
                foreach(int id in ids)
                {
                    aux2 = new CardLocalidad(id);
                    panel_localidades.Controls.Add(aux2);
                    cards.Add(aux2);
                }
                int i = 0;
                foreach(CardLocalidad card in cards)
                {
                    card.BringToFront();
                    if (i == 0)
                    {
                        card.Location = new Point(4, 78);
                    }
                    else
                    {
                        card.Location = new Point(4, ultimo.Location.Y + ultimo.Size.Height+1);
                    }
                    ultimo = card;
                    i++;
                }
                info = new Info(id);
                Controls.Add(info);
                info.BringToFront();
                info.Location = new Point(1920, 210);
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

        private void CargarImagen()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select imagen from eventos where id = " + id, Program.conexion);

                byte[] imageData = (byte[])(cmd.ExecuteScalar());
                Image newImage;
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);
                    newImage = Image.FromStream(ms, true);
                }
                pic_imagen.BackgroundImage = newImage;

                cmd = new SqlCommand("select imagen_localidades from eventos where id = " + id, Program.conexion);

                imageData = (byte[])(cmd.ExecuteScalar());
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);
                    newImage = Image.FromStream(ms, true);
                }
                pic_mapa.BackgroundImage = newImage;

            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CerrarActivo()
        {
            activo.Dispose();
        }
        private void btn_atras_Click(object sender, EventArgs e)
        {
            Program.EventosLista(0);
            this.Hide();
        }

        private void EventoDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Program.actual == this)
            {
                Application.Exit();
            }
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            cantidad--;
            lbl_cantidad.Text = cantidad.ToString();
            if (cantidad == 1)
            {
                btn_menos.Enabled = false;
            }
            btn_mas.Enabled = true;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            cantidad++;
            lbl_cantidad.Text = cantidad.ToString();
            if (cantidad==8)
            {
                btn_mas.Enabled = false;
            }
            btn_menos.Enabled = true;
        }

        private void relojBoletos_Tick(object sender, EventArgs e)
        {
            if (visible)
            {
                if (activo.Location.X <= 1920)
                {
                    activo.Location = new Point(activo.Location.X + 90, activo.Location.Y);
                }
                else
                {
                    reloj.Stop();
                    visible = false;
                }
            }
            else
            {
                if(activo.Location.X > 1270)
                {
                    activo.Location = new Point(activo.Location.X - 30, activo.Location.Y);
                }
                else
                {
                    reloj.Stop();
                    visible = true;
                }
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro de que desea modificar este evento?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                Program.listaArtistas = new AgregarListaArtistas(id);
                AgregarEvento ventana = new AgregarEvento(id);
                ventana.ShowDialog();
                Program.EventoDetalle(id);
                Hide();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro de que desea eliminar este evento?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                List<string> ids = new List<string>();
                SqlCommand cmd = new SqlCommand($"select id from localidades where evento_id={id}", Program.conexion);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ids.Add(reader["id"].ToString());
                    }
                }
                foreach(string localidad_id in ids)
                {
                    cmd = new SqlCommand($"delete from localidades_asientos where localidad_id = {localidad_id}", Program.conexion);
                    cmd.ExecuteNonQuery();
                }
                foreach(string localidad_id in ids)
                {
                    cmd = new SqlCommand($"delete from localidades where id = {localidad_id}", Program.conexion);
                    cmd.ExecuteNonQuery();
                }
                ids = new List<string>();
                cmd = new SqlCommand($"select artista_id from eventos_artistas where evento_id = {id}", Program.conexion);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ids.Add(reader["artista_id"].ToString());
                    }
                }
                foreach(string artista_id in ids)
                {
                    cmd = new SqlCommand($"delete from eventos_artistas where artista_id = {artista_id}", Program.conexion);
                    cmd.ExecuteNonQuery();
                }
                cmd = new SqlCommand($"delete from eventos where id = {id}", Program.conexion);
                cmd.ExecuteNonQuery();

                MessageBox.Show("El evento se ha eliminado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Program.EventosLista(0);
                this.Hide();
            }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            AbrirInfo();
        }
    }
}
