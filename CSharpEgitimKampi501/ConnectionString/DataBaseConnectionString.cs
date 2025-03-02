using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.ConnectionString
{
    public class DataBaseConnectionString
    {
        public static void SqlDatabaseConnectionString()
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-ELIF;initial Catalog=EgitimKampi501Db;integrated security=true");

        }
    }
}
