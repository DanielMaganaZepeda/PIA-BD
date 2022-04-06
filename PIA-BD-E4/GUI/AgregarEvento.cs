using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIA_BD_E4.GUI
{
    public partial class AgregarEvento : Form
    {
        Image imagen;
        string imageLocation = @"D:\Proyectos VS\PIA-BD-E4\PIA-BD-E4\Resources\inmueble_generico.jpg";
        string imagenMapa;
        bool insert;
        bool cambioFoto = false;
        bool cambioMapa = false;
        int id;

        public AgregarEvento()
        {
            InitializeComponent();
            OnInit();
            insert = true;
        }

        public AgregarEvento(int id)
        {
            this.id = id;
            InitializeComponent();
            OnInit();
            CargarDatos();
            insert = false;
            cambioFoto = false;
            cambioMapa = false;
        }

        private void CargarDatos()
        {
            try
            {
                DateTime inicio, fin;
                SqlCommand cmd = new SqlCommand($"select nombre from eventos where id = {id}", Program.conexion);
                tx_nombre.Text = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand($"select inmueble_id from eventos where id = {id}", Program.conexion);
                string aux = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand($"select nombre from inmuebles where id = {aux}",Program.conexion);
                cb_inmueble.SelectedItem = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand($"select tipo_id from eventos where id = {id}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand($"select nombre from tipos where id = {aux}", Program.conexion);
                cb_categoria.SelectedItem = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand($"select fecha_inicio from eventos where id = {id}", Program.conexion);
                inicio= DateTime.Parse(cmd.ExecuteScalar().ToString());
                fecha_inicio.Value = inicio;

                cmd = new SqlCommand($"select fecha_fin from eventos where id = {id}", Program.conexion);
                fin = DateTime.Parse(cmd.ExecuteScalar().ToString());
                fecha_fin.Value = fin;

                cb_hora_inicio.SelectedItem = inicio.ToString("HH") ;
                cb_minuto_inicio.SelectedItem = inicio.ToString("MM");

                cb_hora_fin.SelectedItem = fin.ToString("HH");
                cb_minuto_fin.SelectedItem = fin.ToString("MM");

                cmd = new SqlCommand($"select visible from eventos where id = {id}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();

                if (aux == "1") check_mostrar.Checked = true;
                else check_mostrar.Checked = false;

                tabla.Enabled = false;
                localidades_asientos.Enabled = false;
                localidades_filas.Enabled = false;
                localidades_precio.Enabled = false;
                localidades_nombre.Enabled = false;
                localidad_agregar.Enabled = false;
                localidad_borrar.Enabled = false;

                cmd = new SqlCommand($"select * from eventos where id = {id}", Program.conexion);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tx_edad.Text = reader["edad"].ToString();
                        tx_pagan.Text = reader["pagan"].ToString();
                        tx_discapacidad.Text = reader["discapacidad"].ToString();
                        tx_duracion.Text = reader["tiempo"].ToString();
                        tx_restricciones.Text = reader["restricciones"].ToString();
                        tx_descipcion.Text = reader["informacion"].ToString();
                        tx_observaciones.Text = reader["observaciones"].ToString();
                    }
                    reader.Close();
                }

                label_imagen.Visible=false;
                CargarImagen();
                
            }
            catch (Exception) { }
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

        private void Artistas(int id)
        {
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand($"delete from eventos_artistas where evento_id = {id}", Program.conexion);
                List<int> ids = Program.listaArtistas.Artistas();
                foreach(int i in ids)
                {
                    cmd = new SqlCommand($"insert into eventos_artistas values ({id},{i})",Program.conexion);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Localidades(int id)
        {
            try
            {
                //Se agrega a localidades
                SqlCommand cmd;
                for(int i = 0; i<tabla.Rows.Count; i++)
                {
                    cmd = new SqlCommand("insert into localidades values (@nombre,@precio,@cantidad,@evento_id,@filas,@asientos)",Program.conexion);
                    cmd.Parameters.AddWithValue("@nombre", tabla.Rows[i].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@precio", tabla.Rows[i].Cells[3].Value.ToString());
                    cmd.Parameters.AddWithValue("@filas", tabla.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@asientos", tabla.Rows[i].Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt16(tabla.Rows[i].Cells[1].Value) * Convert.ToInt16(tabla.Rows[i].Cells[2].Value));
                    cmd.Parameters.AddWithValue("@evento_id", id);
                    cmd.ExecuteNonQuery();
                }
                //Se agregan localidades_asientos
                cmd = new SqlCommand($"select * from localidades where evento_id = {id}",Program.conexion);
                List<int> ids = new List<int>();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    //Por cada localidad
                    while (reader.Read())
                    {
                        ids.Add(Convert.ToInt16(reader["id"]));
                    }
                    reader.Close();
                }
                //Variables que ayudan
                int filas, asientos;
                int aux = 65;
                int aux2 = 1;
                string cadena;
                foreach (int localidad_id in ids)
                {
                    cmd = new SqlCommand($"select filas from localidades where id = {localidad_id}",Program.conexion);
                    filas = Convert.ToInt16(cmd.ExecuteScalar());
                    cmd = new SqlCommand($"select asientos from localidades where id = {localidad_id}",Program.conexion);
                    asientos = Convert.ToInt16(cmd.ExecuteScalar());

                    aux2 = 1;
                    //Filas
                    for (int i = 1; i <= filas; i++)
                    {
                        //Asientos por fila
                        for (int j = 1; j <= asientos; j++)
                        {
                            cmd = new SqlCommand("insert into localidades_asientos values (@localidad_id,@fila,@asiento,1)", Program.conexion);
                            //Calcular FILA en String
                            cadena = "";
                            if (aux < 91)
                            {
                                for (int k = 0; k < aux2; k++)
                                {
                                    cadena += ((char)aux).ToString();
                                }
                                aux++;
                            }
                            else
                            {
                                aux = 65;
                                aux2++;
                                for (int k = 0; k < aux2; k++)
                                {
                                    cadena += ((char)aux).ToString();
                                }
                                aux++;
                            }
                            cmd.Parameters.AddWithValue("@localidad_id", localidad_id.ToString());
                            cmd.Parameters.AddWithValue("@fila", cadena);
                            cmd.Parameters.AddWithValue("@asiento", j.ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Insert()
        {
            try
            {
                string query="";
                if (insert)
                {
                    query = "insert into eventos values (@nombre,@inmueble_id,@tipo_id,@fecha_inicio,@fecha_fin,@imagen,@informacion," +
                        "@observaciones,@imagen_localidades,@visible,@edad,@pagan,@discapacidad,@restricciones,@tiempo,@fecha)";
                }
                else
                {
                    if(cambioFoto==true && cambioMapa==true)
                    {
                        query = "update eventos set nombre=@nombre,inmueble_id=@inmueble_id,tipo_id=@tipo_id,fecha_inicio=@fecha_inicio," +
                            "fecha_fin=@fecha_fin,imagen=@imagen,informacion=@informacion,observaciones=@observaciones,imagen_localidades=@imagen_localidades," +
                            "visible=@visible,edad=@edad,pagan=@pagan,discapacidad=@discapacidad,restricciones=@restricciones,tiempo=@tiempo,fecha=@fecha " +
                            "where id = "+id;
                    }
                    if(cambioFoto == false && cambioMapa == false)
                    {
                        query = "update eventos set nombre=@nombre,inmueble_id=@inmueble_id,tipo_id=@tipo_id,fecha_inicio=@fecha_inicio," +
                            "fecha_fin=@fecha_fin,informacion=@informacion,observaciones=@observaciones," +
                            "visible=@visible,edad=@edad,pagan=@pagan,discapacidad=@discapacidad,restricciones=@restricciones,tiempo=@tiempo,fecha=@fecha " +
                            "where id = " + id;
                    }
                    if(cambioFoto == true && cambioMapa == false)
                    {
                        query = "update eventos set nombre=@nombre,inmueble_id=@inmueble_id,tipo_id=@tipo_id,fecha_inicio=@fecha_inicio," +
                            "fecha_fin=@fecha_fin,imagen=@imagen,informacion=@informacion,observaciones=@observaciones," +
                            "visible=@visible,edad=@edad,pagan=@pagan,discapacidad=@discapacidad,restricciones=@restricciones,tiempo=@tiempo,fecha=@fecha " +
                            "where id = " + id;
                    }
                    if(cambioFoto==false && cambioMapa == true)
                    {
                        query = "update eventos set nombre=@nombre,inmueble_id=@inmueble_id,tipo_id=@tipo_id,fecha_inicio=@fecha_inicio," +
                            "fecha_fin=@fecha_fin,informacion=@informacion,observaciones=@observaciones,imagen_localidades=@imagen_localidades," +
                            "visible=@visible,edad=@edad,pagan=@pagan,discapacidad=@discapacidad,restricciones=@restricciones,tiempo=@tiempo,fecha=@fecha " +
                            "where id = " + id;
                    }
                }
                string cadena;
                DateTime fecha;

                SqlCommand cmd = new SqlCommand(query, Program.conexion);
                cmd.Parameters.AddWithValue("@nombre", tx_nombre.Text);

                SqlCommand aux = new SqlCommand($"select id from inmuebles where nombre = '{cb_inmueble.SelectedItem}'",Program.conexion);
                cmd.Parameters.AddWithValue("@inmueble_id", aux.ExecuteScalar().ToString());

                aux = new SqlCommand($"select id from tipos where nombre = '{cb_categoria.SelectedItem}'",Program.conexion);
                cmd.Parameters.AddWithValue("@tipo_id",aux.ExecuteScalar().ToString());

                fecha = fecha_inicio.Value;
                cadena = fecha.Year.ToString() + "-" + fecha.Month.ToString() + "-" + fecha.Day.ToString() + " " +
                    cb_hora_inicio.SelectedItem.ToString() + ":" + cb_minuto_inicio.SelectedItem.ToString() + ":00";
                cmd.Parameters.AddWithValue("@fecha_inicio", cadena);

                fecha = fecha_fin.Value;
                cadena = fecha.Year.ToString() + "-" + fecha.Month.ToString() + "-" + fecha.Day.ToString() + " " +
                    cb_hora_fin.SelectedItem.ToString() + ":" + cb_minuto_fin.SelectedItem.ToString() + ":00";
                cmd.Parameters.AddWithValue("@fecha_fin", cadena);

                cmd.Parameters.AddWithValue("@informacion",tx_descipcion.Text);
                cmd.Parameters.AddWithValue("@observaciones",tx_observaciones.Text);

                if (check_mostrar.Checked) cmd.Parameters.AddWithValue("@visible", "1");
                else cmd.Parameters.AddWithValue("@visible", "0");

                cmd.Parameters.AddWithValue("@edad",tx_edad.Text);
                cmd.Parameters.AddWithValue("@pagan", tx_pagan.Text);
                cmd.Parameters.AddWithValue("@discapacidad",tx_discapacidad.Text);
                cmd.Parameters.AddWithValue("@restricciones", tx_restricciones.Text);
                cmd.Parameters.AddWithValue("@tiempo", tx_duracion.Text);

                fecha = fecha_inicio.Value;
                cadena = fecha.Year.ToString() + "-" + fecha.Month.ToString() + "-" + fecha.Day.ToString();
                cmd.Parameters.AddWithValue("@fecha", cadena);

                if (insert)
                {
                    cmd.Parameters.AddWithValue("@imagen", ReadFile(imageLocation));
                    cmd.Parameters.AddWithValue("@imagen_localidades", ReadFile(imagenMapa));
                }
                else
                {
                    if (cambioFoto == true && cambioMapa == true)
                    {
                        cmd.Parameters.AddWithValue("@imagen", ReadFile(imageLocation));
                        cmd.Parameters.AddWithValue("@imagen_localidades", ReadFile(imagenMapa));
                    }
                    if (cambioFoto == false && cambioMapa == false)
                    {
                    }
                    if (cambioFoto == true && cambioMapa == false)
                    {
                        cmd.Parameters.AddWithValue("@imagen", ReadFile(imageLocation));
                    }
                    if (cambioFoto == false && cambioMapa == true)
                    {
                        cmd.Parameters.AddWithValue("@imagen_localidades", ReadFile(imagenMapa));
                    }
                }

                cmd.ExecuteNonQuery();

                cmd = new SqlCommand($"select id from eventos where nombre = '{tx_nombre.Text}'", Program.conexion);
                Artistas(Convert.ToInt16(cmd.ExecuteScalar()));

                if(insert)
                Localidades(Convert.ToInt16(cmd.ExecuteScalar()));

                if (insert)
                    MessageBox.Show("El evento se ha registrado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El evento se ha actualizado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error en la conexión a la base de datos\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private bool Validar()
        {
            bool validar = true;
            if (tx_nombre.Text == "")
            {
                validar = false;
                tx_nombre.BorderColor = Color.Red;
            }
            if (cb_inmueble.SelectedIndex == -1)
            {
                validar = false;
            }
            if (cb_categoria.SelectedIndex == -1)
            {
                validar = false;
            }
            if(cb_minuto_inicio.SelectedIndex==-1 || cb_minuto_fin.SelectedIndex==-1 || cb_hora_inicio.SelectedIndex==-1 || cb_hora_fin.SelectedIndex==-1)
            {
                validar = false;
                MessageBox.Show("Asegurese de llenar todos los campos de fecha","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return validar;
            }
            DateTime inicio, fin, aux;
            try
            {
                aux = fecha_inicio.Value;
                inicio = new DateTime(aux.Year, aux.Month, aux.Day, Convert.ToInt16(cb_hora_inicio.SelectedItem), Convert.ToInt16(cb_minuto_inicio.SelectedItem), 00);
                if(inicio < DateTime.Now)
                {
                    validar = false;
                    MessageBox.Show("No puede registrar un evento para una fecha pasada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return validar;
                }
                aux = fecha_fin.Value;
                fin = new DateTime(aux.Year, aux.Month, aux.Day, Convert.ToInt16(cb_hora_fin.SelectedItem), Convert.ToInt16(cb_minuto_fin.SelectedItem), 00);
                if(fin <= inicio)
                {
                    validar = false;
                    MessageBox.Show("La fecha de fin no puede ser anterior a la de inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return validar;
                }
            }
            catch (Exception) { }
            if(tabla.Rows.Count == 0 && insert)
            {
                validar = false;
                MessageBox.Show("No puede registrar un evento sin localidades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return validar;
            }
            if(pic_mapa.BackgroundImage == null)
            {
                validar = false;
                MessageBox.Show("Debe haber una foto del mapa de localidades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return validar;
            }
            if (tx_descipcion.Text == "")
            {
                validar = false;
                tx_descipcion.BorderColor = Color.Red;
            }
            if (tx_discapacidad.Text == "")
            {
                validar= false;
                tx_discapacidad.BorderColor = Color.Red;
            }
            if (validar)
            {
                try
                {
                    aux = fecha_inicio.Value;
                    string cadena = aux.Year.ToString() + "-" + aux.Month.ToString() + "-" + aux.Day.ToString();
                    SqlCommand cmd = new SqlCommand("select count (*) from eventos where fecha = '" + aux + "'", Program.conexion);
                    if (Convert.ToInt16(cmd.ExecuteScalar()) > 0 && insert)
                    {
                        validar = false;
                        MessageBox.Show("Ya hay un evento en esta fecha en el inmueble seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return validar;
                    }
                }
                catch (Exception) {}
            }
            return validar;
        }

        private void OnInit()
        {
            try
            {
                check_mostrar.Checked = true;
                fecha_inicio.Value = DateTime.Now;
                fecha_fin.Value = DateTime.Now;
                SqlCommand cmd = new SqlCommand("select * from inmuebles order by nombre", Program.conexion);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cb_inmueble.Items.Add(reader["nombre"]);
                    }
                    reader.Close();
                }
                cmd = new SqlCommand("select * from tipos", Program.conexion);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cb_categoria.Items.Add(reader["nombre"]);
                    }
                    reader.Close();
                }
            }
            catch (Exception) { }
        }

        private void SeleccionarImagen(PictureBox sender)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PGN files(*.png)|*.png";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (sender == pic_imagen)
                    {
                        imageLocation = dialog.FileName;
                        imagen = Image.FromFile(imageLocation);
                    }
                    else
                    {
                        imagenMapa = dialog.FileName;
                        imagen = Image.FromFile(imagenMapa);
                    }

                    sender.BackgroundImage = imagen;

                    if (sender == pic_mapa) label_imagen.Visible = false;
                }
            }
            catch (Exception) { }
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

        //Cargar imagen de SQL
        private void CargarImagen(int id,string imagen)
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"select {imagen} from eventos where id = {id}", Program.conexion);

                byte[] imageData = (byte[])(cmd.ExecuteScalar());
                Image newImage;
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);
                    newImage = Image.FromStream(ms, true);
                }
                pic_imagen.BackgroundImage = newImage;

                //Guarda la imagen en un path temporal para despues leerla nuevamente

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void localidad_agregar_Click(object sender, EventArgs e)
        {
            if(ValidarLocalidad())
            {
                tabla.Rows.Add(localidades_nombre.Text, localidades_filas.Text, localidades_asientos.Text, localidades_precio.Text);
                localidades_nombre.Text = "";
                localidades_filas.Text = "";
                localidades_asientos.Text = "";
                localidades_precio.Text = "";
            }
            else
            {
                MessageBox.Show("Asegurese de llenar todos los campos para agregar la localidad","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool ValidarLocalidad()
        {
            bool valido = true;
            if (localidades_nombre.Text == "")
            {
                localidades_nombre.BorderColor = Color.Red;
                valido = false;
            }
            if (localidades_asientos.Text == "")
            {
                localidades_asientos.BorderColor = Color.Red;
                valido = false;
            }
            if (localidades_filas.Text == "")
            {
                localidades_filas.BorderColor = Color.Red;
                valido = false;
            }
            if (localidades_precio.Text == "")
            {
                localidades_precio.BorderColor = Color.Red;
                valido = false;
            }
            if (valido)
            {
                for(int i = 0; i < tabla.Rows.Count; i++)
                {
                    if(tabla.Rows[i].Cells[0].Value.ToString() == localidades_nombre.Text)
                    {
                        localidades_nombre.BorderColor = Color.Red;
                        MessageBox.Show("Ya hay una localidad con este nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return valido;
                    }
                }
            }
            return valido;
        }

        private void localidades_nombre_Enter(object sender, EventArgs e)
        {
            if(localidades_nombre.BorderColor == Color.Red)
            {
                localidades_nombre.BorderColor = Color.FromArgb(114, 114, 114);
            }
        }

        private void localidades_filas_Enter(object sender, EventArgs e)
        {
            if (localidades_filas.BorderColor == Color.Red)
            {
                localidades_filas.BorderColor = Color.FromArgb(114, 114, 114);
            }
        }

        private void localidades_asientos_Enter(object sender, EventArgs e)
        {
            if (localidades_asientos.BorderColor == Color.Red)
            {
                localidades_asientos.BorderColor = Color.FromArgb(114, 114, 114);
            }
        }

        private void localidades_precio_Enter(object sender, EventArgs e)
        {
            if (localidades_precio.BorderColor == Color.Red)
            {
                localidades_precio.BorderColor = Color.FromArgb(114, 114, 114);
            }
        }

        private void localidad_borrar_Click(object sender, EventArgs e)
        {
            if (tabla.SelectedRows.Count == 0)
            {
                MessageBox.Show("No se ha seleccionado ninguna localidad","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                var resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta localidad?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    tabla.Rows.Remove(tabla.SelectedRows[0]);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Program.listaArtistas.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Insert();
            }
        }

        private void pic_mapa_Click(object sender, EventArgs e)
        {
            SeleccionarImagen(pic_mapa);
        }

        private void pic_imagen_Click(object sender, EventArgs e)
        {
            SeleccionarImagen(pic_imagen);
        }

        private void tx_nombre_Enter(object sender, EventArgs e)
        {
            if (tx_nombre.BorderColor == Color.Red)
            {
                tx_nombre.BorderColor = Color.FromArgb(114, 114, 114);
            }
        }

        private void tx_descipcion_Enter(object sender, EventArgs e)
        {
            if (tx_descipcion.BorderColor == Color.Red)
            {
                tx_descipcion.BorderColor= Color.FromArgb(114, 114, 114);
            }
        }

        private void tx_discapacidad_Enter(object sender, EventArgs e)
        {
            if (tx_discapacidad.BorderColor == Color.Red)
            {
                tx_discapacidad.BorderColor= Color.FromArgb(114, 114, 114);
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

        private void pic_mapa_BackgroundImageChanged(object sender, EventArgs e)
        {
            cambioMapa = true;
        }

        private void pic_imagen_BackgroundImageChanged(object sender, EventArgs e)
        {
            cambioFoto = true;
        }
    }
}
