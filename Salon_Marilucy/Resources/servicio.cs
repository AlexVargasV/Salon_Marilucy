using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Salon_Marilucy.Resources
{
    class servicio
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

        public void insertarservicio(int idcat, string nombre, int precio)
        {
            con.Open();
            String sql = "INSERT INTO servicios(CATEGORIA_idcategoria,nombre,precio) VALUES('" + idcat + "','" + nombre + "','" + precio + "')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
