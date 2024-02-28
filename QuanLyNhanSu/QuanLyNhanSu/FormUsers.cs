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
    public partial class FormUsers : Form
    {
        List<string> listAccountType = new List<string>() { "Quan Ly", "Nhan vien"};

        int index = -1;

        public FormUsers()
        {
            InitializeComponent();
        }

        void LoadListUser()
        {
            // Cho về null 
            dtgvShowUser.DataSource = null;
            // gán giá trị 
            dtgvShowUser.DataSource = ListUser.Instance.listAccounttUser;

            dtgvShowUser.Refresh();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            cbLoaiTK.DataSource = listAccountType;

            LoadListUser();
        }

        private void dtgvShowUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            txbUserName.Text = dtgvShowUser.Rows[index].Cells[0].Value.ToString();
            txbPassWord.Text = dtgvShowUser.Rows[index].Cells[1].Value.ToString();


            switch(ListUser.Instance.listAccounttUser[index].AccountType)
            {
                case true:
                    cbLoaiTK.Text = "Quan Ly";
                    break;
                case false:
                    cbLoaiTK.Text = "Nhan Vien";
                    break;
            }

        }

        //thêm tài khoản user
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // gán dữ liệu đã nhập trong txb và cb cho biến 
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            bool accountType = false;

            //xét điều kiện nếu accountType trong cbLoạiTK  là true--> Quản lý
            // nếu là false -->> nhân viên 
            switch (cbLoaiTK.Text)
            {
                case "Quan Ly":
                    accountType = true;
                    break;
                case "Nhan Vien":
                    accountType = false;
                    break;
            }

            bool exist = false;
            for(int i = 0; i < ListUser.Instance.listAccounttUser.Count; i++)
            {
                // kiểm tra tai khoan da ton tai chưa 
                if(userName == ListUser.Instance.listAccounttUser[i].UserName &&
                    passWord == ListUser.Instance.listAccounttUser[i].PassWord)
                {
                    exist = true;
                    MessageBox.Show("Tai khoan da ton tai", "Loi");

                }
                //// nếu chưa có thì thêm vào ListUser 
                //else
                //{
                //    //thêm dữ liệu vào listUser 
                //    ListUser.Instance.listAccounttUser.Add(new User(userName, passWord, accountType));


                //    // sau khi thêm vào listuser thì phải Load lại 
                //    LoadListUser();

                    
                //}
            }
            if (!exist)
            {
                //thêm dữ liệu vào listUser 
                ListUser.Instance.listAccounttUser.Add(new User(userName, passWord, accountType));


                // sau khi thêm vào listuser thì phải Load lại 
                LoadListUser();

            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // gán dữ liệu đã nhập trong txb và cb cho biến 
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            bool accountType = false;

            //xét điều kiện nếu accountType trong cbLoạiTK  là true--> Quản lý
            // nếu là false -->> nhân viên 
            switch (cbLoaiTK.Text)
            {
                case "Quan Ly":
                    accountType = true;
                    break;
                case "Nhan Vien":
                    accountType = false;
                    break;
            }

            // nếu đã nhập thông tin thì thực hiên nếu chưa nhập thì có thông báo lỗi 
            if (!userName.Equals("") && !passWord.Equals(""))
            { 

                ListUser.Instance.listAccounttUser[index].UserName = userName;
                ListUser.Instance.listAccounttUser[index].PassWord = passWord;
                ListUser.Instance.listAccounttUser[index].AccountType = accountType;

                LoadListUser();
            }
            // khi chưa nhập thông tin thì sẽ có thông báo lỗi 
            else
            {
                MessageBox.Show("Ten tai khoan hoac Mat khau khong de trong");
                txbUserName.Focus();    
            }
            
      
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListUser.Instance.listAccounttUser.RemoveAt(index);
            LoadListUser();
        }
    }
}
