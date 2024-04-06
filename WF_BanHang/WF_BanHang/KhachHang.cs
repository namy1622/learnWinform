using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_BanHang
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void KhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                dtgvKhachHang.DataSource = modify.Table("Select * from KhachHang");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //SetDtgv();
        }
        //public void SetDtgv()
        //{
        //    dtgvKhachHang.Columns[0].Width = 100;
        //    dtgvKhachHang.Columns[0].HeaderText = "ID Khách hàng ";
        //    dtgvKhachHang.Columns[1].Width = 150;
        //    dtgvKhachHang.Columns[1].HeaderText = "Tên ";
        //    dtgvKhachHang.Columns[2].Width = 170;
        //    dtgvKhachHang.Columns[2].HeaderText = "Ngày sinh  ";
        //    dtgvKhachHang.Columns[3].Width = 150;
        //    dtgvKhachHang.Columns[3].HeaderText = "Số điện thoại ";
            
        //}
    }
}
