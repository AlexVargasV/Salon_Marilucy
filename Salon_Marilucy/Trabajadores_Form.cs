using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon_Marilucy
{
    public partial class Trabajadores_Form : Form
    {
        trabajador trabajador = new trabajador();
        public bool flag = false;
        public string idtrabajador = "";
        public Trabajadores_Form()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string apellidos = txtapellidos.Text;
            string cargo = txtcargo.Text;
            if(flag ==true)
            {
                flag = false;
                trabajador.actualizar(idtrabajador, nombre, apellidos, cargo);
                MostrarProductos();
                txtnombre.Clear();
                txtapellidos.Clear();
                txtcargo.Clear();

            }
            else
            {
                trabajador.insertartrabajador(nombre, apellidos, cargo);
                MostrarProductos();
                txtnombre.Clear();
                txtapellidos.Clear();
                txtcargo.Clear();
            }

        }
        private void MostrarProductos()
        {
            trabajador trabajador1 = new trabajador();
            dataGridView1.DataSource = trabajador.MostrarTrabajador();
        }

        private void Trabajadores_Form_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                flag = true;
                txtnombre.Text = dataGridView1.CurrentRow.Cells["Nombres"].Value.ToString();
                txtapellidos.Text = dataGridView1.CurrentRow.Cells["Apellidos"].Value.ToString();
                txtcargo.Text = dataGridView1.CurrentRow.Cells["Cargo"].Value.ToString();
                idtrabajador = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Por favor Seleccione una fila");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
    
                string id = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                trabajador.eliminar(id);
                MostrarProductos();

            }
            else
            {
                MessageBox.Show("Por favor Seleccione una fila");
            }
        }
    }
}
