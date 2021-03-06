using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Cliente
    {

        CD_Conexion con = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable mostrar()
        {
            cmd.Connection = con.abrir_Conexion();
            cmd.CommandText = "MostrarClientes";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            con.cerrar_Conexion();
            return tabla;

        }
        public void insertar(string cl_nombre, string cl_apellido, int cl_cedula, string cl_direccion, int cl_telefono, string cl_email)
        {
            cmd.Connection = con.abrir_Conexion();
            cmd.CommandText = "InsertarClientes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cl_nombre", cl_nombre);
            cmd.Parameters.AddWithValue("@cl_apellido", cl_apellido);
            cmd.Parameters.AddWithValue("@cl_cedula", cl_cedula);
            cmd.Parameters.AddWithValue("@cl_direccion", cl_direccion);
            cmd.Parameters.AddWithValue("@cl_telefono", cl_telefono);
            cmd.Parameters.AddWithValue("@cl_email", cl_email);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.cerrar_Conexion();
        }

        public void editar(string nombre, string apellido, string cedula, string direccion, string telefono, string email,int id)
        {
            cmd.Connection = con.abrir_Conexion();
            cmd.CommandText = "EditarClientes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cl_nombre", nombre);
            cmd.Parameters.AddWithValue("@cl_apellido", apellido);
            cmd.Parameters.AddWithValue("@cl_cedula", cedula);
            cmd.Parameters.AddWithValue("@cl_direccion", direccion);
            cmd.Parameters.AddWithValue("@cl_telefono", telefono);
            cmd.Parameters.AddWithValue("@cl_email", email);
            cmd.Parameters.AddWithValue("@cl_id", id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.cerrar_Conexion();
        }



    }
}
