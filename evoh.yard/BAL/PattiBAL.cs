using evoh.yard.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoh.yard.BAL
{
    public class PattiBAL
    {

        db_Connection connection = new db_Connection();
        SqlConnection sqlConnection = new SqlConnection("Data Source=(local);Initial Catalog=db_Yard;Integrated Security=True");
        SqlTransaction transaction;
        SqlCommand command;

        public int Add(PattiHeader pattiHeader, List<Patti> patti)
        {
            sqlConnection.Open();
            transaction = sqlConnection.BeginTransaction();
            try
            {
                string Query1 = "sp_tbPattiHeader_ups " + 0 + ",'" + pattiHeader.CustomerId + "','" + pattiHeader.VNo + "','" + pattiHeader.TotalBag + "','" + pattiHeader.TotalKg + "','" + pattiHeader.TotalAMT + "',1";
                command = new SqlCommand(Query1, sqlConnection, transaction);
                var dataId= command.ExecuteScalar();

                foreach (var data in patti)
                {
                    string Query2 = "sp_tbPatti_ups " + 0 + "," + dataId + ",'" + data.ItemId + "','" + data.Bag + "','" + data.Kg + "','" + data.Price + "','" + data.Total + "','admin',1";
                    command = new SqlCommand(Query2, sqlConnection, transaction);
                    command.ExecuteNonQuery();
                }
                

                transaction.Commit();
                //sqlConnection.Close();
                return Convert.ToInt32(dataId);
            }
            catch (SqlException sqlError)
            {
                transaction.Rollback();
                sqlConnection.Open();
            }
            sqlConnection.Close();
            return 0;
        }

        public int Edit(string Query)
        {
            return connection.ExecuteQuery(Query);
        }

        public DataTable GetAll(string Query)
        {
            return connection.ExecuteDataTable(Query);
        }

        public DataTable GetbyId(string Query)
        {
            return connection.ExecuteDataTable(Query);
        }


    }
}
