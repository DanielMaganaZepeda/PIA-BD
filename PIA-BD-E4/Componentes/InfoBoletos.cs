using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIA_BD_E4.Componentes
{
    public partial class InfoBoletos : UserControl
    {
        public InfoBoletos() { }
        public InfoBoletos(int localidad_id,int boleto_id)
        {
            InitializeComponent();
            try
            {
                string aux;
                SqlCommand cmd = new SqlCommand($"select nombre from localidades where id = {localidad_id}", Program.conexion);
                aux = cmd.ExecuteScalar().ToString();
                lbl_localidad.Text = "";
                for(int i = 0; i < aux.Length; i++)
                {
                    if (i < 15)
                    {
                        lbl_localidad.Text += aux[i].ToString();
                    }
                }
                cmd = new SqlCommand($"select fila from localidades_asientos where id = {boleto_id}", Program.conexion);
                lbl_fila.Text = cmd.ExecuteScalar().ToString();
                cmd = new SqlCommand($"select asiento from localidades_asientos where id = {boleto_id}", Program.conexion);
                lbl_asiento.Text = cmd.ExecuteScalar().ToString();
            }
            catch (Exception) { }
        }
    }
}
