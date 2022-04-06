using PIA_BD_E4.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIA_BD_E4.Componentes
{
    public partial class CargarInmuebl : UserControl
    {
        public CargarInmuebl(int totales)
        {
            InitializeComponent();
            pb_cantidad.Maximum = totales;
            pb_cantidad.Value = 10;
            lbl_cantidad.Text = $"Cargado 10 de {totales} inmuebles";
            lbl_cantidad.Location = new Point((int)(1819 - lbl_cantidad.Size.Width) / 2, lbl_cantidad.Location.Y);
        }

        public void Actualizar(int cargados,int totales)
        {
            pb_cantidad.Maximum = totales;
            pb_cantidad.Value = cargados;
            lbl_cantidad.Text = $"Cargado {cargados} de {totales} inmuebles";
            lbl_cantidad.Location = new Point((int)(1819 - lbl_cantidad.Size.Width) / 2, lbl_cantidad.Location.Y);
        }

        private void btn_mas_Click(object sender, EventArgs e)
        {
        }
    }
}
