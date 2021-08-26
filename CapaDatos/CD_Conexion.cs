using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class CD_Conexion
    {
        //cadena de conexion
        private SqlConnection cn = new SqlConnection("Data Source = DESKTOP - OF5SBBD; Initial Catalog = Proyecto; Integrated Security = True");

        //metodo de apertura y cierre de la conexion



        public SqlConnection abrir_Conexion()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            return cn;
        }
        public SqlConnection cerrar_Conexion()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            return cn;
        }
    }
}
