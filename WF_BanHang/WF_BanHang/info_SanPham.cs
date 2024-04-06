using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BanHang
{
    public class info_SanPham
    {
        private string _idsp;
        private string _name;
        private string _mota;
        private double _gia;
        private string _ncc;

        public info_SanPham()
        {
        }

        public info_SanPham(string idsp, string name, string mota, double gia, string ncc)
        {
            _idsp = idsp;
            _name = name;
            _mota = mota;
            _gia = gia;
            _ncc = ncc;
            
        }

        public string Idsp { get => _idsp; set => _idsp = value; }
        public string Name { get => _name; set => _name = value; }
        public string Mota { get => _mota; set => _mota = value; }
        public double Gia { get => _gia; set => _gia = value; }
        public string Ncc { get => _ncc; set => _ncc = value; }
    }
}
