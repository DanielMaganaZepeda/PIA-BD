using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;
using PIA_BD_E4.Componentes;
using System.Collections.Generic;

namespace PIA_BD_E4.GUI
{
    public partial class EventosLista : Form
    {
        List<CardEvento> cards = new List<CardEvento>();
        List<int> ids = new List<int>();
        CardEvento ultimo;
        int modoActual;

        public EventosLista(int categoria)
        {
            InitializeComponent();
            OnInit(categoria);
            modoActual = categoria;
        }

        public void CargarLista(int categoria)
        {
            try
            {
                SqlCommand cmd;
                if (categoria == 0)
                {
                    cmd = new SqlCommand("select * from eventos order by fecha_inicio", Program.conexion);
                    lbl_tipo.Text = "Todos los eventos";
                }
                else
                {
                    cmd = new SqlCommand($"select nombre from tipos where id = {categoria}", Program.conexion);
                    lbl_tipo.Text = cmd.ExecuteScalar().ToString();
                    cmd = new SqlCommand($"select * from eventos where tipo_id = {categoria} order by fecha_inicio", Program.conexion);
                }

                //Se ejecuta el comando
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

                //aux solo almacenara la card mientras se agrega a la lista
                CardEvento aux;
                foreach (int id in ids)
                {
                    aux = new CardEvento(id,false);
                    //Se agrega el card a la pantalla
                    Controls.Add(aux);

                    //Se trae al frente
                    aux.BringToFront();

                    //Se agrega a la lista
                    cards.Add(aux);

                    //Si es el primer card que se agrega se pone en 40,190
                    if (ids.IndexOf(id) == 0)
                    {
                        aux.Location = new Point(405, 289);
                    }
                    //Si no se pone despues del ultimo
                    else
                    {
                        aux.Location = new Point(405, ultimo.Location.Y + ultimo.Size.Height);
                    }
                    //Se actualza el ultimo
                    ultimo = aux;
                }

                if (cards.Count > 0)
                {
                    //Se actualiza la posicion del panel final
                    panel_final.Location = new Point(405, ultimo.Location.Y + ultimo.Size.Height);

                    lbl_cantidad.Text = cards.Count.ToString();
                    lbl_proximos.Location = new Point(lbl_cantidad.Location.X + lbl_cantidad.Size.Width - 5, 21);

                    panel_fondoGris.Size = new Size(1469, 70);
                }
                else
                {
                    lbl_cantidad.Text = "0";
                    panel_fondoGris.Size = new Size(1469, 60);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void OnInit(int categoria)
        {
            if (Program.logeado != null)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand($"select isAdmin from usuarios where id = {Program.logeado}", Program.conexion);
                    if (cmd.ExecuteScalar().ToString() != "True")
                    {
                        btn_agregar.Visible = false;
                    }
                }
                catch (Exception) { }
            }
            else
            {
                btn_agregar.Visible = false;
            }
            FormBorderStyle = FormBorderStyle.Sizable;
            try
            {
                VerificarCuenta();
                CargarLista(categoria);              
            }
            catch (Exception) {
                MessageBox.Show("Error al conectarse con la base de datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        //Boton de cerrar
        private void btn_cerrar_Click(object sender, System.EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que de sea cerrar la aplicación?","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Boton de minimizar
        private void btn_minimizar_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private void btn_eventos_Click(object sender, EventArgs e)
        {
            Program.EventosLista(0);
            this.Hide();
        }

        private void EventosLista_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int aux;
            Program.listaArtistas = new AgregarListaArtistas();
            var resultado = MessageBox.Show("¿Está seguro de que desea registrar un evento?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Select count (*) from eventos", Program.conexion);
                    aux = Convert.ToInt16(cmd.ExecuteScalar());
                }
                catch (Exception) { }
                AgregarEvento ventana = new AgregarEvento();
                ventana.ShowDialog();
                try
                {
                    SqlCommand cmd = new SqlCommand("Select count (*) from eventos", Program.conexion);
                    aux = Convert.ToInt16(cmd.ExecuteScalar());
                    if (aux != Convert.ToInt16(cmd.ExecuteScalar()))
                    {
                        Program.EventosLista(modoActual);
                    }
                }
                catch (Exception) { }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AgregarListaArtistas ventana = new AgregarListaArtistas();
            ventana.ShowDialog();
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            Program.EventosLista(0);
            this.Hide();
        }

        private void btn_conciertos_Click(object sender, EventArgs e)
        {
            Program.EventosLista(1);
            this.Hide();
        }

        private void btn_teatro_Click(object sender, EventArgs e)
        {
            Program.EventosLista(2);
            this.Hide();
        }

        private void btn_deportes_Click(object sender, EventArgs e)
        {
            Program.EventosLista(3);
            this.Hide();
        }

        private void btn_familiares_Click(object sender, EventArgs e)
        {
            Program.EventosLista(4);
            this.Hide();
        }

        private void btn_especiales_Click(object sender, EventArgs e)
        {
            Program.EventosLista(5);
            this.Hide();
        }


        private void btn_cuenta_Click(object sender, EventArgs e)
        {
            if (Program.logeado == null)
            {
                Program.AbrirLogin();
                if (Program.logeado != null)
                {
                    this.Hide();
                    Program.EventosLista(modoActual);
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
