using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonNhap_DAL_BLL
    {
        public HoaDonNhap_DAL_BLL()
        { }

        QLCHDataContext qlch = new QLCHDataContext();
        public bool ktraCTHD(int id)
        {
            CT_HoaDonNhap ct = qlch.CT_HoaDonNhaps.Where(t => t.Id == id).SingleOrDefault();
            if (ct == null)
                return false;
            return true;
        }
        public bool ktraHD(int id)
        {
            HoaDonNhap ct = qlch.HoaDonNhaps.Where(t => t.Id == id).SingleOrDefault();
            if (ct == null)
                return false;
            return true;
        }
        public bool deleteCTHDNbyML(int idml)
        {
            try
            {
                List<CT_HoaDonNhap> ds = qlch.CT_HoaDonNhaps.Where(t => t.IdML == idml).ToList();
                foreach (CT_HoaDonNhap ct in ds)
                {
                    if (ktraCTHD(ct.Id))
                    {
                        deleteCT_HDN(ct.Id);
                    }
                }
                return true;
            }
            catch { return false; }
        }
        public bool deleteHDNbyNV(int idnv)
        {
            try
            {
                List<HoaDonNhap> ds = qlch.HoaDonNhaps.Where(t => t.IdNV == idnv).ToList();
                foreach (HoaDonNhap hdn in ds)
                {
                    if (ktraHD(hdn.Id))
                    {
                        List<CT_HoaDonNhap> dsct = getCT_HDBbyIDHD(hdn.Id);
                        foreach (CT_HoaDonNhap ct in dsct)
                        {
                            if (ktraCTHD(ct.Id))
                                deleteCT_HDN(ct.Id);
                        }
                        deleteHD(hdn.Id);
                    }
                }
                return true;
            }
            catch { return false; }
            
        }
        public IQueryable getHD()
        {
            IQueryable ds = from hd in qlch.HoaDonNhaps
                            join ncc in qlch.NhaCungCaps on hd.IdNCC equals ncc.Id
                            join nv in qlch.NhanViens on hd.IdNV equals nv.Id
                            select new { hd.Id, nv.TenNV,ncc.TenNCC, hd.NgayNhap,hd.TongTien };
            return ds;
        }
        public List<CT_HoaDonNhap> getCT_HDBbyIDHD(int idhd)
        {
            List<CT_HoaDonNhap> ds = qlch.CT_HoaDonNhaps.Where(t => t.IdHDN == idhd).ToList();
            return ds;
        }
        public bool checkCTHDbyHD(int idhd)
        {
            List<CT_HoaDonNhap> ds = qlch.CT_HoaDonNhaps.Where(t => t.IdHDN == idhd).ToList();

            if (ds.Count == 0)
                return true;
            return false;
        }
        public IQueryable getCTHDbyHD(int idhd)
        {
            IQueryable ds = from a in qlch.CT_HoaDonNhaps
                            join ml in qlch.MayLanhs on a.IdML equals ml.Id
                            where a.IdHDN == idhd
                            select new { a.Id, a.IdHDN, ml.TenML, a.SoLuongNhap, a.DonGiaNhap, a.thanhtien };
            return ds;
        }

        public bool checkHD(int idnv, int idncc)
        {
            HoaDonNhap hd = qlch.HoaDonNhaps.Where(t => t.IdNCC == idncc && t.IdNV == idnv).SingleOrDefault();
            if (hd == null)
                return true;
            return false;
        }
        public bool checkCTHD(int idhd, int idml)
        {
            CT_HoaDonNhap cthd = qlch.CT_HoaDonNhaps.Where(t => t.IdHDN == idhd && t.IdML == idml).SingleOrDefault();
            if (cthd == null)
                return true;
            return false;
        }
        public bool updateTT(int id, double tt)
        {
            try
            {
                HoaDonNhap hd = qlch.HoaDonNhaps.Where(t => t.Id == id).SingleOrDefault();
                if (hd == null)
                    return false;
                hd.TongTien = tt;
                qlch.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool addCT_HDN(int idhd, int idml, int sl, double gianhap, double thanhtien)
        {
            try
            {
                CT_HoaDonNhap cthd = new CT_HoaDonNhap();
                cthd.IdHDN = idhd;
                cthd.IdML = idml;
                cthd.SoLuongNhap = sl;
                cthd.DonGiaNhap = gianhap;
                cthd.thanhtien = thanhtien;
                qlch.CT_HoaDonNhaps.InsertOnSubmit(cthd);
                qlch.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool updateCT_HDN(int id, int idhd, int idml, int sl, double gianhap, double thanhtien)
        {
            try
            {
                CT_HoaDonNhap cthd = qlch.CT_HoaDonNhaps.Where(t => t.Id == id).SingleOrDefault();
                if (cthd == null)
                    return false;
                cthd.IdHDN = idhd;
                cthd.IdML = idml;
                cthd.SoLuongNhap = sl;
                cthd.DonGiaNhap= gianhap;
                cthd.thanhtien = thanhtien;
                qlch.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool deleteCT_HDN(int id)
        {
            try
            {
                CT_HoaDonNhap cthd = qlch.CT_HoaDonNhaps.Where(t => t.Id == id).SingleOrDefault();
                if (cthd == null)
                    return false;
                qlch.CT_HoaDonNhaps.DeleteOnSubmit(cthd);
                qlch.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool addHDN(int idncc, int idnv, DateTime ngayban, float tongtien)
        {
            try
            {
                HoaDonNhap hd = new HoaDonNhap();
                hd.IdNCC = idncc;
                hd.IdNV = idnv;
                hd.NgayNhap = ngayban;
                hd.TongTien = tongtien;
                qlch.HoaDonNhaps.InsertOnSubmit(hd);
                qlch.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool updateHD(int id, int idncc, int idnv, DateTime ngayban, float tongtien)
        {
            try
            {
                HoaDonNhap hd = qlch.HoaDonNhaps.Where(t => t.Id == id).SingleOrDefault();
                if (hd == null)
                    return false;
                hd.IdNCC = idncc;
                hd.IdNV = idnv;
                hd.NgayNhap = ngayban;
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
                
                HoaDonNhap hd = qlch.HoaDonNhaps.Where(t => t.Id == id).SingleOrDefault();
                if (hd == null)
                    return false;
                qlch.HoaDonNhaps.DeleteOnSubmit(hd);
                qlch.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
