using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Login2.Models.Entities
{
    public class MonHocHocKi
    {
        public int ID { get; set; }
        public int IDMonHoc { get; set; }
        public int IDHocKi { get; set; }
        public string GhiChu { get; set; }
    }
}