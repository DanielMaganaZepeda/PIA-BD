using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;
using PIA_BD_E4.Componentes;
using System.Collections.Generic;

namespace PIA_BD_E4.GUI
{
    public partial class ArtistasLista : Form
    {
        List<CardArtista> cards = new List<CardArtista>();
        List<int> ids = new List<int>();
        CardArtista ultimo;

        public ArtistasLista()
        {
            InitializeComponent();
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

        public void CargarLista()
        {
            try
            {   
                SqlCommand cmd = new SqlCommand("select * from artistas order by nombre",Program.conexion);

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
                CardArtista aux;
                foreach (int id in ids)
                {
                    aux = new CardArtista(id);
                    //Se agrega el card a la pantalla
                    Controls.Add(aux);

                    //Se trae al frente
                    aux.BringToFront();

                    //Se agrega a la lista
                    cards.Add(aux);

                    //Si es el primer card que se agrega se pone en 40,190
                    if (ids.IndexOf(id) == 0)
                    {
                        aux.Location = new Point(40, 289);
                    }
                    //Si no se pone despues del ultimo
                    else
                    {
                        aux.Location = new Point(40, ultimo.Location.Y + ultimo.Size.Height);
                    }
                    //Se actualza el ultimo
                    ultimo = aux;
                }

                if(cards.Count>0)
                //Se actualiza la posicion del panel final
                panel_final.Location = new Point(40, ultimo.Location.Y + ultimo.Size.Height);

                //Se actualiza la cantidad de inmuebles que hay
                lbl_cantidad.Text = cards.Count.ToString();
                lbl_inmuebles.Location = new Point(lbl_cantidad.Location.X + lbl_cantidad.Size.Width - 5, 20);

                //Se actualiza el tamaño (estetica)
                //Si no hay inmuebles elcard es tamano 60 de alto
                if(cards.Count == 0)
                {
                    panel_fondoGris.Size = new Size(1819, 60);
                }
                //Si hay inmuebles se hace de 70 para que no se vea el border radious
                else
                {
                    panel_fondoGris.Size = new Size(1819, 70);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnInit()
        {
            try
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
                VerificarCuenta();
                FormBorderStyle = FormBorderStyle.Sizable;
                CargarLista();
            }
            catch (Exception) {
                MessageBox.Show("Error al conectarse con la base de datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
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

        //Agregar un inmueble
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro de que desea registrar un artista?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(resultado == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("select count(*) from artistas", Program.conexion);
                int aux = Convert.ToInt16(cmd.ExecuteScalar());
                AgregarArtista ventana = new AgregarArtista();
                ventana.ShowDialog();
                if (aux != Convert.ToInt16(cmd.ExecuteScalar()))
                {
                    this.Hide();
                    Program.ArtistasLista();
                }
            }
        }

        private void InmueblesLista_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_inmuebles_Click(object sender, EventArgs e)
        {
            Program.InmueblesLista();
            Hide();
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

        private void btn_cuenta_Click(object sender, EventArgs e)
        {
            if (Program.logeado == null)
            {
                Program.AbrirLogin();
                if (Program.logeado != null)
                {
                    this.Hide();
                    Program.ArtistasLista();
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
