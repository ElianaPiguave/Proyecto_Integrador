using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Login
    {
        CD_Conexion con = new CD_Conexion();
        SqlCommand cmd = new SqlCommand();
        public DataTable login(string usuario, string contra)
        {

            cmd.Connection = con.abrir_Conexion();
            cmd.CommandText = "procedimiento almacenado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@baseatos", usuario);
            cmd.Parameters.AddWithValue("@baseatos", contra);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;



}
    }
}
