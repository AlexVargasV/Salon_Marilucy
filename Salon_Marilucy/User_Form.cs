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
    public partial class User_Form : Form
    {
        usuario user = new usuario();
        private int id = 0;
        bool flag = false;
        

        public User_Form()
        {
            InitializeComponent();
            dataGridView1.DataSource = user.MostrarDatos("usuarios");
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }
        private void MostrarProductos()
        {
            dataGridView1.DataSource = user.MostrarDatos("usuarios");
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string apellido = txtapellidos.Text;
            string ci = txtci.Text;
            string permisos = "";
            if (comboBox1.Text == "Usuario")
            {
                permisos = "0";
            }
            else
            {
                permisos = "1";
            }
            string usuario = txtusuario.Text;
            string contraseña = txtcontraseña.Text;

            if (flag== true)
            {
                user.actualizar(id, nombre, apellido, ci, permisos, usuario, contraseña);
                flag = false;
                MostrarProductos();
            }
            else
            {
                user.insertarusuario(nombre, apellido, ci, permisos, usuario, contraseña);
                
            }
            txtnombre.Clear();
            txtapellidos.Clear();
            txtci.Clear();
            comboBox1.Text = "";
            txtusuario.Clear();
            txtcontraseña.Clear();
            MostrarProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                flag = true;
                txtnombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                txtapellidos.Text = dataGridView1.CurrentRow.Cells["apellidos"].Value.ToString();
                txtci.Text = dataGridView1.CurrentRow.Cells["ci"].Value.ToString();
                String valorcombo = dataGridView1.CurrentRow.Cells["permisos"].Value.ToString();
                if (valorcombo == "0")
                    {
                    comboBox1.SelectedIndex = 0;
                    }
                if (valorcombo == "1")
                {
                    comboBox1.SelectedIndex = 1;
                }
                txtusuario.Text = dataGridView1.CurrentRow.Cells["usuario"].Value.ToString();
                txtcontraseña.Text = dataGridView1.CurrentRow.Cells["contraseña"].Value.ToString();
                string valor = dataGridView1.CurrentRow.Cells["iduser"].Value.ToString();
                 id = Convert.ToInt32(valor);
                

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
                string valor = dataGridView1.CurrentRow.Cells["iduser"].Value.ToString();
                user.eliminar(valor);
                MessageBox.Show("Datos Eliminados Correctamente");
                dataGridView1.DataSource = user.MostrarDatos("usuarios");
            }
            else
            {
                MessageBox.Show("Por favor Seleccione una fila para eliminar");
            }


            
        }
    }
}
