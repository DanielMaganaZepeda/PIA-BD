using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PIA_BD_E4.Componentes
{
    public partial class CardLocalidad : UserControl
    {
        int id;
        public CardLocalidad(int id)
        {
            InitializeComponent();
            this.id = id;
            try
            {
                SqlCommand cmd = new SqlCommand($"select nombre from localidades where id = {id}", Program.conexion);
                lbl_nombre.Text = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand($"select precio from localidades where id = {id}", Program.conexion);
                double aux = Convert.ToDouble(cmd.ExecuteScalar());
                lbl_precio.Text = "$" + string.Format("{0:0.00}", aux) + " cada uno";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_siguiente_MouseEnter(object sender, EventArgs e)
        {
            lbl_nombre.BackColor = Color.FromArgb(239, 239, 239);
            lbl_precio.BackColor = Color.FromArgb(239, 239, 239);
            pictureBox1.BackColor = Color.FromArgb(239, 239, 239);
        }

        private void btn_siguiente_MouseLeave(object sender, EventArgs e)
        {
            lbl_nombre.BackColor = Color.White;
            lbl_precio.BackColor = Color.White;
            pictureBox1.BackColor = Color.White;
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            Program.eventoDetalle.AbrirBoletos(id);
        }
    }
}
