using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Logout
{
    public partial class Form1 : Form
    {
        List<TaiKhoan> listTaiKhoan = ListTaiKhoan.Instance.ListTaiKhoan_list;
        public Form1()
        {

            InitializeComponent();

            
              
                this.BackColor = Color.Brown; // Màu nền
                this.ForeColor = Color.Black; // Màu văn bản

                // Đặt sự kiện thay đổi màu sắc khi nhận hoặc mất focus
                this.GotFocus += (sender, e) => this.BackColor = Color.White;
                this.LostFocus += (sender, e) => this.BackColor = Color.LightGray;
            

        }




        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (testDangNhap(txbTaiKhoan.Text, txbMatKhau.Text))
            {
                Main_1 main_1 = new Main_1();
                main_1.Show();
                this.Hide();
                main_1.DangXuat += Main_1_DangXuat;
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu. Vui lòng kiểm tra lại !");
            }
            
        }

        private void Main_1_DangXuat(object sender, EventArgs e)
        {
            (sender as Main_1).isThoat = false;
            (sender as Main_1).Close();
            this.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool testDangNhap(string taiKhoan, string matKhau)
        {
           for(int i = 0; i < listTaiKhoan.Count; i++)
            {
                if(taiKhoan == listTaiKhoan[i].TenTaiKhoan && matKhau == listTaiKhoan[i].TenMatKhau)
                {
                    return true;
                }
            }

            return false;
        }

        private void txbTaiKhoan_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void txbTaiKhoan_StyleChanged(object sender, EventArgs e)
        {

        }

        private void txbTaiKhoan_BorderStyleChanged(object sender, EventArgs e)
        {
            
        }
    }
}
