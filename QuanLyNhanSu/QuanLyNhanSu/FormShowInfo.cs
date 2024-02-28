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
    public partial class FormShowInfo : Form
    {
        public FormShowInfo()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        void LoadInfo()
        {
            txbName.Text = Const.NewEmployee.Name;
            txbSex.Text = Const.NewEmployee.Sex;
            dtpkBirtDay.Value = Const.NewEmployee.BirtDay;

            txbEmployeeId.Text = Const.NewEmployee.EmployeeCode.ToString();
            txbDepartment.Text = Const.NewEmployee.Department;
            txbPosition.Text = Const.NewEmployee.Position;
            txbContract.Text = Const.NewEmployee.Contract;
        }

        private void FormShowInfo_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }
    }
}
