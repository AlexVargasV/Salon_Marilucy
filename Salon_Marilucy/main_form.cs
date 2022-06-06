using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Salon_Marilucy
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);
        private void main_form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnslide_Click(object sender, EventArgs e)
        {
            if(Menu_Vertical.Width == 250)
            {
                Menu_Vertical.Width = 74;
            }
            else
            {
                Menu_Vertical.Width = 250;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Barra_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Abrirforminpanel(object formhijo)
        {
            if (this.Panel_Contenedor.Controls.Count > 0)
                this.Panel_Contenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_Contenedor.Controls.Add(fh);
            this.Panel_Contenedor.Tag = fh;
            fh.Show();
        }
        private void btnqr_Click(object sender, EventArgs e)
        {
            Abrirforminpanel(new gestorqrform());
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            Abrirforminpanel(new User_Form());
        }

        private void btnservicios_Click(object sender, EventArgs e)
        {
            Abrirforminpanel(new Servicios_Form());
        }

        private void btnactivos_Click(object sender, EventArgs e)
        {
            Abrirforminpanel(new Activos_Form());
        }

        private void btningresos_Click(object sender, EventArgs e)
        {
            Abrirforminpanel(new Ingresos_Form());
        }

        private void btntrabajadores_Click(object sender, EventArgs e)
        {
            Abrirforminpanel(new Trabajadores_Form());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abrirforminpanel(new mirar_ingresos());
        }
    }
}
