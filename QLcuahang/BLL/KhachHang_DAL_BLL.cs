using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHang_DAL_BLL
    {
        public KhachHang_DAL_BLL()
        { }

        QLCHDataContext qlch = new QLCHDataContext();

        public IQueryable getKH()
        {
            IQueryable ds = from a in qlch.KhachHangs select new { a.Id, a.TenKH, a.DiaChiKH, a.SDT };
            return ds;
        }
        public bool checkKH(int id)
        {
            KhachHang kh = qlch.KhachHangs.Where(t => t.Id == id).SingleOrDefault();
            if (kh == null)
                return true;
            return false;
        }
        public bool addKH(string tenkh, string diachi, string sdt)
        {
            try
            {
                KhachHang kh = new KhachHang();
                kh.TenKH = tenkh;
                kh.DiaChiKH = diachi;
                kh.SDT = sdt;

                qlch.KhachHangs.InsertOnSubmit(kh);
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;   
            }
        }
        public bool updateKH(int id, string tenkh, string diachi, string sdt)
        {
            try
            {
                KhachHang kh = qlch.KhachHangs.Where(t => t.Id == id).SingleOrDefault();
                if (kh == null)
                    return false;
                kh.TenKH = tenkh;
                kh.DiaChiKH = diachi;
                kh.SDT = sdt;
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteKH(int id)
        {
            try
            {
                KhachHang kh = qlch.KhachHangs.Where(t => t.Id == id).SingleOrDefault();
                if (kh == null)
                    return false;
                qlch.KhachHangs.DeleteOnSubmit(kh);
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
