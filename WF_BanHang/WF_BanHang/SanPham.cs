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
    public partial class SanPham : Form
    {
        info_SanPham info_sp;
        int index = -1;
        public SanPham()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        Modify modify = new Modify();
        private void SanPham_Load(object sender, EventArgs e)
        {
            try
            {
                dtgvSanPham.DataSource = modify.Table("select sp.IdSP, sp.Name, sp.Mota, sp.Gia, ncc.Name " +
                                                      "From SanPham sp " +
                                                      "join NhaCungCap ncc On sp.IdNCC = ncc.IdNCC");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //SetDtgv();

        }

        public void SetDtgv()
        {
            dtgvSanPham.Columns[0].Width = 100;
            dtgvSanPham.Columns[0].HeaderText = "ID Sản phẩm";
            dtgvSanPham.Columns[1].Width = 150;
            dtgvSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dtgvSanPham.Columns[2].Width = 170;
            dtgvSanPham.Columns[2].HeaderText = "Mô tả ";
            dtgvSanPham.Columns[3].Width = 150;
            dtgvSanPham.Columns[3].HeaderText = "Giá ";
            dtgvSanPham.Columns[4].Width = 150;
            dtgvSanPham.Columns[4].HeaderText = "Nhà cung cấp ";
        }

        // gán giá trị trong ô textBox cho các biên tương ứng trong lớp info_SanPham 
        private void GetValuesTextBox()
        {
            string _idsp = txbId.Text;
            string _namesp = txbName.Text;
            string _mota = txbMoTa.Text;
            double _gia = Convert.ToDouble(txbGia.Text);
            string _ncc = txbNcc.Text;

            info_sp = new info_SanPham(_idsp, _namesp, _mota, _gia, _ncc);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GetValuesTextBox();

            string query = "insert into SanPham values ('" + info_sp.Idsp + "', N'" + info_sp.Name + "', N'" + info_sp.Mota + "','" + info_sp.Gia + "',N'" + info_sp.Ncc + "')";

            try
            {
                modify.Command(query);
                MessageBox.Show("Them thanh cong");

                SanPham_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index < 0) return;

            indexToTxb();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // chọn ra giá trị--> hàng: index, cột: 0 
            string choose = dtgvSanPham.Rows[index].Cells[0].Value.ToString();

            // câu truy vấn xóa 
            string query = "Delete SanPham Where IdSP = '" + choose + "'";

            // câu truy vấn xóa idsp ở bảng DonHang ( vì DonHang-SanPham liên kết với nhau )
            string query1 = "Delete DonHang Where IdSP = '" + choose + "'";

            try
            {
                // trước tiên phải xóa dl ràng buộc 2 bảng DH-SP trước 
                modify.Command(query1);
                //thực hiện xóa ở bảng SP 
                modify.Command(query);

                MessageBox.Show("Xoa thanh cong");
                // xóa xong thì chạy lại form SP
                SanPham_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void indexToTxb()
        {
            txbId.Text = dtgvSanPham.Rows[index].Cells[0].Value.ToString();
            txbName.Text = dtgvSanPham.Rows[index].Cells[1].Value.ToString();
            txbMoTa.Text = dtgvSanPham.Rows[index].Cells[2].Value.ToString();
            txbGia.Text = dtgvSanPham.Rows[index].Cells[3].Value.ToString();
            txbNcc.Text = dtgvSanPham.Rows[index].Cells[4].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {


            GetValuesTextBox();

            string query = "update SanPham  " +
                            "set Name = N'" + info_sp.Name + "', Mota = N'" + info_sp.Mota + "', Gia = N'" + info_sp.Gia + "'" +
                            " where IdSP = N'" + info_sp.Idsp + "'";

            try
            {
                modify.Command(query);
                MessageBox.Show("sua thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SanPham_Load(sender, e);
        }

        private void dtgvSanPham_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Xác định màu nền cho từng dòng (ví dụ: hàng chẵn màu đậm, hàng lẻ màu nhạt)
            if (e.RowIndex % 2 == 0)
            {
                dtgvSanPham.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
            }
            else
            {
                dtgvSanPham.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
        }
    }
}
