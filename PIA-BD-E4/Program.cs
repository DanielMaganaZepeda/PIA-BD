using PIA_BD_E4.GUI;
using System;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Data.SqlClient;
using PIA_BD_E4.Componentes;
using System.Drawing;

namespace PIA_BD_E4
{
    static class Program
    {
        public static string logeado;

        public static Form actual;
        public static SqlConnection conexion = new SqlConnection();

        public static Login login;
        public static Registrarse registrarse;
        public static MiCuenta miCuenta;

        public static InmueblesLista inmuebles;
        public static InmuebleDetalle inmuebleDetalle;

        public static ArtistasLista artistas;
        public static ArtistaDetalle artistaDetalle;

        public static EventosLista eventos;
        public static EventoDetalle eventoDetalle;
        public static AgregarListaArtistas listaArtistas;

        [STAThread]
        static void Main()
        {
            logeado = null;
            conexion.ConnectionString = "server=localhost ; database=Ticketmaster ; integrated security=true";
            Program.conexion.Open();
            PrivateFontCollection font = new PrivateFontCollection();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            eventos = new EventosLista(0);
            actual = eventos;
            actual.Show();

            Application.Run(actual);
        }
        public static void CargarBoletos(string venta_id)
        {
            BoletosDigitales ventana = new BoletosDigitales(venta_id);
            ventana.ShowDialog();
            ventana.Dispose();
        }
        public static void Deslogear()
        {
            Program.logeado = null;
            eventos = new EventosLista(0);
            actual = eventos;
            actual.Show();
        }
        public static void AbrirCuenta()
        {
            miCuenta = new MiCuenta();
            actual = miCuenta;
            actual.Show();
        }
        
        public static void AbrirLogin()
        {
            login = new Login();
            actual = login;
            actual.ShowDialog();
        }
        public static void AbrirRegistrarse()
        {
            registrarse = new Registrarse();
            actual = registrarse;
            actual.ShowDialog();
        }
        public static void Logear(string id)
        {
            logeado = id;
        }
        public static void EventoDetalle(int id)
        {
            eventoDetalle = new EventoDetalle(id);
            actual = eventoDetalle;
            actual.Show();
        }
        public static void EventosLista(int categoria)
        {
            eventos = new EventosLista(categoria);
            actual = eventos;
            actual.Show();
        }

        public static void InmueblesLista()
        {
            inmuebles = new InmueblesLista();
            actual = inmuebles;
            actual.Show();
        }

        public static void ArtistasLista()
        {
            artistas = new ArtistasLista();
            actual = artistas;
            actual.Show();
        }

        public static void InmuebleDetalle(int id)
        {
            inmuebleDetalle = new InmuebleDetalle(id);
            actual = inmuebleDetalle;
            actual.Show();
        }

        public static void ArtistaDetalle(int id)
        {
            artistaDetalle = new ArtistaDetalle(id);
            actual = artistaDetalle;
            actual.Show();
        }
    }
}