using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBan_DAL_BLL
    {
        //MayLanh_DAL_BLL ML = new MayLanh_DAL_BLL();
        public HoaDonBan_DAL_BLL()
        { }
        
        QLCHDataContext qlch = new QLCHDataContext();
        public bool deleteCTHDNbyML(int idml)
        {
            try
            {
                List<CT_HoaDonBan> ds = qlch.CT_HoaDonBans.Where(t => t.IdML == idml).ToList();
                foreach (CT_HoaDonBan ct in ds)
                {
                    if (ktraCTHD(ct.Id))
                    {
                        deleteCT_HDB(ct.Id);
                    }
                }
                return true;
            }
            catch { return false; }
        }
        public bool deleteHDBbyNV(int idnv)
        {
            try
            {
                List<HoaDonBan> ds = qlch.HoaDonBans.Where(t => t.IdNV == idnv).ToList();
                foreach (HoaDonBan hdn in ds)
                {
                    if (ktraHD(hdn.Id))
                    {
                        List<CT_HoaDonBan> dsct = getCT_HDBbyIDHD(hdn.Id);
                        foreach (CT_HoaDonBan ct in dsct)
                        {
                            if (ktraCTHD(ct.Id))
                                deleteCT_HDB(ct.Id);
                        }
                        deleteHD(hdn.Id);
                    }
                }
                return true;
            }
            catch { return false; }

        }
        public List<HoaDonBan> getHDBbyKH(int idKH)
        {
            List<HoaDonBan> ds = qlch.HoaDonBans.Where(t => t.IdKH == idKH).ToList();
            return ds;
        }
        public bool ktraCTHD(int id)
        {
            CT_HoaDonBan a = qlch.CT_HoaDonBans.Where(t => t.Id == id).SingleOrDefault();
            if (a == null)
                return false;
            return true;
        }
        public bool ktraHD(int id)
        {
            HoaDonBan a = qlch.HoaDonBans.Where(t => t.Id == id).SingleOrDefault();
            if (a == null)
                return false;
            return true;
        }
        public bool deleteHDBbyKH(int idKH)
        {
            try
            {
                List<HoaDonBan> ds = qlch.HoaDonBans.Where(t => t.IdKH == idKH).ToList();
                foreach (HoaDonBan hdb in ds)
                {
                    List<CT_HoaDonBan> dsct = qlch.CT_HoaDonBans.Where(t => t.IdHDB == hdb.Id).ToList();
                    foreach (CT_HoaDonBan cthdb in dsct)
                    {
                        if(ktraCTHD(cthdb.Id))
                        {
                            MayLanh ml = qlch.MayLanhs.Where(t => t.Id == cthdb.IdML).SingleOrDefault();
                            ml.SoLuongTon += cthdb.SoLuongBan;
                            qlch.SubmitChanges();
                            deleteCT_HDB(cthdb.Id); 
                        }
                        
                    }
                    if(ktraHD(hdb.Id))
                    {
                        deleteHD(hdb.Id);
                    }
                    
                }
                qlch.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public IQueryable getHD()
        {
            IQueryable ds = from hd in qlch.HoaDonBans join kh in qlch.KhachHangs on hd.IdKH equals kh.Id 
                            join nv in qlch.NhanViens on hd.IdNV equals nv.Id
                            select new {hd.Id, kh.TenKH, nv.TenNV, hd.NgayBan, hd.NgayGiao ,hd.TongTien};
            return ds;
        }
        public bool updateTT(int id, double tt)
        {
            try
            {
                HoaDonBan hd = qlch.HoaDonBans.Where(t => t.Id == id).SingleOrDefault();
                if (hd == null)
                    return false;
                hd.TongTien = tt;
                qlch.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public IQueryable getCTHDbyHD(int idhd)
        {
            IQueryable ds = from a in qlch.CT_HoaDonBans 
                            join ml in qlch.MayLanhs on a.IdML equals  ml.Id
                            where a.IdHDB == idhd 
                            select new {a.Id, a.IdHDB,ml.TenML,a.SoLuongBan,a.DonGiaBan, a.thanhtien};
            
            return ds;
        }

        public List<CT_HoaDonBan> getCT_HDBbyIDHD(int idhd)
        {
            List<CT_HoaDonBan> ds = qlch.CT_HoaDonBans.Where(t => t.IdHDB == idhd).ToList();
            return ds;

        }
        public bool checkHD(int idnv, int idkh)
        {
            HoaDonBan hd = qlch.HoaDonBans.Where(t => t.IdKH == idkh && t.IdNV == idnv).SingleOrDefault();
            if (hd == null)
                return true;
            return false;
        }
        public bool checkCTHD(int idhd, int idml)
        {
            CT_HoaDonBan cthd = qlch.CT_HoaDonBans.Where(t => t.IdHDB == idhd && t.IdML == idml).SingleOrDefault();
            if (cthd == null)
                return true;
            return false;
        }
        public bool addCT_HDB(int idhd, int idml, int sl, double giaban,double thanhtien)
        {
            try
            {
                CT_HoaDonBan cthd = new CT_HoaDonBan();
                cthd.IdHDB = idhd;
                cthd.IdML = idml;
                cthd.SoLuongBan = sl;
                cthd.DonGiaBan = giaban;
                cthd.thanhtien = thanhtien;
                qlch.CT_HoaDonBans.InsertOnSubmit(cthd);
                qlch.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool checkCTHDbyHD(int idhd)
        {
            List<CT_HoaDonBan> ds = qlch.CT_HoaDonBans.Where(t => t.IdHDB == idhd).ToList();
           
            if (ds.Count == 0)
                return true;
            return false;
        }
        public bool updateCT_HDB(int id, int idhd, int idml, int sl, double giaban, double thanhtien)
        {
            try
            {
                CT_HoaDonBan cthd = qlch.CT_HoaDonBans.Where(t => t.Id == id).SingleOrDefault();
                if (cthd == null)
                    return false;
                cthd.IdHDB = idhd;
                cthd.IdML = idml;
                cthd.SoLuongBan = sl;
                cthd.DonGiaBan = giaban;
                cthd.thanhtien = thanhtien;
                qlch.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool deleteCT_HDB(int id)
        {
            try
            {
                CT_HoaDonBan cthd = qlch.CT_HoaDonBans.Where(t => t.Id == id).SingleOrDefault();
                if (cthd == null)
                    return false;
               // ML.updateSLT(cthd.IdML, -cthd.SoLuongBan);
                qlch.CT_HoaDonBans.DeleteOnSubmit(cthd);
                qlch.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool addHDB(int idkh, int idnv,DateTime ngaygiao,DateTime ngayban,float tongtien)
        {
            try
            {
                HoaDonBan hd = new HoaDonBan();
                hd.IdKH = idkh;
                hd.IdNV = idnv;
                hd.NgayBan = ngayban;
                hd.NgayGiao = ngaygiao;
                hd.TongTien = tongtien;
                qlch.HoaDonBans.InsertOnSubmit(hd);
                qlch.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool updateHD(int id, int idkh, int idnv, DateTime ngaygiao, DateTime ngayban,float tongtien)
        {
            try
            {
                HoaDonBan hd = qlch.HoaDonBans.Where(t => t.Id == id).SingleOrDefault();
                if (hd == null)
                    return false;
                hd.IdKH = idkh;
                hd.IdNV = idnv;
                hd.NgayBan = ngayban;
                hd.NgayGiao = ngaygiao;
                hd.TongTien = tongtien;
                qlch.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool deleteHD(int id)
        {
            try
            {
                HoaDonBan hd = qlch.HoaDonBans.Where(t => t.Id == id).SingleOrDefault();
                if (hd == null)
                    return false;
                qlch.HoaDonBans.DeleteOnSubmit(hd);
                qlch.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public IQueryable getHDbyNV(int idnv, DateTime start,DateTime end)
        {
            IQueryable ds = from hd in qlch.HoaDonBans
                            join kh in qlch.KhachHangs on hd.IdKH equals kh.Id
                            join nv in qlch.NhanViens on hd.IdNV equals nv.Id
                            where hd.IdNV == idnv
                            where hd.NgayBan >start
                            where hd.NgayBan < end
                            select new { hd.Id, kh.TenKH, nv.TenNV, hd.NgayBan, hd.NgayGiao, hd.TongTien };
            return ds;
        }
        public IQueryable getHDbyML(int idml, DateTime start, DateTime end)
        {
            IQueryable ds = from hd in qlch.HoaDonBans
                            join kh in qlch.KhachHangs on hd.IdKH equals kh.Id
                            join nv in qlch.NhanViens on hd.IdNV equals nv.Id
                            join ct in qlch.CT_HoaDonBans on hd.Id equals ct.IdHDB
                            where ct.IdML == idml
                            where hd.NgayBan > start
                            where hd.NgayBan < end
                            select new { hd.Id, kh.TenKH, nv.TenNV, hd.NgayBan, hd.NgayGiao, hd.TongTien };
            return ds;
        }
        public IQueryable getHD( DateTime start, DateTime end)
        {
            IQueryable ds = from hd in qlch.HoaDonBans
                            join kh in qlch.KhachHangs on hd.IdKH equals kh.Id
                            join nv in qlch.NhanViens on hd.IdNV equals nv.Id
                            where hd.NgayBan > start
                            where hd.NgayBan < end
                            select new { hd.Id, kh.TenKH, nv.TenNV, hd.NgayBan, hd.NgayGiao, hd.TongTien };
            return ds;
        }
    }
}
