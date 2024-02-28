using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void lbUser_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string passWord = txbPassword.Text;
            if (CheckLogin(username, passWord))
            {
                FormMain f = new FormMain();
                f.Show();
                this.Hide();

                // nhận ủy thác từ Logout trong FormMain
                f.Logout += F_Logout;
            }
            else
            {
                MessageBox.Show("Sai tai khoan hoac mat khau. Kiem tra lai !", "Loi", MessageBoxButtons.OK);
                txbUserName.Focus();
                return;
            }
            
        }

        private void F_Logout(object sender, EventArgs e)
        {
            (sender as FormMain).isExit = false;
            (sender as FormMain).Close();
            this.Show();

        }

        bool CheckLogin(string userName, string passWord)
        {
            for (int i = 0; i < ListUser.Instance.listAccounttUser.Count; i++){
                if(userName == ListUser.Instance.listAccounttUser[i].UserName
                    && passWord == ListUser.Instance.listAccounttUser[i].PassWord)
                {
                    Const.AccountType = ListUser.Instance.listAccounttUser[i].AccountType;

                  
                    return true;
                }
            }

            return false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbDisplayPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if(cbDisplayPassWord.Checked)
            {
                txbPassword.UseSystemPasswordChar = false;
            }
            if (!cbDisplayPassWord.Checked)
            {
                txbPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
 