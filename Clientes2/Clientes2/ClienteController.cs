using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Clientes2
{
    public static class ClienteController
    {

        public static List<Cliente> ObtenerClientes()
        {

            List<Cliente> lista = new List<Cliente>();
            using (SqlConnection con = new SqlConnection(Conexion.ConexionSQL))
            {
                con.Open();
                DataTable dt = new DataTable();
                string query = "SELECT * FROM Corporativo.Clientes";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.ID_Cliente = int.Parse(row["ID_Cliente"].ToString());
                    cliente.RFC = row["RFC"].ToString();
                    cliente.Nombre = row["Nombre"].ToString();
                    cliente.Paterno = row["ApellidoPaterno"].ToString();
                    cliente.Materno = row["ApellidoMaterno"].ToString();
                    cliente.Activo = int.Parse(row["Activo"].ToString());

                    lista.Add(cliente);

                }

            }

            return lista;
        }

        public static Cliente ObtenerClientesPorID(int ID_Cliente)
        {

            Cliente cliente = new Cliente();
            using (SqlConnection con = new SqlConnection(Conexion.ConexionSQL))
            {
                con.Open();
                DataTable dt = new DataTable();
                string query = "SELECT * FROM Corporativo.Clientes where ID_Cliente = @ID_Cliente";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);

                foreach (DataRow row in dt.Rows)
                { 
                    cliente.ID_Cliente = int.Parse(row["ID_Cliente"].ToString());
                    cliente.RFC = row["RFC"].ToString();
                    cliente.Nombre = row["Nombre"].ToString();
                    cliente.Paterno = row["ApellidoPaterno"].ToString();
                    cliente.Materno = row["ApellidoMaterno"].ToString();
                    cliente.Activo = int.Parse(row["Activo"].ToString());
                      
                }
            }
            return cliente;
        }

        public static bool GuardarCliente(Cliente nuevo)
        {

            using (SqlConnection con = new SqlConnection(Conexion.ConexionSQL))
            {
                SqlCommand com = new SqlCommand();

                con.Open();

                com.Connection = con;

                com.CommandText = @"INSERT INTO Corporativo.Clientes (RFC, Nombre, ApellidoPaterno, ApellidoMaterno, Activo,RegistroAlta) VALUES (@RFC, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @Activo, getdate())";
                com.Parameters.AddWithValue("@RFC", nuevo.RFC);
                com.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                com.Parameters.AddWithValue("@ApellidoPaterno", nuevo.Paterno);
                com.Parameters.AddWithValue("@ApellidoMaterno", nuevo.Materno);
                com.Parameters.AddWithValue("@Activo", nuevo.Activo);
                com.ExecuteNonQuery();

                con.Close();
            } 
            return true;
        }
         
        public static bool EliminarCliente(int ID_Cliente)
        {
            using (SqlConnection con = new SqlConnection(Conexion.ConexionSQL))
            {
                SqlCommand com = new SqlCommand();

                con.Open();

                com.Connection = con;

                com.CommandText = @"delete from Corporativo.Clientes where ID_Cliente = @ID_Cliente";
                com.Parameters.AddWithValue("@ID_Cliente", ID_Cliente); 
                com.ExecuteNonQuery();

                con.Close();
            }
            return true;
        }

        public static  bool ActualizarCliente(Cliente actualizar)
        {
            using (SqlConnection con = new SqlConnection(Conexion.ConexionSQL))
            {
                SqlCommand com = new SqlCommand();

                con.Open();

                com.Connection = con;

                com.CommandText = @"UPDATE Corporativo.Clientes SET RFC = @RFC, Nombre=@Nombre, ApellidoPaterno=@ApellidoPaterno, ApellidoMaterno=@ApellidoMaterno, Activo=@Activo, RegistroAlta=getdate() WHERE ID_Cliente = @ID_Cliente";
                com.Parameters.AddWithValue("@ID_Cliente", actualizar.ID_Cliente);
                com.Parameters.AddWithValue("@RFC", actualizar.RFC);
                com.Parameters.AddWithValue("@Nombre", actualizar.Nombre);
                com.Parameters.AddWithValue("@ApellidoPaterno", actualizar.Paterno);
                com.Parameters.AddWithValue("@ApellidoMaterno", actualizar.Materno);
                com.Parameters.AddWithValue("@Activo", actualizar.Activo);
                com.ExecuteNonQuery();

                con.Close();
            }
            return true;           
        }
    }
}
