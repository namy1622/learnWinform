using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FormMain : Form
    {
        int index = -1;

        public bool isExit = true;

        public event EventHandler Logout;
        public FormMain()
        {
            InitializeComponent();
        }

        

        #region 
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion


        #region Method



        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            try {
                //Tạo mới một Excel WorkBook 

                oExcel.Visible = true;

                oExcel.DisplayAlerts = false;

                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;

                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                oSheets = oBook.Worksheets;

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                oSheet.Name = sheetName;

                // Tạo phần Tiêu đề
                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Times New Roman";

                head.Font.Size = "20";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Mã nhân viên";

                cl1.ColumnWidth = 12;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Họ tên";

                cl2.ColumnWidth = 25.0;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Ngày sinh";
                cl3.ColumnWidth = 12.0;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Giới tính";

                cl4.ColumnWidth = 10.5;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Phòng ban";

                cl5.ColumnWidth = 20.5;

                Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

                cl6.Value2 = "Chức vụ";

                cl6.ColumnWidth = 18.5;

                Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

                cl7.Value2 = "Tình trạng";

                cl7.ColumnWidth = 13.5;

                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền

                rowHead.Interior.ColorIndex = 6;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mảng theo datatable

                object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    DataRow dataRow = dataTable.Rows[row];

                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        arr[row, col] = dataRow[col];
                    }
                }

                //Thiết lập vùng điền dữ liệu

                int rowStart = 4;

                int columnStart = 1;

                int rowEnd = rowStart + dataTable.Rows.Count - 2;

                int columnEnd = dataTable.Columns.Count;

                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                //Điền dữ liệu vào vùng đã thiết lập

                range.Value2 = arr;

                // Kẻ viền

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột mã nhân viên

                //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

                //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                //Căn giữa cả bảng 
                oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                
                
                //--------------------------------------------------------

                //// Giải phóng tài nguyên COM
                //Marshal.ReleaseComObject(oSheet);
                //Marshal.ReleaseComObject(oSheets);
                //oBook.Close();
                //Marshal.ReleaseComObject(oBook);
                //oExcel.Quit();
                //Marshal.ReleaseComObject(oExcel);


            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Giải phóng tài nguyên COM cuối cùng
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

        }
        


        //hàm sử dụng để phân quyền người dùng (admin/ người dùng)
        void Decentralization()
        {
            if(Const.AccountType == false)
            {
                tsmiUser.Enabled = tsmiEmployee.Enabled = tsmiDepartment.Enabled = false;

            }
        }

        void LoadListEmployee()
        {
            // thêm tưng dòng 
            dtgvEmployee.Rows.Clear();

            foreach (var item in ListEmployee.Instance.ListEmploy)
            {
                dtgvEmployee.Rows.Add(item.EmployeeCode, item.Name, item.BirtDay.ToShortDateString(), item.Sex, item.Department, item.Position, item.Contract);
            }
        }

        #endregion

        //---------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------
        #region Event
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Ban muon thoat chuong trinh", "Canh bao", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnShow.Enabled = btnAddNew.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            Decentralization();

            LoadListEmployee();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hàm ủy thác 
            Logout(this, new EventArgs());
        }

        private void tsmiEmployee_Click(object sender, EventArgs e)
        {
            btnShow.Enabled = btnAddNew.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;

        }

        private void tsmiUser_Click(object sender, EventArgs e)
        {
            FormUsers f = new FormUsers();
            f.ShowDialog();
        }

        private void dtgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            //tránh việc người dùng chưa nhấn hoặc nhấn ngoài giá trị của list 
            if(index < 0 || index >= ListEmployee.Instance.ListEmploy.Count)
            {
                return;
            }

            Const.NewEmployee = new Employee();
            // gán giá trị cho biến tạm ( biến tạm là thành phần trong class Const)
            Const.NewEmployee.Name = ListEmployee.Instance.ListEmploy[index].Name;
            Const.NewEmployee.BirtDay = ListEmployee.Instance.ListEmploy[index].BirtDay;
            Const.NewEmployee.Sex = ListEmployee.Instance.ListEmploy[index].Sex;

            Const.NewEmployee.EmployeeCode = ListEmployee.Instance.ListEmploy[index].EmployeeCode;
            Const.NewEmployee.Department = ListEmployee.Instance.ListEmploy[index].Department;
            Const.NewEmployee.Position = ListEmployee.Instance.ListEmploy[index].Position;
            Const.NewEmployee.Contract = ListEmployee.Instance.ListEmploy[index].Contract;

        }

        // hiển thị form thông tin nhân viên (FormShowInfo)
        private void btnShow_Click(object sender, EventArgs e)
        {
            //tránh việc người dùng chưa nhấn hoặc nhấn ngoài giá trị của list 
            if (index < 0 || index >= ListEmployee.Instance.ListEmploy.Count)
            {
                return;
            }

            FormShowInfo f = new FormShowInfo();
            f.ShowDialog();
        }

        // thêm mới nhân viên
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            // gán newEmployee = null để tránh nhân giá trị vào bị lỗi 
            Const.NewEmployee = null;

            FormAddNewEmployee f = new FormAddNewEmployee();

            // khi FormAddNewEmployee đóng lại thì FormMain được chạy lại luôn 
            f.FormClosed += F_FormClosed;

            f.ShowDialog();

            LoadListEmployee();
        }

        private void F_FormClosed(object sender, FormClosedEventArgs e)
        {


            if(Const.NewEmployee != null)
            {
                ListEmployee.Instance.ListEmploy.Add(Const.NewEmployee);
                LoadListEmployee();
            }

            
        }


        private void hejjToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiDepartment_Click(object sender, EventArgs e)
        {
            FormDepartment d = new FormDepartment();
            d.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (index < 0 || index >= ListEmployee.Instance.ListEmploy.Count)
            {
                MessageBox.Show("Hay chon 1 ban ghi de sua ");
                return;
            }

            FormEditEmployee f = new FormEditEmployee();

            //sự kiện khi đóng FormEdit.. thì Formmain sẽ mở ra 
            f.FormClosed += F_FormClosed1;

            f.ShowDialog();
        }

        //... khi FormMain mở ra thì cùng lúc [vị trí index] trong  ListEmployee load lại dữ liệu đã sửa 
        private void F_FormClosed1(object sender, FormClosedEventArgs e)
        {

            /*
            // Đây là sửa phần BE, mỗi lần sửa thì sẽ phải load lại
            // nếu gặp dữ liệu lớn sẽ chạy lâu

            ListEmployee.Instance.ListEmploy[index].Name = Const.NewEmployee.Name;
            ListEmployee.Instance.ListEmploy[index].BirtDay = Const.NewEmployee.BirtDay;
            ListEmployee.Instance.ListEmploy[index].Sex = Const.NewEmployee.Sex;
            ListEmployee.Instance.ListEmploy[index].EmployeeCode = Const.NewEmployee.EmployeeCode;
            ListEmployee.Instance.ListEmploy[index].Department = Const.NewEmployee.Department;
            ListEmployee.Instance.ListEmploy[index].Position = Const.NewEmployee.Position;
            ListEmployee.Instance.ListEmploy[index].Contract = Const.NewEmployee.Contract;

            LoadListEmployee();

            */


            // còn đây là chạy phần FE chạy dữ liệu lớn sẽ nhanh hơn cách BE bên trên 
            dtgvEmployee.Rows[index].Cells[0].Value = Const.NewEmployee.EmployeeCode;
            dtgvEmployee.Rows[index].Cells[1].Value = Const.NewEmployee.Name;
            dtgvEmployee.Rows[index].Cells[2].Value = Const.NewEmployee.BirtDay.ToShortDateString();
            dtgvEmployee.Rows[index].Cells[3].Value = Const.NewEmployee.Sex;
            dtgvEmployee.Rows[index].Cells[4].Value = Const.NewEmployee.Department;
            dtgvEmployee.Rows[index].Cells[5].Value = Const.NewEmployee.Position;
            dtgvEmployee.Rows[index].Cells[6].Value = Const.NewEmployee.Contract;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(index < 0 || index >= ListEmployee.Instance.ListEmploy.Count)
            {
                MessageBox.Show("Hay chon 1 ban ghi de xoa");
                return;
            }

            ListEmployee.Instance.ListEmploy.RemoveAt(index);
            LoadListEmployee();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("EmployeeCode");
            DataColumn col2 = new DataColumn("Name");
            DataColumn col3 = new DataColumn("BirtDay");
            DataColumn col4 = new DataColumn("Sex");
            DataColumn col5 = new DataColumn("Department");
            DataColumn col6 = new DataColumn("Position");
            DataColumn col7 = new DataColumn("Contract");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);

            foreach(DataGridViewRow dtgvRow in dtgvEmployee.Rows)
            {
                DataRow dtrow = dataTable.NewRow();

                dtrow[0] = dtgvRow.Cells[0].Value;
                dtrow[1] = dtgvRow.Cells[1].Value;
                dtrow[2] = dtgvRow.Cells[2].Value;
                dtrow[3] = dtgvRow.Cells[3].Value;
                dtrow[4] = dtgvRow.Cells[4].Value;
                dtrow[5] = dtgvRow.Cells[5].Value;
                dtrow[6] = dtgvRow.Cells[6].Value;

                dataTable.Rows.Add(dtrow);
            }

            ExportFile(dataTable, "Danh sach", "DANH SÁCH NHÂN VIÊN");
        }

        #endregion
        //---------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------

    }
}
