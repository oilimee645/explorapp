using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ExplorAppTeo
{
    class MySQLconect
    {
        string usr;
        string pass;
        public MySQLconect(string User, string Password)
        {
            usr =User;
            pass = Password;
        }

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

        public bool Conexion(out string Error)
        {
            builder.Server = "65.99.252.14";
            builder.Database = "explorap_conteo";
            builder.UserID = usr;
            builder.Password = pass;
            try
            {
                MySqlConnection ms = new MySqlConnection(builder.ToString());
                ms.Open();
                Error = "";
                return true;
            }catch(Exception ex)
            {
                Error = ex.ToString();
                return false;
            }


        }

        internal bool TryConnection(out string error)
        {
            throw new NotImplementedException();
        }
    }

   
}
