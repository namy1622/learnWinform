using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FormEditEmployee : Form
    {
        public FormEditEmployee()
        {
            InitializeComponent();
        }

        void LoadInfo()
        {
            txbName.Text = Const.NewEmployee.Name;
            cbSex.Text = Const.NewEmployee.Sex;
            dtpkBirtDay.Value = Const.NewEmployee.BirtDay;

            txbEmployeeId.Text = Const.NewEmployee.EmployeeCode.ToString();
            cbPhongBan.Text = Const.NewEmployee.Department;
            txbPosition.Text = Const.NewEmployee.Position;
            cbContract.Text = Const.NewEmployee.Contract;
        }

        private void FormEditEmployee_Load(object sender, EventArgs e)
        {
            cbSex.DataSource = Const.listSex;
            cbPhongBan.DataSource = Const.ListDepartment;
            cbContract.DataSource = Const.listContract;

            LoadInfo();
        }


        // btnEdit này là nút lưu đó 
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // gán giá trị trong ô nhập vào biến phụ 
            string name = txbName.Text;
            DateTime birtDay = dtpkBirtDay.Value;
            string sex = cbSex.Text;

            int employeeID = Convert.ToInt32(txbEmployeeId.Text);
            string department = cbPhongBan.Text;
            string position = txbPosition.Text;
            string contract = cbContract.Text;

            Const.NewEmployee = new Employee(name, birtDay, sex, employeeID, department, position, contract);

            this.Close();
        }
    }
}
