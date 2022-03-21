using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TK
    {
        string id;
        string tenKH;
        string tenNV;
        string ngayLap;
        string ngayGiao;
        string tongTien;

        public string Id { get => id; set => id = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public string NgayGiao { get => ngayGiao; set => ngayGiao = value; }
        public string TongTien { get => tongTien; set => tongTien = value; }
        public TK(string id, string tenKH, string tenNV, string ngayLap, string ngayGiao, string tongTien)
        {
            this.Id = id;
            this.TenKH = tenKH;
            this.TenNV = tenNV;
            this.NgayLap = ngayLap;
            this.NgayGiao = ngayGiao;
            this.TongTien = tongTien;
        }
        public TK() { }
    }
}
