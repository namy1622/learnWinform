using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    public class Employee
    {
        private string name;
        private DateTime birtDay;
        private string sex;


        // mã nhân viên 
        private int employeeCode;
        private string department; // phòng ban 
        private string position; // vị trí trong công ty
        private string contract;  //trạng thái hợp đồng 


        public string Name { get => name; set => name = value; }
        public DateTime BirtDay { get => birtDay; set => birtDay = value; }
        public string Sex { get => sex; set => sex = value; }
        public int EmployeeCode { get => employeeCode; set => employeeCode = value; }
        public string Department { get => department; set => department = value; }
        public string Position { get => position; set => position = value; }
        public string Contract { get => contract; set => contract = value; }


        // hàm dựng có tham sô 
        public Employee(string name, DateTime birtDay, string sex, int employeeCode, string department,string position ,string contract) {
            this.Name = name;
            this.BirtDay = birtDay;
            this.Sex = sex;

            this.EmployeeCode = employeeCode;
            this.Department = department;
            this.Position = position;
            this.Contract = contract;
        }

        //hàm dụng không tham số đề phòng ko có thông tin 
        public Employee() {
        }
    }
}
