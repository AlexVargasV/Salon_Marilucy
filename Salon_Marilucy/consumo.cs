using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;

namespace Salon_Marilucy
{
    class consumo
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=mary_lucy; Uid=root;  Pwd=;");
        public void coneccion()
        {
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool actualizarfechainicio(String inicio)
        {
            con.Open();
            String sql = "INSERT INTO ingresos(USUARIOS_iduser,fecha_inicio,dbactivo) VALUES('1','" + inicio + "','1')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;

        }
        public string obtenerid(string fecha)
        {
            string id = "";
            con.Open();
            String sql = "SELECT idingresos FROM ingresos where fecha_inicio='" + fecha + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                id = read.GetString(0);
            }
            con.Close();
            return id;
        }
        public string obtenerprecio(string nombreservicio)
        {
            string costo = "";
            con.Open();
            String sql = "SELECT precio FROM servicios where nombre='" + nombreservicio + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                costo = read.GetString(0);
            }
            con.Close();
            return costo;
        }
        public string obteneridservicio(string nombreservicio)
        {
            string idservicio = "";
            con.Open();
            String sql = "SELECT idservicios FROM servicios where nombre='" + nombreservicio + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                idservicio = read.GetString(0);
            }
            con.Close();
            return idservicio;
        }
        public string obteneridtrabajador(string nombretrabajador)
        {
            string[] nombreseparado = nombretrabajador.Split(new char[] { ' ' });
            string id = "";
            con.Open();
            String sql = "SELECT idtrabajador FROM trabajador where nombres='" + nombreseparado[0] + "' AND apellidos='" + nombreseparado[1] + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                id = read.GetString(0);
            }
            con.Close();
            return id;
        }

        public void CargarCombo(ComboBox combo1)
        {
            con.Open();
            String sql = "SELECT nombres,apellidos FROM trabajador WHERE dbactivo = 0";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                string apellidos = read.GetString(1);
                combo1.Items.Add(read.GetString(0) + " " + apellidos);
            }
            con.Close();
        }
        public void CargarServicios(ComboBox combo1)
        {
            con.Open();
            String sql = "SELECT nombre FROM servicios WHERE dbactivo = 0";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                combo1.Items.Add(read.GetString(0));
            }
            con.Close();
        }

        public void insertarconsumodiario(string idtrabajador, string idservicios, string idcabecera, string horadegeneracion, string costo, string mpago)
        {
            con.Open();
            String sql = "INSERT INTO ingresos_diarios(TRABAJADOR_idtrabajador,SERVICIOS_idservicios,INGRESOS_idingresos,hora_generacion,costo,tipo_de_pago) VALUES('" + idtrabajador + "','" + idservicios + "','" + idcabecera + "','" + horadegeneracion + "','" + costo + "','" + mpago + "')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        DataTable tabla = new DataTable();
        public DataTable MostrarDatos(string idingresos)
        {
            con.Open();
            String sql = "SELECT trabajador.nombres as Nombre,trabajador.apellidos as Apellido,servicios.nombre as Servicio,ingresos_diarios.hora_generacion as Hora,ingresos_diarios.costo as Costo, ingresos_diarios.tipo_de_pago as Pago FROM `ingresos_diarios` JOIN `trabajador` ON ingresos_diarios.TRABAJADOR_idtrabajador = trabajador.idtrabajador JOIN `servicios` ON ingresos_diarios.SERVICIOS_idservicios = servicios.idservicios WHERE INGRESOS_idingresos = '"+idingresos+"'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            tabla.Load(read);
            con.Close();
            return tabla;
        }
        public int sumarprecios(string idingresos)
        {
            con.Open();
            String sql = "SELECT SUM(costo) FROM ingresos_diarios where INGRESOS_idingresos = '"+idingresos+"'";
            int total = 0;
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                total = Convert.ToInt32( read.GetString(0));
            }
            con.Close();

            return total;
        }
        public bool finalizarfecha(String final, int total, string idcabecera)
        {
            con.Open();
            String sql = "UPDATE ingresos SET fecha_cierre = '"+final+"', total = '"+total+"' WHERE idingresos = '"+idcabecera+"'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;

        }

        private PrintDocument doc = new PrintDocument();
        private PrintPreviewDialog vista = new PrintPreviewDialog();
        public void imprimir(consumo p)
        {
            doc.PrinterSettings.PrinterName = doc.DefaultPageSettings.PrinterSettings.PrinterName;
            doc.PrintPage += new PrintPageEventHandler(imprimirticket);
            vista.Document = doc;
            vista.Show();
            //doc.Print();

            
        }
        public string nombreservicio { get; set; }
        public string nombretrabajador { get; set; }

        public string fechacreada { get; set; }

        public string precio { get; set; }

        public string metodo { get; set; }
        public void imprimirticket(object sender, PrintPageEventArgs e)
        {
            int posx, posy;
            Font fuente = new Font("consola", 15, FontStyle.Bold);
            try
            {
                posx = 10;
                posy = 10;
                posy += 110;
                e.Graphics.DrawString("Salon Mary Lucy",fuente,Brushes.Black,posx,posy);
                posy += 20;
                e.Graphics.DrawString(nombreservicio, fuente, Brushes.Black, posx, posy);
                posy += 20;
                e.Graphics.DrawString(fechacreada, fuente, Brushes.Black, posx, posy);
                posy += 20;
                e.Graphics.DrawString(nombretrabajador, fuente, Brushes.Black, posx, posy);
                posy += 25;
                e.Graphics.DrawString(precio, fuente, Brushes.Black, posx, posy);
                posy += 25;
                e.Graphics.DrawString(metodo, fuente, Brushes.Black, posx, posy);
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message); 
            }

        }


    }
}
