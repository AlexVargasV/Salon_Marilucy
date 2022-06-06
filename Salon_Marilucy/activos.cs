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
    class activos
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
        public DataTable MostrarActivos()
        {
            con.Open();
            String sql = "SELECT idactivos as ID, nombre as Nombre, estado as Estado, cantidad as Cantidad, categoria as Categoria FROM activos where dbactivo = 0";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            tabla.Load(read);
            con.Close();
            return tabla;
        }

        public void insertaractivo(string nombre, string estado,string cantidad, string categoria)
        {

            con.Open();
            String sql = "INSERT INTO activos(nombre,estado,cantidad,categoria) VALUES('" + nombre + "','" + estado + "','" + cantidad+ "','" + categoria + "')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void actualizaractivo(string id, string nombre, string estado, string cantidad, string categoria)
        {
            con.Open();
            String sql = "UPDATE activos set nombre='" + nombre + "', estado= '" + estado + "', cantidad='" + cantidad + "', categoria='" + categoria +"' WHERE idactivos='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void eliminar(string id)
        {
            con.Open();
            String sql = " UPDATE activos set dbactivo=1 where idactivos='" + id + "'  ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
