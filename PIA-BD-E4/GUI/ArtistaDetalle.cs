using PIA_BD_E4.Componentes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PIA_BD_E4.GUI
{
    public partial class ArtistaDetalle : Form
    {
        List<CardEvento> cards = new List<CardEvento>();
        List<int> ids = new List<int>();
        int id;
        CardEvento ultimo;

        public ArtistaDetalle(int id)
        {
            InitializeComponent();
            this.id = id;
            OnInit();
        }

        private void VerificarCuenta()
        {
            if (Program.logeado == null)
            {
                btn_cuenta.Text = "Ingresar";
            }
            else
            {
                btn_cuenta.Text = "Mi Cuenta";
            }
        }

        private void OnInit()
        {
            if (Program.logeado != null)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand($"select isAdmin from usuarios where id = {Program.logeado}",Program.conexion);

                    if (cmd.ExecuteScalar().ToString() != "True")
                    {
                        btn_modificar.Visible = false;
                        btn_eliminar.Visible = false;
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                btn_modificar.Visible = false;
                btn_eliminar.Visible = false;
            }
            FormBorderStyle = FormBorderStyle.Sizable;
            CargarInfo();
            CargarImagen();
            CargarEventos();
            VerificarCuenta();
        }

        private void CargarEventos()
        {
            try
            {
                int cantidad;
                SqlCommand cmd = new SqlCommand($"select count(*) from eventos_artistas where artista_id = {id}", Program.conexion);
                lbl_cantidad.Text = cmd.ExecuteScalar().ToString();
                lbl_proximos.Location = new Point(lbl_cantidad.Location.X + lbl_cantidad.Size.Width - 5, 21);
                cantidad = Convert.ToInt16(cmd.ExecuteScalar());

                if (cantidad > 0)
                {
                    panel_fondoGris.Size = new Size(panel_fondoGris.Size.Width, 60);
                    cmd = new SqlCommand($"select id from eventos_artistas join eventos on eventos.id = eventos_artistas.evento_id and eventos_artistas.artista_id={id} order by fecha_inicio", Program.conexion);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Se leen todos los registros de la consulta
                        while (reader.Read())
                        {
                            //Se crea el nuevo card
                            ids.Add(Convert.ToInt16(reader["id"]));
                        }
                        reader.Close();
                    }
                }

                CardEvento aux;
                foreach (int id in ids)
                {
                    aux = new CardEvento(id,true);
                    //Se agrega el card a la pantalla
                    Controls.Add(aux);

                    //Se trae al frente
                    aux.BringToFront();

                    //Se agrega a la lista
                    cards.Add(aux);

                    //Si es el primer card que se agrega se pone en 40,190
                    if (ids.IndexOf(id) == 0)
                    {
                        aux.Location = new Point(40, 420);
                    }
                    //Si no se pone despues del ultimo
                    else
                    {
                        aux.Location = new Point(40, ultimo.Location.Y + ultimo.Size.Height);
                    }
                    //Se actualza el ultimo
                    ultimo = aux;
                }
                if (cantidad > 0)
                {
                    //Se actualiza la posicion del panel final
                    panel_final.Location = new Point(40, ultimo.Location.Y + ultimo.Size.Height);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse con la base de datos+\n"+ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void CargarInfo()
        {
            try
            {
                string nombre;
                SqlCommand cmd = new SqlCommand($"select nombre from artistas where id = {id}", Program.conexion);
                nombre = cmd.ExecuteScalar().ToString();
                lbl_acerca.Text = $"Acerca de {nombre}";
                lbl_nombre.Text = "Boletos para " + nombre;
                label2.Text = nombre;
                cmd = new SqlCommand($"select biografia from artistas where id = {id}", Program.conexion);
                string bio = cmd.ExecuteScalar().ToString();

                int aux = 0;
                foreach(char i in bio)
                {
                    if (i != '\n')
                    {
                        if (aux <= 200)
                        {
                            Info.Text += i.ToString();
                        }
                        else
                        {
                            Info.Text += i.ToString();
                            aux = 0;
                        }
                        aux++;
                    }
                    else
                    {
                    }
                }

                int lineas = bio.Length / 200 +1;
                Info.Size = new Size(Info.Size.Width, lineas * 25);
                panel_blanco.Size = new Size(1819, Info.Size.Height + 43);
            }
            catch (Exception) { }
        }

        private void CargarImagen()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select imagen from artistas where id = " + id, Program.conexion);

                byte[] imageData = (byte[])(cmd.ExecuteScalar());
                Image newImage;
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);
                    newImage = Image.FromStream(ms, true);
                }
                foto.BackgroundImage = newImage;

            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eventos_Click(object sender, EventArgs e)
        {
            eventos.ForeColor = Color.White;
            btn_info.ForeColor = Color.FromArgb(182, 204, 228);
            lbl_acerca.Visible = false;
            lineaEventos.Visible = true;
            lineaInfo.Visible = false;
            panel_blanco.Visible = false;
            Info.Visible = false;
            lbl_cantidad.Visible = true;
            lbl_proximos.Visible = true;
            foreach (CardEvento i in cards)
            {
                i.Visible = true;
            }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            btn_info.ForeColor = Color.White;
            eventos.ForeColor = Color.FromArgb(182, 204, 228);
            lbl_acerca.Visible = true;
            lineaInfo.Visible = true;
            lineaEventos.Visible = false;
            panel_blanco.Visible = true;
            Info.Visible = true;
            panel_final.Visible = false;
            lbl_cantidad.Visible = false;
            lbl_proximos.Visible = false;
            foreach (CardEvento i in cards)
            {
                i.Visible = false;
            }
        }

        private void ArtistaDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.actual == this)
            {
                Application.Exit();
            }
        }

        private void btn_inmuebles_Click(object sender, EventArgs e)
        {
            Program.InmueblesLista();
            this.Hide();
        }

        private void btn_artistas_Click(object sender, EventArgs e)
        {
            Program.ArtistasLista();
            this.Hide();
        }

        private void btn_eventos_Click(object sender, EventArgs e)
        {
            Program.EventosLista(0);
            this.Hide();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro de que desea modificar este artista?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                AgregarArtista ventana = new AgregarArtista(id);
                ventana.ShowDialog();
                Program.ArtistaDetalle(id);
                Hide();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro de que desea modificar este evento?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand($"select count(*) from eventos_artistas where artista_id = {id}", Program.conexion);
                int aux = Convert.ToInt32(cmd.ExecuteScalar());
                if (aux > 0)
                {
                    MessageBox.Show("No se puede eliminar este artista porque se encuentra en el cartel de algún evento, " +
                        "asegurese de que el evento haya sido eliminado antes de eliminar al artista", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand($"delete from artistas where id = {id}", Program.conexion);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("El artista se ha eliminado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Program.ArtistasLista();
                Hide();
            }
        }

        private void btn_cuenta_Click(object sender, EventArgs e)
        {
            if(Program.logeado == null)
            {
                Program.AbrirLogin();
                if (Program.logeado != null)
                {
                    this.Hide();
                    Program.ArtistaDetalle(id);
                }
            }
            else
            {
                this.Hide();
                Program.AbrirCuenta();
            }
        }
    }
}
