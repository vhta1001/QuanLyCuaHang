using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Class1
    {
        public Class1() { }

        string idHD;
        string id;
        string tenML;
        string soLuongNhap;
        string donGiaNhap;
        string thanhTien;

        public string IdHD { get => idHD; set => idHD = value; }
        public string Id { get => id; set => id = value; }
        public string TenML { get => tenML; set => tenML = value; }
        public string SoLuongNhap { get => soLuongNhap; set => soLuongNhap = value; }
        public string DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public string ThanhTien { get => thanhTien; set => thanhTien = value; }

        public Class1(string idHD, string id, string tenML, string soLuongNhap, string donGiaNhap, string thanhTien)
        {
            this.Id = id;
            this.IdHD = IdHD;
            this.TenML = tenML;
            this.SoLuongNhap = soLuongNhap;
            this.DonGiaNhap = donGiaNhap;
            this.ThanhTien = thanhTien;
        }
    }
}
