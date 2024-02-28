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
    public partial class FormAddNewEmployee : Form
    {
        public FormAddNewEmployee()
        {
            InitializeComponent();
        }



        private void FormAddNewEmployee_Load(object sender, EventArgs e)
        {
            cbSex.DataSource = Const.listSex;
            cbPhongBan.DataSource = Const.ListDepartment;
            cbContract.DataSource = Const.listContract;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            // gán giá trị trong ô nhập vào biến phụ 
            string name = txbName.Text;
            DateTime birtDay = dtpkBirtDay.Value;
            string sex = cbSex.Text;

            int employeeID = Convert.ToInt32(txbIdNhanVien.Text);
            string department = cbPhongBan.Text;
            string position = txbPosition.Text;
            string contract = cbContract.Text;

            Const.NewEmployee = new Employee(name, birtDay, sex,  employeeID, department,position, contract);

            this.Close();
        }
    }
}
