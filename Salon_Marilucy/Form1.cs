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
    public partial class Form1 : Form
    {
        usuario user = new usuario();
        public Form1()
        {
            InitializeComponent();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string usuario = Convert.ToString(txtuser.Text);
            string password = Convert.ToString(txtcontrasenia.Text);
            bool existe = user.login(usuario, password);
            bool permisos = user.permisos(usuario, password);
            if (existe == false && permisos == false)
            {
                MessageBox.Show("El Usuario no Existe");
            }
            if (existe == true && permisos == false)
            {
                MessageBox.Show("El usuario es un usuario normal");
                this.Hide();
                FormWelcome FW = new FormWelcome(user.getnombre(usuario, password), user.getid(usuario, password));
                main_form MF = new main_form();
                FW.ShowDialog();
                MF.Show();
            }
            if (existe == true && permisos == true)
            {
                MessageBox.Show("El usuario es un usuario administrador");
                this.Hide();
                FormWelcome FW = new FormWelcome(user.getnombre(usuario, password), user.getid(usuario, password));
                main_form MF = new main_form();
                FW.ShowDialog();
                MF.Show();
            }
            

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if(txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtcontrasenia_Enter(object sender, EventArgs e)
        {
            if (txtcontrasenia.Text == "CONTRASEÑA")
            {
                txtcontrasenia.Text = "";
                txtcontrasenia.ForeColor = Color.LightGray;
                txtcontrasenia.UseSystemPasswordChar = true;
            }
        }

        private void txtcontrasenia_Leave(object sender, EventArgs e)
        {
            if (txtcontrasenia.Text == "")
            {
                txtcontrasenia.Text = "CONTRASEÑA";
                txtcontrasenia.ForeColor = Color.DimGray;
                txtcontrasenia.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
