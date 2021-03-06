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
    public partial class Servicios_Form : Form
    {
        bool flag = false;
        usuario user = new usuario();
        public Servicios_Form()
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
            int precio = Convert.ToInt32(txtprecio.Text);
            int idproducto = user.obtener_id(cmbcategoria.SelectedItem.ToString());
            if (flag == true)
            {
                
                flag = false;
                user.actualizar_servicios(idproducto,nombre,precio);
                MostrarProductos();
            }
            else
            {
                user.insertarservicio(idproducto,nombre,precio);

            }
            txtnombre.Clear();
            txtprecio.Clear();
            cmbcategoria.Text = "";
            MostrarProductos();
           

        }
        private void MostrarProductos()
        {
            usuario user1 = new usuario();
            dataGridView1.DataSource = user1.MostrarServicios();
        }
        private void Servicios_Form_Load(object sender, EventArgs e)
        {
            user.CargarCombo(cmbcategoria);
            MostrarProductos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                flag = true;
                txtnombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtprecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                if (cmbcategoria.Text != " ")
                {

                    //button2.Visible = false;
                }
                else
                {
                    MessageBox.Show("Por Favor llene el campo categoria");
                }
        

            }
            else
            {
                MessageBox.Show("Por favor Seleccione una fila");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                user.eliminarServicio(nombre);
                MostrarProductos();
            }
            else
            {
                MessageBox.Show("Por favor Seleccione una fila");
            }
        }
    }
}
