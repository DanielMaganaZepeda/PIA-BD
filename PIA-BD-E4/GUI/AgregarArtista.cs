using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PIA_BD_E4.GUI
{
    public partial class AgregarArtista : Form
    {
        int id;
        bool insert;
        Image imagen;
        string imageLocation;
        bool cambioFoto=false;
        public AgregarArtista()
        {
            InitializeComponent();
            insert = true;
        }
        public AgregarArtista(int id)
        {
            this.id = id;
            InitializeComponent();
            OnInit(id);
            cambioFoto = false;
            insert = false;
        }

        private void Insert()
        {
            try
            {
                string query;
                SqlCommand cmd;
                if (insert)
                {
                    query="INSERT INTO Artistas (nombre,biografia,imagen) VALUES (@nombre,@biografia,@imagen)";
                }
                else
                {
                    if (cambioFoto)
                    {
                        query = $"update artistas set nombre=@nombre,biografia=@biografia,imagen=@imagen where id = {id}";
                    }
                    else
                    {
                        query = $"update artistas set nombre=@nombre,biografia=@biografia where id = {id}";
                    }
                }
                cmd = new SqlCommand(query, Program.conexion);
                cmd.Parameters.AddWithValue("@nombre", tx_nombre.Text);
                cmd.Parameters.AddWithValue("@biografia", tx_biografia.Text);
                if (cambioFoto)
                cmd.Parameters.AddWithValue("@imagen", ReadFile(imageLocation));

                cmd.ExecuteNonQuery();
                if (insert)
                    MessageBox.Show("El artista se ha registrado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El artista se ha actualizado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error en la conexión a la base de datos\n"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        //La función transforma la imagen a hexadecimal
        //Fuente: https://www.codeproject.com/Articles/21208/Store-or-Save-images-in-SQL-Server
        byte[] ReadFile(string sPath)
        {
            byte[] data = null;

            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fStream);

            data = br.ReadBytes((int)numBytes);

            return data;
        }


        private void OnInit(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select nombre from artistas where id = " + id, Program.conexion);
                tx_nombre.Text = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand("select biografia from artistas where id = " + id, Program.conexion);
                tx_biografia.Text = cmd.ExecuteScalar().ToString();

                CargarImagen(id);
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un error en la conexión a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        //Cargar imagen de SQL
        private void CargarImagen(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"select imagen from artistas where id = {id}", Program.conexion);

                byte[] imageData = (byte[])(cmd.ExecuteScalar());
                Image newImage;
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);
                    newImage = Image.FromStream(ms, true);
                }
                pic_imagen.BackgroundImage = newImage;
                label2.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool Validar()
        {
            try
            {
                bool valido = true;
                if(tx_nombre.Text == "")
                {
                    tx_nombre.BorderColor = Color.Red;
                    valido = false;
                }
                if (pic_imagen.BackgroundImage == null)
                {
                    valido = false;
                }
                if (!valido)
                {
                    warning.Text = "Asegurese de que el artista tenga nombre y fotografía";
                    return valido;
                }
                else
                {
                    return valido;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void pic_imagen_Click(object sender, System.EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PGN files(*.png)|*.png";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    imagen = Image.FromFile(imageLocation);
                    pic_imagen.BackgroundImage = imagen;
                    label2.Visible = false;
                }
            }
            catch (Exception) { }
        }

        private void pic_imagen_BackgroundImageChanged(object sender, EventArgs e)
        {
            cambioFoto = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Insert();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cancelar esta acción?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tx_nombre_Enter(object sender, EventArgs e)
        {
            if(tx_nombre.BorderColor == Color.Red)
            {
                tx_nombre.BorderColor = Color.FromArgb(114, 114, 114);
                warning.Text = "";
            }
        }

        private void tx_biografia_Enter(object sender, EventArgs e)
        {
            if (tx_nombre.BorderColor == Color.Red)
            {
                tx_nombre.BorderColor = Color.FromArgb(114, 114, 114);
                warning.Text = "";
            }
        }
    }
}
