using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace evoh.yard
{
    public class db_Connection
    {

        SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=db_Yard;Integrated Security=True");
        SqlCommand command;//= new SqlCommand();
        SqlDataAdapter adapter;//= new SqlCommand();
        DataTable table;

       

        public int ExecuteQuery(string Query)
        {   
            command = new SqlCommand(Query, connection);
            connection.Open();
            int i= command.ExecuteNonQuery();
            connection.Close();
            return i;
        }

        public object ExecuteScalar(string Query)
        {
            command = new SqlCommand(Query, connection);
            connection.Open();
            var i = command.ExecuteScalar();
            connection.Close();
            return i;
        }

        public DataTable ExecuteDataTable(string Query)
        {
            table = new DataTable();
            connection.Open();
            adapter = new SqlDataAdapter(Query, connection);
            adapter.Fill(table);
            connection.Close();
            return table;
        }

    }
}
