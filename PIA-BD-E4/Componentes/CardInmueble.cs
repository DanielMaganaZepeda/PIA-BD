using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using PIA_BD_E4.GUI;

namespace PIA_BD_E4.Componentes
{
    public partial class CardInmueble : UserControl
    {
        int id;
        public  CardInmueble(int id)
        {
            InitializeComponent();
            this.id = id;
            OnInit();
        }

        private void OnInit()
        {
            try
            {
                
                int aux;

                SqlCommand cmd = new SqlCommand("select nombre from inmuebles where id = " + id,Program.conexion);
                lbl_nombre.Text = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand("select calle from inmuebles where id =" + id, Program.conexion);
                lbl_ubicacion.Text = cmd.ExecuteScalar().ToString() + " ";

                cmd = new SqlCommand("select numero from inmuebles where id = " + id, Program.conexion);
                lbl_ubicacion.Text +="#" + cmd.ExecuteScalar().ToString() +", ";

                cmd = new SqlCommand("select colonia from inmuebles where id = " + id, Program.conexion);
                lbl_ubicacion.Text += cmd.ExecuteScalar().ToString() + ", ";

                cmd = new SqlCommand("select ciudad_id from inmuebles where id = " + id, Program.conexion);
                aux = Convert.ToInt16(cmd.ExecuteScalar());

                cmd = new SqlCommand("select nombre from ciudades where id = " + aux, Program.conexion);
                lbl_ubicacion.Text += cmd.ExecuteScalar().ToString() + ", ";

                cmd = new SqlCommand("select estado_id from inmuebles where id = " + id, Program.conexion);
                aux = Convert.ToInt16(cmd.ExecuteScalar());

                cmd = new SqlCommand("select nombre from estados where id = " + aux, Program.conexion);
                lbl_ubicacion.Text += cmd.ExecuteScalar().ToString() + ", ";

                cmd = new SqlCommand("select pais_id from inmuebles where id = " + id, Program.conexion);
                aux = Convert.ToInt16(cmd.ExecuteScalar());

                cmd = new SqlCommand("select nombre from paises where id = " + aux, Program.conexion);
                lbl_ubicacion.Text += cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand("select count(*) from eventos where inmueble_id= " + id, Program.conexion);
                lbl_cantidad.Text = cmd.ExecuteScalar().ToString() + " Próximos eventos";

                try
                {

                    cmd = new SqlCommand("select imagen from inmuebles where id = " + id, Program.conexion);

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "1");
            }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Program.InmuebleDetalle(id);
            Program.inmuebles.Hide();
        }
    }
}
