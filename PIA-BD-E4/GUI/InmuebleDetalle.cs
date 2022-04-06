using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;
using PIA_BD_E4.Componentes;
using System.Collections.Generic;
using System.IO;

namespace PIA_BD_E4.GUI
{
    public partial class InmuebleDetalle : Form
    {
        List<CardEvento> cards = new List<CardEvento>();
        List<int> ids = new List<int>();
        int id;
        CardEvento ultimo;

        public InmuebleDetalle(int id)
        {
            this.id = id;
            InitializeComponent();
            OnInit();
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
                        btn_eliminar.Visible = false;
                    }
                }
                catch (Exception) { }
            }
            else
            {
                btn_modificar.Visible = false;
                btn_eliminar.Visible = false;
            }
            VerificarCuenta();
            FormBorderStyle = FormBorderStyle.Sizable;
            CargarInfo();
            CargarImagen();
            CargarDireccion();
            CargarEventos();
            Botones();
            try
            {
                lbl_nombre.Text = "Boletos para "+(new SqlCommand("select nombre from inmuebles where id =" + id.ToString(), Program.conexion).ExecuteScalar().ToString());
            }
            catch (Exception) { }
        }

        private void Botones()
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"select url from inmuebles where id = {id}", Program.conexion);
                if (cmd.ExecuteScalar().ToString() != "")
                {

                }
                else
                {
                    btn_comoLlegar.Visible = false;
                    btn_eliminar.Location = btn_modificar.Location;
                    btn_modificar.Location = btn_comoLlegar.Location;
                }
            }
            catch (Exception)
            {

            }
        }

        private void CargarEventos()
        {
            try
            {
                int cantidad;
                SqlCommand cmd = new SqlCommand($"select count(*) from eventos where inmueble_id = {id}", Program.conexion);
                lbl_cantidad.Text = cmd.ExecuteScalar().ToString();
                lbl_proximos.Location = new Point(lbl_cantidad.Location.X + lbl_cantidad.Size.Width - 5, 21);
                cantidad = Convert.ToInt16(cmd.ExecuteScalar());

                if (cantidad > 0)
                {
                    panel_fondoGris.Size = new Size(panel_fondoGris.Size.Width, 60);
                    cmd = new SqlCommand($"select * from eventos where inmueble_id = {id} order by fecha_inicio", Program.conexion);
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
                        aux.Location = new Point(40, 500);
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
            catch (Exception)
            {
                MessageBox.Show("Error al conectarse con la base de datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void CargarDireccion()
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"select calle from inmuebles where id ={id}",Program.conexion);
                lbl_direccion.Text = cmd.ExecuteScalar().ToString() + " ";

                cmd = new SqlCommand($"select numero from inmuebles where id ={id}", Program.conexion);
                if (Convert.ToInt16(cmd.ExecuteScalar()) != 0)
                {
                    lbl_direccion.Text += cmd.ExecuteScalar().ToString() + " Col ";
                }
                else
                {
                    lbl_direccion.Text += "s/n Col ";
                }
                cmd = new SqlCommand($"select colonia from inmuebles where id = {id}", Program.conexion);
                lbl_direccion.Text += cmd.ExecuteScalar().ToString()+", ";

                cmd = new SqlCommand($"select ciudad_id from inmuebles where id = {id}",Program.conexion);
                string aux = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select nombre from ciudades where id={aux}",Program.conexion);
                lbl_direccion.Text += cmd.ExecuteScalar().ToString()+", ";

                cmd = new SqlCommand($"select estado_id from inmuebles where id = {id}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select abreviacion from estados where id={aux}", Program.conexion);
                lbl_direccion.Text += cmd.ExecuteScalar().ToString() + " ";

                cmd = new SqlCommand($"select codigo_postal from inmuebles where id = {id}", Program.conexion);
                lbl_direccion.Text += cmd.ExecuteScalar().ToString()+", ";

                cmd = new SqlCommand($"select pais_id from inmuebles where id = {id}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select nombre from paises where id={aux}", Program.conexion);
                lbl_direccion.Text += cmd.ExecuteScalar().ToString() + " ";
            }
            catch (Exception){}
        }

        private void CargarImagen()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select imagen from inmuebles where id = " + id, Program.conexion);

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

        private void CargarInfo()
        {
            
            List<Punto> puntos = new List<Punto>();

            SqlCommand cmd;
            string aux;
            int index;
            Font bold = new Font("Muli SemiBold",14,FontStyle.Regular);
            //Direcciones
            try
            {
                cmd = new SqlCommand($"select referencias from inmuebles where id = {id}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();
                if (aux != "")
                {
                    index = Info.Text.Length;
                    Info.Text +="Referencias de dirección" + Environment.NewLine;
                    Info.Text += aux + Environment.NewLine;
                    puntos.Add(new Punto(0, Info.Lines[Info.GetLineFromCharIndex(index)].Length+1));
                }
            }
            catch (Exception){}
            //Estacionamiento
            try
            {
                cmd = new SqlCommand($"select estacionamiento from inmuebles where id = {id}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();
                if (aux != "")
                {
                    Info.Text += Environment.NewLine;
                    index = Info.Text.Length;
                    Info.Text += "Estacionamiento" + Environment.NewLine;
                    Info.Text += aux + Environment.NewLine;
                    puntos.Add(new Punto(index, Info.Lines[Info.GetLineFromCharIndex(index)].Length));
                }
            }
            catch (Exception) { }
            //Numeros de oficina
            try
            {
                cmd = new SqlCommand($"select telefono from inmuebles where id = {id}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();
                if (aux != "")
                {
                    Info.Text += Environment.NewLine;
                    index = Info.Text.Length;
                    Info.Text += "Teléfono(s) de la oficina" + Environment.NewLine;
                    Info.Text += aux + Environment.NewLine;
                    puntos.Add(new Punto(index, Info.Lines[Info.GetLineFromCharIndex(index)].Length));
                }
            }
            catch (Exception) { }
            //Horario
            try
            {
                cmd = new SqlCommand($"select horario from inmuebles where id = {id}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();
                if (aux != "")
                {
                    Info.Text += Environment.NewLine;
                    index = Info.Text.Length;
                    Info.Text += "Horario de atención de la oficina" + Environment.NewLine;
                    Info.Text += aux + Environment.NewLine;
                    puntos.Add(new Punto(index, Info.Lines[Info.GetLineFromCharIndex(index)].Length));
                }
            }
            catch (Exception) { }
            //Reglas
            try
            {
                cmd = new SqlCommand($"select reglas from inmuebles where id = {id}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();
                if (aux != "")
                {
                    Info.Text += Environment.NewLine;
                    index = Info.Text.Length;
                    Info.Text += "Reglas generales" + Environment.NewLine;
                    Info.Text += aux + Environment.NewLine;
                    puntos.Add(new Punto(index, Info.Lines[Info.GetLineFromCharIndex(index)].Length));
                }
            }
            catch (Exception) { }
            //Extra
            try
            {
                cmd = new SqlCommand($"select miscelaneo from inmuebles where id = {id}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();
                if (aux != "")
                {
                    Info.Text += Environment.NewLine;
                    index = Info.Text.Length;
                    Info.Text += "Información extra" + Environment.NewLine;
                    Info.Text += aux + Environment.NewLine;
                    puntos.Add(new Punto(index, 17));
                }
            }
            catch (Exception) { }

            foreach(Punto i in puntos)
            {
                Info.Select(i.start, i.lenght);
                Info.SelectionFont= bold;
            }

            Info.Size = new Size(Info.Size.Width, Info.Lines.Length * 23);
            panel_blanco.Size = new Size(1823, Info.Size.Height + 60);
        }

        #region Boton de Busqueda
        //Cuando se selecciona el cuadro de texto buscar
        private void tx_buscar_Enter(object sender, System.EventArgs e)
        {
            btn_buscar.FillColor = SystemColors.ControlLightLight;
            btn_buscar.Image = System.Drawing.Image.FromFile(@"D:\Proyectos VS\PIA-BD-E4\PIA-BD-E4\Resources\icono_buscarAzul.png");
        }

        //Cuando se sale del cuadro de texto de buscar
        private void tx_buscar_Leave(object sender, System.EventArgs e)
        {
            if (tx_buscar.Text != "")
            {
                tx_buscar.ForeColor = SystemColors.ControlLightLight;
            }
            btn_buscar.Image = System.Drawing.Image.FromFile(@"D:\Proyectos VS\PIA-BD-E4\PIA-BD-E4\Resources\icono_buscar.png");
            btn_buscar.FillColor = Color.FromArgb(33, 122, 220);
        }

        //Cuando el mouse esté encima del boton de buscar
        private void btn_buscar_MouseEnter(object sender, System.EventArgs e)
        {
            //En cualquiera de los dos casos se usa este color
            btn_buscar.Image = System.Drawing.Image.FromFile(@"D:\Proyectos VS\PIA-BD-E4\PIA-BD-E4\Resources\icono_buscar.png");
            btn_buscar.FillColor = Color.FromArgb(2, 90, 185);
        }

        //Cuando el mouse salga del boton de buscar
        private void btn_buscar_MouseLeave(object sender, System.EventArgs e)
        {
            //Si el cuadro de texto esta focused
            if (tx_buscar.Focused)
            {
                btn_buscar.FillColor = SystemColors.ControlLightLight;
                btn_buscar.Image = System.Drawing.Image.FromFile(@"D:\Proyectos VS\PIA-BD-E4\PIA-BD-E4\Resources\icono_buscarAzul.png");
            }
            else
            {
                btn_buscar.FillColor = System.Drawing.Color.FromArgb(33, 122, 220);
            }
        }
        #endregion

        private void InmuebleDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.actual == this)
            {
                Application.Exit();
            }
        }

        private void btn_inmuebles_Click(object sender, EventArgs e)
        {
            Program.InmueblesLista();
            Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AgregarInmueble ventana = new AgregarInmueble(id);
            ventana.ShowDialog();
            Program.actual = new InmuebleDetalle(id);
            Program.actual.Show();
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select count(*) from eventos where inmueble_id = "+id.ToString(),Program.conexion);
                if (cmd.ExecuteScalar().ToString() == "0")
                {
                    DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este inmueble?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(result == DialogResult.Yes)
                    {
                        cmd = new SqlCommand($"delete from inmuebles where id = {id}", Program.conexion);
                        cmd.ExecuteNonQuery();
                        Program.inmuebles = new InmueblesLista();
                        Program.actual = Program.inmuebles;
                        Program.actual.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show($"No se pueden eliminar el inmueble porque hay {cmd.ExecuteScalar()} eventos proximos en este recinto","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception) { }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            eventos.ForeColor = Color.White;
            btn_info.ForeColor = Color.FromArgb(182, 204, 228);
            lineaEventos.Visible = true;
            lineaInfo.Visible = false;
            panel_blanco.Visible = false;
            Info.Visible = false;
            panel_fondoGris.Visible = true;
            lbl_cantidad.Visible = true;
            lbl_proximos.Visible = true;
            foreach(CardEvento i in cards)
            {
                i.Visible = true;
            }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            btn_info.ForeColor = Color.White;
            eventos.ForeColor = Color.FromArgb(182, 204, 228);
            lineaInfo.Visible = true;
            lineaEventos.Visible = false;
            panel_blanco.Visible = true;
            Info.Visible = true;
            panel_final.Visible = false;
            panel_fondoGris.Visible = false;
            lbl_cantidad.Visible = false;
            lbl_proximos.Visible = false;
            foreach (CardEvento i in cards)
            {
                i.Visible = false;
            }
        }

        private void btn_comoLlegar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select url from inmuebles where id = " + id.ToString(), Program.conexion);
                System.Diagnostics.Process.Start(cmd.ExecuteScalar().ToString());
            }
            catch (Exception) {}
        }

        private void btn_artistas_Click(object sender, EventArgs e)
        {
            Program.ArtistasLista();
            Hide();
        }

        private void btn_eventos_Click(object sender, EventArgs e)
        {
            Program.EventosLista(0);
            this.Hide();
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

        private void btn_cuenta_Click(object sender, EventArgs e)
        {
            if (Program.logeado == null)
            {
                Program.AbrirLogin();
                if (Program.logeado != null)
                {
                    this.Hide();
                    Program.InmuebleDetalle(id);
                }
            }
            else
            {
                this.Hide();
                Program.AbrirCuenta();
            }
        }

    }

    class Punto
    {
        public int start;
        public int lenght;

        public Punto(int start,int lenght)
        {
            this.start = start;
            this.lenght = lenght;
        }
    }
}
