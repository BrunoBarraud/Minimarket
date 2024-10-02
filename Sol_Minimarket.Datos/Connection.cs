using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Sol_Minimarket.Datos
{
    public class Connection
    {
        public string DataBase;
        public string User;
        public string Password;
        public static Connection con = null;
    }

}
