using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
    public class ListEmployee
    {
        private static ListEmployee instance;

        private List<Employee> listEmploy;

        public List<Employee> ListEmploy { get => listEmploy; set => listEmploy = value; }
        public static ListEmployee Instance 
        {
            get
            {
                if(instance == null)
                    instance = new ListEmployee();
                return instance;
            }
            set => instance = value; 
        }

        private ListEmployee()
        {
            listEmploy = new List<Employee>();
            listEmploy.Add(new Employee("Nguyễn Dương", 
                                        new DateTime(1991, 10, 24), 
                                        "Nam", 
                                        1, 
                                        "Phong IT",
                                        "Trưởng phòng", 
                                        "Đang công tác"));
            listEmploy.Add(new Employee("Đoàn Nam",
                                        new DateTime(2003, 06, 22),
                                        "Nam",
                                        2,
                                        "Phong IT",
                                        "Thực tập sinh",
                                        "Đang công tác"));
            listEmploy.Add(new Employee("Đoàn Tuấn",
                                         new DateTime(2003, 05, 23),
                                         "Nam",
                                         3,
                                         "Phong nhan su",
                                         "Nhân viên ",
                                         "Đã nghỉ"));
            listEmploy.Add(new Employee("Đỗ Dao",
                                        new DateTime(2002, 01, 16),
                                        "Nữ",
                                         4,
                                         "Phong Test",
                                         "Lead",
                                         "Đã nghi"));

        }

    }
}
