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

namespace PIA_BD_E4.GUI
{
    public partial class AgregarListaArtistas : Form
    {
        int id;
        bool insert;
        bool primero = true;
        public AgregarListaArtistas()
        {
            InitializeComponent();
            OnInit();
            insert = true;
        }

        private void CargarArtistas()
        {
            List<int> ids = new List<int>();
            try
            {
                dataGridView1.ClearSelection();
                SqlCommand cmd = new SqlCommand("select * from eventos_artistas where evento_id =" + id, Program.conexion);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ids.Add(Convert.ToInt16(reader["artista_id"]));
                    }
                    reader.Close();
                }
                foreach (int i in ids)
                {
                    cmd = new SqlCommand($"select nombre from artistas where id = {i}", Program.conexion);
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        if (dataGridView1.Rows[j].Cells[0].Value.ToString() == cmd.ExecuteScalar().ToString())
                        {
                            dataGridView1.Rows[j].Selected = true;
                        }
                    }
                }
                primero = false;
            }
            catch (Exception) { }
        }

        public AgregarListaArtistas(int id)
        {
            this.id = id;
            InitializeComponent();
            insert = false;
            OnInit();
        }

        private void OnInit()
        {
            SqlCommand cmd = new SqlCommand("select * from artistas order by nombre", Program.conexion);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["nombre"].ToString());
                }
                reader.Close();
            }
        }

        public List<int> Artistas()
        {
            List<int> ids = new List<int>();
            SqlCommand cmd;
            try
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    cmd = new SqlCommand($"select id from artistas where nombre = '{dataGridView1.SelectedRows[i].Cells[0].Value}'", Program.conexion);
                    ids.Add(Convert.ToInt16(cmd.ExecuteScalar()));
                }
                return ids;
            }
            catch (Exception) { return ids; }
        }

        private void buscador_KeyUp(object sender, KeyEventArgs e)
        {
            if (buscador.Text != "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString().ToUpper().Contains(buscador.Text.ToUpper()))
                    {
                        dataGridView1.Rows[i].Visible = true;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Visible = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Visible = true;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cantidad.Text = dataGridView1.SelectedRows.Count.ToString();
        }

        private void AgregarListaArtistas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.listaArtistas.Hide();
        }

        private void buscador_Enter(object sender, EventArgs e)
        {
            if (insert && primero)
            {
                dataGridView1.ClearSelection();
                primero = false;
            }
            if(insert==false && primero)
            {
                CargarArtistas();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
