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
    public partial class mirar_ingresos : Form
    {
        ingresos_diarios ingresos = new ingresos_diarios();

        public mirar_ingresos()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mirar_ingresos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            ingresos.CargarCombo(comboBox1);
        }
        private void MostrarProductos()
        {
            ingresos_diarios dia = new ingresos_diarios();
            dataGridView1.DataSource = dia.Mostraringresosdiarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingresos_diarios dia1 = new ingresos_diarios();
            dataGridView1.DataSource = dia1.Mostrarfiltro(comboBox1.SelectedItem.ToString());
        }
    }
}
