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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        //lưu trữ form con hiện tại đang show ở pn_child 
        private Form currentChildForm; 
        private void openForm(Form child)
        {
            
            //kiểm tra form con nào đang được show trong pn_child không 
            if(currentChildForm != null){

                currentChildForm.Close();// nếu có thì đóng form đó lại 
            }
            // gán form con được truyền vào pthuc 
            currentChildForm = child;
            //form con ko là cửa sổ độc lập, hthi như 1 phần form cha 
            child.TopLevel = false;
                // cài đặt đương viền = none 
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill; //Fill để form chiếm toàn bộ pn_child 
            pn_body.Controls.Add(child); // thêm form child vào ds điều khiển của pn_child 
            pn_body.Tag = child; // Tag cho phép truy cập form con từ pn nếu cần 
            child.BringToFront(); // đưa form con lên trước pn 
            child.Show();  // hiển thị form con 

        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {

                currentChildForm.Close();// nếu có thì đóng form đó lại 
            }
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        #region  
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            openForm(new SanPham());
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            openForm(new DonHang());
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            openForm(new KhachHang());
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            openForm(new NhaCungCap());
        }

      
        private void pn_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        #endregion

       
    }
}
