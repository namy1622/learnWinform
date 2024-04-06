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
    public partial class DonHang : Form
    {
        public DonHang()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        private void DonHang_Load(object sender, EventArgs e)
        {

            try
            {
                dtgvDonHang.DataSource = modify.Table("Select dh.Id, sp.Name, kh.Name, dh.SoLuong, dh.Gia " +
                                                      "from DonHang dh " +
                                                      "join SanPham sp on dh.IdSP = sp.IdSP " +
                                                      "join KhachHang kh on dh.IdKH = kh.IdKhachHang");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           // SetDtgv();
        }
        //public void SetDtgv()
        //{
        //    dtgvDonHang.Columns[0].Width = 100;
        //    dtgvDonHang.Columns[0].HeaderText = "ID Đơn hàng";
        //    dtgvDonHang.Columns[1].Width = 150;
        //    dtgvDonHang.Columns[1].HeaderText = "Sản phẩm ";
        //    dtgvDonHang.Columns[2].Width = 170;
        //    dtgvDonHang.Columns[2].HeaderText = "Khách hàng ";
        //    dtgvDonHang.Columns[3].Width = 130;
        //    dtgvDonHang.Columns[3].HeaderText = "Số lượng ";
        //    dtgvDonHang.Columns[4].Width = 160;
        //    dtgvDonHang.Columns[4].HeaderText = "Giá ";
        //}
    }
}
