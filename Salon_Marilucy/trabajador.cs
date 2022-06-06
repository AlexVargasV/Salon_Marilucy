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
    class trabajador
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
        public DataTable MostrarTrabajador()
        {
            con.Open();
            String sql = "SELECT idtrabajador as ID, nombres as Nombres, apellidos as Apellidos, cargo as Cargo FROM trabajador where dbactivo = 0";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            tabla.Load(read);
            con.Close();
            return tabla;
        }
        public void insertartrabajador(string nombres, string apellidos, string cargo)
        {

            con.Open();
            String sql = "INSERT INTO trabajador(nombres,apellidos,cargo) VALUES('" + nombres + "','" + apellidos + "','" + cargo +"')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void actualizar(string id, string nombres, string apellidos, string cargo)
        {
            con.Open();
            String sql = "UPDATE trabajador set nombres='" + nombres + "', apellidos= '" + apellidos + "', cargo='" + cargo + "' WHERE idtrabajador='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void eliminar(string id)
        {
            con.Open();
            String sql = " UPDATE trabajador set dbactivo=1 where idtrabajador='" + id + "'  ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
