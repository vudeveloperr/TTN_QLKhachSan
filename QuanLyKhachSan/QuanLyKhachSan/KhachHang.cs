﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    class KhachHang
    {
        private int maKH;
        public string tenKH;
        public string sdt;
        public string cmt;
        public KhachHang()
        {
            this.MaKH = 0;
            this.tenKH = "";
            this.sdt = "";
            this.cmt = "";
        }
        public KhachHang(int maKH, string tenKH, string sdt,string cmt)
        {
            this.MaKH = maKH;
            this.tenKH = tenKH;
            this.sdt = sdt;
            this.cmt = cmt;
        }

        //public int MaKH { get => MaKH; set => MaKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string CMT { get => cmt; set => cmt = value; }
        public int MaKH { get => maKH; set => maKH = value; }
    }
}
