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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        Modify modify = new Modify();
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            try
            {
                dtgvNCC.DataSource = modify.Table("Select *  from NhaCungCap ");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           //SetDtgv();
        }

        public void SetDtgv()
        {
            dtgvNCC.Columns[0].Width = 100;
            dtgvNCC.Columns[0].HeaderText = "ID Nhà cung cấp ";
            dtgvNCC.Columns[1].Width = 150;
            dtgvNCC.Columns[1].HeaderText = "Tên Nhà cung cấp ";
            dtgvNCC.Columns[2].Width = 170;
            dtgvNCC.Columns[2].HeaderText = "Số điện thoại  ";
            dtgvNCC.Columns[3].Width = 150;
            dtgvNCC.Columns[3].HeaderText = "Địa chỉ  ";
            
        }
    }
}
