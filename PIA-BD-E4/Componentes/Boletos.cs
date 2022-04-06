using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PIA_BD_E4.Componentes
{
    public partial class Boletos : UserControl
    {
        int cantidad;
        int localidad_id;
        double total;
        List<int> ids = new List<int>();

        public Boletos(int localidad_id,int cantidad)
        {
            this.cantidad = cantidad;
            this.localidad_id = localidad_id;
            InitializeComponent();
            try
            {
                SqlCommand cmd = new SqlCommand($"select count(*) from localidades_asientos where localidad_id = {localidad_id} and estado = 1", Program.conexion);
                if (Convert.ToInt16(cmd.ExecuteScalar()) >= cantidad)
                {
                    tx1.Visible = false;
                    tx2.Visible = false;
                    lbl_cantidad.Text = cantidad.ToString();
                    cmd = new SqlCommand($"select top {cantidad} * from localidades_asientos where localidad_id = {localidad_id}",Program.conexion);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ids.Add(Convert.ToInt16(reader["id"]));
                        }
                        reader.Close();
                    }
                    InfoBoletos ultimo = new InfoBoletos();
                    InfoBoletos aux;
                    int i=0;
                    foreach(int id in ids)
                    {
                        aux = new InfoBoletos(localidad_id, id);
                        panel.Controls.Add(aux);
                        aux.BringToFront();
                        if (i == 0)
                        {
                            aux.Location = new Point(0, 0);
                        }
                        else
                        {
                            aux.Location = new Point(0, ultimo.Location.Y + ultimo.Size.Height);
                        }
                        ultimo = aux;
                        i++;
                    }
                    cmd = new SqlCommand($"select precio from localidades where id = {localidad_id}", Program.conexion);
                    total = cantidad * Convert.ToDouble(cmd.ExecuteScalar());
                    lbl_total.Text = "Total: $" + string.Format("{0:0.00}", total);
                    lbl_total.Location = new Point(620 - lbl_total.Size.Width + 20, 717);
                }
                else
                {
                    lbl_seleccion.Text = "Sin resultados";
                    btn_comprar.Visible = false;
                    linea_cantidad.Visible = false;
                    pic_boletos.Visible = false;
                    lbl_cantidad.Visible = false;
                    lbl_x.Visible = false;
                }
            }
            catch (Exception) { }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Program.eventoDetalle.CerrarVentana();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            if (Program.logeado != null)
            {
                try
                {
                    var resultado = MessageBox.Show("¿Está seguro de que desea realizar esta compra?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        /*string cadena = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + " " +
                            DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":00";*/
                        string cadena = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        SqlCommand cmd = new SqlCommand($"insert into ventas values ('{cadena}',{Program.logeado},{total})",Program.conexion);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand($"select top 1 id from ventas order by id DESC",Program.conexion);
                        string venta_id = cmd.ExecuteScalar().ToString();

                        foreach(int asiento_id in ids)
                        {
                            cmd = new SqlCommand($"insert into ventas_detalles values ({venta_id},{asiento_id})",Program.conexion);
                            cmd.ExecuteNonQuery();
                        }
                        //AQUI REEMPLAZAR
                        MessageBox.Show("Ya tienes tus boletos!\nEncuentralos en tu cuenta");
                        Program.actual.Hide();
                        Program.EventosLista(0);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("Inicie sesión para poder comprar estos boletos", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.AbrirLogin();
            }
        }
    }
}
