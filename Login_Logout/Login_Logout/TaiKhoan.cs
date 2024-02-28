using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Logout
{
    internal class TaiKhoan
    {
        private string tenTaiKhoan;
        private string tenMatKhau;

        public string TenTaiKhoan {
            get => tenTaiKhoan; 
            set => tenTaiKhoan = value; 
        }
        public string TenMatKhau { 
            get => tenMatKhau; 
            set => tenMatKhau = value; 
        }

        public TaiKhoan(string tenTaiKhoan, string tenMatKhau)
        {
            this.TenTaiKhoan = tenTaiKhoan;
            this.TenMatKhau = tenMatKhau;
		// nam sua 
            
        }
    }
}
