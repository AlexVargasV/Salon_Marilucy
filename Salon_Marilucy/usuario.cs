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
    class usuario
    {
       public string restriccion = "";
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
        public String userid = "";
        public bool login(string user, string pass)
        {
            bool flag = false;
            String sql = "SELECT * FROM `usuarios` WHERE usuario= '"+user+"'and contraseña = '"+pass+"'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql,con);
            MySqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                flag = true;
            }
            con.Close();
            return flag;
        }

        public bool permisos(string user, string pass)
        {
            String valor = "";
            bool flag = false;
            String sql = "SELECT permisos FROM `usuarios` WHERE usuario= '" + user + "'and contraseña = '" + pass + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                valor = String.Format("{0}", read[0]);
                restriccion = valor;
            }
            if(valor == "1")
            {
                flag = true;
            }
            con.Close();
            return flag;
        }

        public string getnombre(string user, string pass)
        {
            String valor = "";
            String valor2 = "";
            string nombre_completo = "";
            String sql = "SELECT nombre FROM `usuarios` WHERE usuario= '" + user + "'and contraseña = '" + pass + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                valor = String.Format("{0}", read[0]);
            }
            con.Close();
            String sql2 = "SELECT apellidos FROM `usuarios` WHERE usuario= '" + user + "'and contraseña = '" + pass + "'";
            con.Open();
            MySqlCommand cmd2 = new MySqlCommand(sql2, con);
            MySqlDataReader read2 = cmd2.ExecuteReader();
            while (read2.Read())
            {
                valor2 = String.Format("{0}", read2[0]);
            }
            nombre_completo = valor +" "+ valor2;
            con.Close();

            return nombre_completo;
        }
        public string getid(string user, string pass)
        {
            String valor = "";
            String sql = "SELECT iduser FROM `usuarios` WHERE usuario= '" + user + "'and contraseña = '" + pass + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                valor = String.Format("{0}", read[0]);
            }
            con.Close();
            userid = valor;
            return valor;
        }
        DataTable tabla = new DataTable();
        public DataTable MostrarDatos(string dato)
        {
            con.Open();
            String sql = "SELECT * FROM `" + dato+ "` where dbactivo = 0";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            tabla.Load(read);
            con.Close();
            return tabla;
        }

        public DataTable MostrarServicios()
        {
            con.Open();
            String sql = "SELECT nombre as Nombre, precio as Precio FROM servicios where dbactivo = 0";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            tabla.Load(read);
            con.Close();
            return tabla;
        }

        public void CargarCombo(ComboBox combo1)
        {
            con.Open();
            String sql = "SELECT nombre_categoria FROM categoria";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                combo1.Items.Add(read.GetString(0));
            }
            con.Close();
        }


        public void insertarusuario(string nombre, string apellidos, string ci, string permisos, string usuario, string contraseña)
        {

            con.Open();
            String sql = "INSERT INTO usuarios(nombre,apellidos,ci,permisos,usuario,contraseña) VALUES('" + nombre+"','"+apellidos+"','"+ci+"','"+permisos+"','"+usuario+"','"+contraseña+"')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void insertarservicio(int idcat, string nombre, int precio)
        {
            con.Open();
            String sql = "INSERT INTO servicios(CATEGORIA_idcategoria,nombre,precio) VALUES('" + idcat + "','" + nombre+ "','" + precio +"')";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void actualizar(int id, string nombre, string apellidos, string ci, string permisos, string usuario, string contraseña)
        {
            con.Open();
            String sql = "UPDATE usuarios set nombre='"+nombre+"', apellidos= '"+apellidos+"', ci='"+ci+"', permisos='"+permisos+"', usuario='"+usuario+"', contraseña='"+contraseña+"' WHERE iduser='"+id+"'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void actualizar_servicios(int idcat, string nombre, int precio)
        {
            con.Open();
            String sql = "UPDATE servicios set CATEGORIA_idcategoria='" + idcat + "', nombre='" + nombre + "', precio='" + precio + "' WHERE nombre='" + nombre + "'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void eliminar(string id)
        {
            con.Open();
            String sql = " UPDATE usuarios set dbactivo=1 where iduser='"+id+"'  ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void eliminarServicio(string nombre)
        {
            con.Open();
            String sql = " UPDATE servicios set dbactivo=1 where nombre='" + nombre + "'  ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int obtener_id(string nombre)
        {
            int valor = 0;
            con.Open();
            String sql = "SELECT idcategoria FROM `categoria` WHERE nombre_categoria = '"+nombre+"'";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                valor = Convert.ToInt32(String.Format("{0}", read[0]));
            }
            con.Close();
            return valor;
        }

    }
}
