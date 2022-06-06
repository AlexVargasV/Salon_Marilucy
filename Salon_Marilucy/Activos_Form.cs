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
    public partial class Activos_Form : Form
    {
        activos activo = new activos();
        bool flag = false;
        public string idactivo = "";
        public Activos_Form()
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
            string estado = cmbestado.SelectedItem.ToString();
            string cantidad = txtcantidad.Text;
            string categoria = txtcategoria.Text;
            if(flag == true)
            {
                flag = false;
                activo.actualizaractivo(idactivo, nombre, estado, cantidad, categoria);
                MostrarProductos();
            }
            else
            {
                activo.insertaractivo(nombre, estado, cantidad, categoria);
                txtnombre.Clear();
                txtcantidad.Clear();
                txtcategoria.Clear();
                cmbestado.Text = "";
                MostrarProductos();
            }

        }
        private void MostrarProductos()
        {
            activos act = new activos();
            dataGridView1.DataSource = act.MostrarActivos();
        }

        private void Activos_Form_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                flag = true;
                txtnombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                cmbestado.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                txtcategoria.Text = dataGridView1.CurrentRow.Cells["Categoria"].Value.ToString();
                txtcantidad.Text = dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString();
                idactivo = dataGridView1.CurrentRow.Cells["ID"].Value.ToString(); 

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
                activo.eliminar(id);
                MostrarProductos();
            }
            else
            {
                MessageBox.Show("Por favor Seleccione una fila");
            }
        }
    }
}
