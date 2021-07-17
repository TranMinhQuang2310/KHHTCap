using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Login2.Models.Entities
{
    public class MonHoc
    {
        public int ID { get; set; }
        public int IDKhoaBoMon { get; set; }
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public bool HocPhanTienQuyet { get; set; }
        public bool HocPhanHocTruoc { get; set; }
        public int SoTiet { get; set; }
        public int SoTietLyThuyet { get; set; }
        public int SoTietThucHanh { get; set; }
        public int LoaiMonHoc { get; set; }
        public int SoTinChi { get; set; }
        public string GhiChu { get; set; }
    }
}