using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using PIA_BD_E4.GUI;

namespace PIA_BD_E4.Componentes
{
    public partial class CardArtista : UserControl
    {
        int id;
        public  CardArtista(int id)
        {
            InitializeComponent();
            this.id = id;
            OnInit();
        }

        private void OnInit()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select nombre from artistas where id = " + id,Program.conexion);
                lbl_nombre.Text = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand("select count(*) from eventos_artistas where artista_id=" + id, Program.conexion);
                lbl_cantidad.Text = cmd.ExecuteScalar().ToString() + " Eventos próximos";

                try
                {
                    cmd = new SqlCommand("select imagen from artistas where id = " + id, Program.conexion);

                    byte[] imageData = (byte[])(cmd.ExecuteScalar());
                    Image newImage;
                    using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                    {
                        ms.Write(imageData, 0, imageData.Length);
                        newImage = Image.FromStream(ms, true);
                    }
                    foto.BackgroundImage = newImage;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(Exception)
            {
            }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Program.ArtistaDetalle(id);
            Program.artistas.Hide();
        }
    }
}
