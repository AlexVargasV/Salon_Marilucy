using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace Salon_Marilucy
{
    class ingresos_diarios
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
        DataTable tabla = new DataTable();
        public DataTable Mostraringresosdiarios()
        {
            con.Open();
            String sql = "SELECT idingresos as ID, fecha_inicio as Apertura, fecha_cierre as Clausura, total as Ganancia FROM `ingresos`";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            tabla.Load(read);
            con.Close();
            return tabla;
        }

        public DataTable Mostrarfiltro(string fecha)
        {
            con.Open();
            String sql = "SELECT idingresos as ID, fecha_inicio as Apertura, fecha_cierre as Clausura, total as Ganancia FROM `ingresos` WHERE fecha_inicio = '"+fecha+"'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            tabla.Load(read);
            con.Close();
            return tabla;
        }

        public void CargarCombo(ComboBox combo1)
        {
            con.Open();
            String sql = "SELECT fecha_inicio FROM  ingresos";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                combo1.Items.Add(read.GetString(0));
            }
            con.Close();
        }

    }
}
