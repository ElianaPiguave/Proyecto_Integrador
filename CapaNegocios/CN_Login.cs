using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Login
    {
        private CD_Login objetoCD = new CD_Login();
        public DataTable  Logeo(string usuario, string contra)
        {
       
        objetoCD.login(usuario, contra);

            return objetoCD.login(usuario,contra);
        }

    }
}
