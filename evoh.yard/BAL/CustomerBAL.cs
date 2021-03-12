using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoh.yard.BAL
{
    public class CustomerBAL
    {
        db_Connection connection = new db_Connection();

        public int Add(string Query)
        {
            return connection.ExecuteQuery(Query);
        }

        public int Edit(string Query)
        {
            return connection.ExecuteQuery(Query);
        }

        public DataTable GetAll()
        {
            string Query = "Select * from tbCustomer";
            return connection.ExecuteDataTable(Query);
        }

        public DataTable GetbyId(int Id)
        {
            string Query = "Select * from tbCustomer  where Id=" + Id + "";
            return connection.ExecuteDataTable(Query);
        }

    }
}
