using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    public class ListUser
    {
         private static ListUser instance;

        private List<User> listAccountUser;

        public List<User> listAccounttUser
        {
            get => listAccountUser; set => listAccountUser = value;
        }
        public static ListUser Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ListUser();
                }
                return instance;
            } 
            set => instance = value; 
        }

        private ListUser()
        {
            listAccountUser = new List<User>();
            listAccountUser.Add(new User("doannam", "220600",false));
            listAccountUser.Add(new User("namy", "220600", true));
            listAccountUser.Add(new User("myna", "1622",false));
        }
    }
}
