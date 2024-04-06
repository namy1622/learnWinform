using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WF_BanHang
{
    internal class Modify
    {
        public Modify()
                {
                }


        SqlDataAdapter dataAdapter; // truy xuat dl vaof bang
        SqlCommand sqlCommand; // truy xuat de them, sua, xoa ...

        
        public DataTable Table(string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public void Command(string query)
        {
            using(SqlConnection sqlConnection = connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }

    
}
