using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Travel_World
{
    public class Connect
    {
        public SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Travel_World;Integrated Security=True;");
           
   
     
        public SqlDataReader Connection(string query)
        {
            connect.Open();

            string Query = query;
            SqlCommand cmd = new SqlCommand(Query, connect);
            var reader = cmd.ExecuteReader();


            return reader;
        }

        public void close()
        { connect.Close(); }


    }
}
