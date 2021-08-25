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
            cmd.CommandText = "MostrarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            leer = cmd.ExecuteReader();
            tabla.Load(leer);
            con.cerrar_Conexion();
            return tabla;

        }
        public void insertar(string cli_nombre, string cli_apellido, DateTime cli_fecha_na, int cli_cedula, string cli_direccion, int cli_telefono, string cli_email)
        {
            cmd.Connection = con.abrir_Conexion();
            cmd.CommandText = "Procedimiento";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cli_nombre", cli_nombre);
            cmd.Parameters.AddWithValue("@cli_apellido", cli_apellido);
            cmd.Parameters.AddWithValue("@cli_fechaN", cli_fecha_na);
            cmd.Parameters.AddWithValue("@cli_cedula", cli_cedula);
            cmd.Parameters.AddWithValue("@cli_direccion", cli_direccion);
            cmd.Parameters.AddWithValue("@cli_telefono", cli_telefono);
            cmd.Parameters.AddWithValue("@cli_email", cli_email);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.cerrar_Conexion();
        }





    }
}
