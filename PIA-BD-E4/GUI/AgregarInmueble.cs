using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PIA_BD_E4.GUI
{
    public partial class AgregarInmueble : Form
    {
        Image imagen;
        string imageLocation = @"D:\Proyectos VS\PIA-BD-E4\PIA-BD-E4\Resources\inmueble_generico.jpg";
        bool insert;
        bool cambioFoto = false;
        int id;

        public AgregarInmueble()
        {
            InitializeComponent();
            OnInit();
            insert = true;
        }

        public AgregarInmueble(int id)
        {
            try
            {
                InitializeComponent();
                this.id = id;

                //PAISES
                SqlCommand cmd = new SqlCommand("select nombre from paises", Program.conexion);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    //Por cada registro de la consulta se agrega al combo box de pais
                    while (reader.Read())
                    {
                        cb_pais.Items.Add(reader["nombre"].ToString());
                    }
                    reader.Close();
                }
                int pais_id = Convert.ToInt16((new SqlCommand("select pais_id from inmuebles where id = " + id, Program.conexion)).ExecuteScalar());
                int estado_id = Convert.ToInt16((new SqlCommand("select estado_id from inmuebles where id = " + id, Program.conexion)).ExecuteScalar());
                int ciudad_id = Convert.ToInt16((new SqlCommand("select ciudad_id from inmuebles where id = " + id, Program.conexion)).ExecuteScalar());

                cmd = new SqlCommand("select nombre from paises where id = " + pais_id, Program.conexion);
                cb_pais.SelectedItem = cmd.ExecuteScalar().ToString();
                cb_pais_SelectedValueChanged(null, null);

                cmd = new SqlCommand("select nombre from estados where id = " + estado_id, Program.conexion);
                cb_estado.SelectedItem = cmd.ExecuteScalar().ToString();
                cb_estado_SelectedValueChanged(null, null);

                cmd = new SqlCommand("select nombre from ciudades where id = " + ciudad_id, Program.conexion);
                cb_ciudad.SelectedItem = cmd.ExecuteScalar().ToString();

                //Se crea el query
                cmd = new SqlCommand("select * from inmuebles where id = " + id, Program.conexion);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();

                    tx_nombre.Text = reader["nombre"].ToString();
                    tx_estacionamiento.Text = reader["estacionamiento"].ToString();
                    tx_reglas.Text = reader["reglas"].ToString();
                    tx_miscelaneo.Text = reader["miscelaneo"].ToString();
                    tx_telefono.Text = reader["telefono"].ToString();
                    tx_horarios.Text = reader["horario"].ToString();
                    tx_colonia.Text = reader["colonia"].ToString();
                    tx_calle.Text = reader["calle"].ToString();
                    tx_numero.Text = reader["numero"].ToString();
                    tx_cp.Text = reader["codigo_postal"].ToString();
                    tx_referencias.Text = reader["referencias"].ToString();
                    tx_url.Text = reader["url"].ToString();

                    reader.Close();
                    CargarImagen(id);
                    cambioFoto = false;
                    insert = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnInit()
        {
            cb_estado.Enabled = false;
            cb_ciudad.Enabled = false;
            tx_colonia.Enabled = false;
            tx_calle.Enabled = false;
            tx_numero.Enabled = false;
            tx_cp.Enabled = false;
            tx_referencias.Enabled = false;
            try
            {
                //Se crea el query
                SqlCommand cmd = new SqlCommand("select nombre from paises",Program.conexion);

                //Se hace el query
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    //Por cada registro de la consulta se agrega al combo box de pais
                    while (reader.Read())
                    {
                        cb_pais.Items.Add(reader["nombre"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se ha producido un error en la conexión a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        
        private void Insert()
        {
            if (Validar())
            {
                try
                {
                    string query;
                    if (insert)
                    {
                        query = "INSERT INTO Inmuebles (nombre,estacionamiento,reglas,miscelaneo,telefono,horario," +
                            "pais_id,estado_id,ciudad_id,colonia,calle,numero,codigo_postal,referencias,imagen,url) " +
                            "VALUES (@nombre,@estacionamiento,@reglas,@miscelaneo,@telefono,@horario,@pais_id,@estado_id,@ciudad_id," +
                            "@colonia,@calle,@numero,@codigo_postal,@referencias,@imagen,@url)";
                    }
                    else
                    {
                        if (cambioFoto)
                        {
                            query = "UPDATE inmuebles SET nombre = @nombre, estacionamiento = @estacionamiento, reglas = @reglas, " +
                                "miscelaneo = @miscelaneo, telefono = @telefono, horario = @horario, pais_id = @pais_id, estado_id = @estado_id, " +
                                "ciudad_id = @ciudad_id, colonia = @colonia, calle = @calle, numero = @numero, codigo_postal = @codigo_postal, " +
                                "referencias = @referencias, imagen = @imagen, url = @url " +
                                "where id = " + id.ToString();
                        }
                        else
                        {
                            query = "UPDATE inmuebles SET nombre = @nombre, estacionamiento = @estacionamiento, reglas = @reglas, " +
                                "miscelaneo = @miscelaneo, telefono = @telefono, horario = @horario, pais_id = @pais_id, estado_id = @estado_id, " +
                                "ciudad_id = @ciudad_id, colonia = @colonia, calle = @calle, numero = @numero, codigo_postal = @codigo_postal, " +
                                "referencias = @referencias, url = @url " +
                                "where id = " + id.ToString();
                        }
                    }

                    SqlCommand cmd = new SqlCommand(query, Program.conexion);
                    
                    cmd.Parameters.AddWithValue("@nombre", tx_nombre.Text);
                    cmd.Parameters.AddWithValue("@estacionamiento", tx_estacionamiento.Text);
                    cmd.Parameters.AddWithValue("@reglas", tx_reglas.Text);
                    cmd.Parameters.AddWithValue("@miscelaneo", tx_miscelaneo.Text);
                    cmd.Parameters.AddWithValue("@telefono", tx_telefono.Text);
                    cmd.Parameters.AddWithValue("@horario", tx_horarios.Text);

                    string query2 = $"select id from paises where nombre = '{ cb_pais.SelectedItem} '" ;
                    SqlCommand aux = new SqlCommand(query2, Program.conexion);
                    cmd.Parameters.AddWithValue("@pais_id", Convert.ToInt16(aux.ExecuteScalar()));

                    query2 = $"select id from estados where nombre = '{ cb_estado.SelectedItem} '";
                    aux = new SqlCommand(query2, Program.conexion);
                    cmd.Parameters.AddWithValue("@estado_id", Convert.ToInt16(aux.ExecuteScalar()));

                    query2 = $"select id from ciudades where nombre = '{ cb_ciudad.SelectedItem} '" ;
                    aux = new SqlCommand(query2, Program.conexion);
                    cmd.Parameters.AddWithValue("@ciudad_id", Convert.ToInt16(aux.ExecuteScalar()));

                    cmd.Parameters.AddWithValue("@colonia", tx_colonia.Text);
                    cmd.Parameters.AddWithValue("@calle", tx_calle.Text);
                    cmd.Parameters.AddWithValue("@numero", tx_numero.Text);
                    cmd.Parameters.AddWithValue("@codigo_postal", tx_cp.Text);
                    cmd.Parameters.AddWithValue("@referencias", tx_referencias.Text);
                    cmd.Parameters.AddWithValue("@url", tx_url.Text);

                    if(cambioFoto)
                    cmd.Parameters.AddWithValue("@imagen", ReadFile(imageLocation));

                    cmd.ExecuteNonQuery();
                    
                    if(insert)
                    MessageBox.Show("El inmueble se ha registrado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    MessageBox.Show("El inmueble se ha actualizado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch(Exception ex)
                {
                    //ESTE NO ES
                    MessageBox.Show("Se ha producido un error en la conexión a la base de datos\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private bool Validar()
        {
            bool valido1=true,valido2 = true;
            //Validando los datos del panel 1
            //Nombre
            if(tx_nombre.Text == "" || tx_nombre.Text.Contains("  ") || tx_nombre.Text[0]==' ' || tx_nombre.Text[tx_nombre.Text.Length-1]==' ')
            {
                tx_nombre.BorderColor = Color.Red;
                valido1 = false;
            }
            if (tx_telefono.Text == "")
            {
                tx_telefono.BorderColor = Color.Red;
                valido1 = false;
            }
            if (!valido1)
            {
                tx_error1.Text = "Asegurese de que los campos requeridos no estén vacíos, contengan doble espacio, inicien o terminen en espacio";
            }
            //Validando los datos del panel 2
            if(tx_colonia.Text == "" || tx_colonia.Text.Contains("  ") || tx_colonia.Text[0] == ' ' || tx_colonia.Text[tx_colonia.Text.Length - 1] == ' ')
            {
                tx_colonia.BorderColor = Color.Red;
                valido2 = false;
            }
            if(tx_calle.Text == "" || tx_calle.Text.Contains("  ") || tx_calle.Text[0] == ' ' || tx_calle.Text[tx_calle.Text.Length - 1] == ' ')
            {
                tx_calle.BorderColor = Color.Red;
                valido2 = false;
            }
            if(tx_numero.Text == "")
            {
                tx_numero.BorderColor = Color.Red;
                valido2 = false;
            }
            if(tx_cp.Text.Length!=5)
            {
                tx_cp.BorderColor = Color.Red;
                valido2 = false;
            }
            if(tx_referencias.Text == "" || tx_referencias.Text.Contains("  ") || tx_referencias.Text[0]==' ' || tx_referencias.Text[tx_referencias.Text.Length-1]==' ')
            {
                tx_referencias.BorderColor = Color.Red;
                valido2 = false;
            }
            if (!valido2)
            {
                tx_error2.Text = "Asegurese de que los campos requeridos sean validos, no estén vacíos, contengan doble espacio, inicien o terminen en espacio";
            }
            if(valido1 && valido2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SeleccionarImagen(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PGN files(*.png)|*.png";

                if(dialog.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    imagen = Image.FromFile(imageLocation);
                    pic_imagen.BackgroundImage = imagen;
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
        private void CargarImagen(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"select imagen from inmuebles where id = {id}", Program.conexion);

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Valid_LetraDigitoEspacio(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && !(e.KeyChar == ' ') && !(e.KeyChar == '\b') && !(e.KeyChar == '.') && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Valid_Digito(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && !(e.KeyChar == '\b') && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Valid_LetraDigitoEspacioParentesis(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && !(e.KeyChar == ' ') && !(e.KeyChar == '\b') && !(e.KeyChar == '(')
                && !(e.KeyChar==')')&&!(e.KeyChar=='.') && !(e.KeyChar=='-') && !(e.KeyChar=='#') && !(e.KeyChar == '*') && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void cb_pais_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void cb_estado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_estado.SelectedItem.ToString() != "")
            {
                try
                {
                    cb_ciudad.Enabled = true;
                    cb_ciudad.Items.Clear();

                    SqlCommand cmd = new SqlCommand($"select id from estados where nombre = '{cb_estado.SelectedItem.ToString()}'", Program.conexion);
                    int estado_id = Convert.ToInt16(cmd.ExecuteScalar());

                    cmd = new SqlCommand($"select nombre from ciudades join estados_ciudades on ciudades.id = estados_ciudades.ciudad_id where estados_ciudades.estado_id = {estado_id}",
                                         Program.conexion);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Por cada registro de la consulta se agrega al combo box de pais
                        while (reader.Read())
                        {
                            cb_ciudad.Items.Add(reader["nombre"].ToString());
                        }
                        reader.Close();
                    }

                    tx_colonia.Enabled = true;
                    tx_calle.Enabled = true;
                    tx_numero.Enabled = true;
                    tx_cp.Enabled = true;
                    tx_referencias.Enabled = true;

                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Se ha producido un error en la conexión a la base de datos2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (Validar())
            {
                Insert();   
            }
        }

        private void tx_nombre_Enter(object sender, EventArgs e)
        {
            if (tx_nombre.BorderColor == Color.Red)
            {
                tx_nombre.BorderColor = Color.FromArgb(114, 114, 114);
                tx_error1.Text = "";
            }
        }

        private void tx_telefono_Enter(object sender, EventArgs e)
        {
            if (tx_telefono.BorderColor == Color.Red)
            {
                tx_telefono.BorderColor = Color.FromArgb(114, 114, 114);
                tx_error1.Text = "";
            }
        }

        private void tx_colonia_Enter(object sender, EventArgs e)
        {
            if(tx_colonia.BorderColor == Color.Red)
            {
                tx_colonia.BorderColor = Color.FromArgb(114, 114, 114);
                tx_error2.Text = "";
            }
        }

        private void tx_calle_Enter(object sender, EventArgs e)
        {
            if (tx_calle.BorderColor == Color.Red)
            {
                tx_calle.BorderColor = Color.FromArgb(114, 114, 114);
                tx_error2.Text = "";
            }
        }

        private void tx_numero_Enter(object sender, EventArgs e)
        {
            if (tx_numero.BorderColor == Color.Red)
            {
                tx_numero.BorderColor = Color.FromArgb(114, 114, 114);
                tx_error2.Text = "";
            }
        }

        private void tx_cp_Enter(object sender, EventArgs e)
        {
            if (tx_cp.BorderColor == Color.Red)
            {
                tx_cp.BorderColor = Color.FromArgb(114, 114, 114);
                tx_error2.Text = "";
            }
        }

        private void tx_referencias_Enter(object sender, EventArgs e)
        {
            if (tx_referencias.BorderColor == Color.Red)
            {
                tx_referencias.BorderColor = Color.FromArgb(114, 114, 114);
                tx_error2.Text = "";
            }
        }

        private void tx_url_Enter(object sender, EventArgs e)
        {
            if (tx_url.BorderColor == Color.Red)
            {
                tx_url.BorderColor = Color.FromArgb(114, 114, 114);
                tx_error2.Text = "";
            }
        }

        private void cb_pais_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_pais.SelectedItem.ToString() != "")
            {
                try
                {
                    cb_estado.Enabled = true;
                    cb_estado.Items.Clear();

                    SqlCommand cmd = new SqlCommand($"select id from paises where nombre = '{cb_pais.SelectedItem}'", Program.conexion);
                    int pais_id = Convert.ToInt16(cmd.ExecuteScalar());

                    cmd = new SqlCommand($"select nombre from estados join paises_estados on estados.id = paises_estados.estado_id where paises_estados.pais_id = {pais_id}",
                                         Program.conexion);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Por cada registro de la consulta se agrega al combo box de pais
                        while (reader.Read())
                        {
                            cb_estado.Items.Add(reader["nombre"].ToString());
                        }
                        reader.Close();
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudieron cargar los estados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void pic_imagen_BackgroundImageChanged(object sender, EventArgs e)
        {
            cambioFoto = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cancelar esta acción?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
