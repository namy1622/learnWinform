using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Logout
{
    internal class ListTaiKhoan
    {
        private static ListTaiKhoan instance;

        internal static ListTaiKhoan Instance {
            get
            {
                if(instance == null)
                    instance = new ListTaiKhoan();
                return instance;
            }
            set => instance = value; 
        }

        List<TaiKhoan> listTaiKhoan;

        internal List<TaiKhoan> ListTaiKhoan_list { 
            get => listTaiKhoan; 
            set => listTaiKhoan = value; 
        }
       

        ListTaiKhoan()
        {
            listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan.Add(new TaiKhoan("doannam","2206"));
            listTaiKhoan.Add(new TaiKhoan("namhus", "0000"));
            listTaiKhoan.Add(new TaiKhoan("daodao", "1111"));
        }
    }
}
