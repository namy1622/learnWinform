using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    internal class Const
    {
        public static bool AccountType;

        public static List<string> ListDepartment = new List<string> { "Phong nhan su", "Phong IT", "Phong ke toan", "Phong van tai", "Phong maketing" };


        // biến lưu dl tạm thơi của biên Employee 
        public static Employee NewEmployee = null;

        public static List<string> listSex = new List<string> { "Nam", "Nữ", "Không xác định" };

        public static List<string> listContract = new List<string>() { "Đang công tác", "Đã nghỉ" };
    }
}
