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
    public partial class Ingresos_Form : Form
    {
        consumo ingresos = new consumo();
        String idcabecera = "";
        String idtrabajador = "";
        String idservicio = "";
        public Ingresos_Form()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btniniciar.Enabled = true;
            int total = ingresos.sumarprecios(idcabecera);
            String date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            ingresos.finalizarfecha(date,total,idcabecera);
            idcabecera = "";
            idservicio = "";
            idtrabajador = "";
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            btnfinalizar.Enabled = true;
            lblinicio.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            String date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            ingresos.actualizarfechainicio(date);
            idcabecera = ingresos.obtenerid(date);
            btniniciar.Enabled = false;
            btngenerar.Enabled = true;
            comboBox1.Enabled = true;
            comboservicio.Enabled = true;
            cmbmetododepago.Enabled = true;
            dataGridView1.DataSource = ingresos.MostrarDatos(idcabecera);

        }

        private void Ingresos_Form_Load(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboservicio.Enabled = false;
            cmbmetododepago.Enabled = false;
            btnfinalizar.Enabled = false;
            ingresos.CargarCombo(comboBox1);
            ingresos.CargarServicios(comboservicio);
            btngenerar.Enabled = false;
            txtprecio.Enabled = false;
            dataGridView1.DataSource = ingresos.MostrarDatos(idcabecera);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            String date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            ingresos.fechacreada = date;
            ingresos.nombreservicio = comboservicio.SelectedItem.ToString();
            ingresos.nombretrabajador = comboBox1.SelectedItem.ToString();
            string precio = ingresos.obtenerprecio(comboservicio.SelectedItem.ToString());
            string metodo = cmbmetododepago.SelectedItem.ToString();
            ingresos.metodo = cmbmetododepago.SelectedItem.ToString();
            ingresos.precio = precio;
            ingresos.imprimir(ingresos);
            ingresos.insertarconsumodiario(idtrabajador,idservicio,idcabecera,date,txtprecio.Text,metodo);
            dataGridView1.DataSource = ingresos.MostrarDatos(idcabecera);

        }

        private void comboservicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtprecio.Text = ingresos.obtenerprecio(comboservicio.SelectedItem.ToString());
            idservicio = ingresos.obteneridservicio(comboservicio.SelectedItem.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idtrabajador = ingresos.obteneridtrabajador(comboBox1.SelectedItem.ToString());
        }
    }
}
