using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Logout
{
    public partial class Main_1 : Form
    {
        public bool isThoat = true;
        public Main_1()
        {
            InitializeComponent();
        }

        public event EventHandler DangXuat;

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            
            DangXuat(this, new EventArgs());
            
        }



        

        private void btnExit_main_Click(object sender, EventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }
        }
    }
}
