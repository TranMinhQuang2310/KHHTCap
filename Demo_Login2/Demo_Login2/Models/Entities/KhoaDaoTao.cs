using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_Login2.Models.Entities
{
    public class KhoaDaoTao
    {
        public int ID { get; set; }
        public string TenKhoaDaoTao { get; set; }
        public string NienKhoa { get; set; }
        public int LoaiHinhDaoTao { get; set; }
        public string GhiChu { get; set; }
        public ICollection<Account> Accounts_IDKhoaDaoTao { get; set; }
    }
}