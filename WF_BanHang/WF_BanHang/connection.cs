using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BanHang
{
    internal class connection
    {
        private static string strConnection = @"server = NAMY-SP\NAMY; database = QL_ThuVien_WF;Integrated Security=True ";
        
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(strConnection);
        }
    }

}
