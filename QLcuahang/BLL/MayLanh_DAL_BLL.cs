using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
     public class MayLanh_DAL_BLL
    {
        HoaDonBan_DAL_BLL hdb = new HoaDonBan_DAL_BLL();
        HoaDonNhap_DAL_BLL hdn = new HoaDonNhap_DAL_BLL();
        public MayLanh_DAL_BLL() { }
        QLCHDataContext qlch = new QLCHDataContext();
        public string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public IQueryable searchML(string ten)
        {
            string x = convertToUnSign3(ten);
            IQueryable dsml = from ml in qlch.MayLanhs 
                              join a in qlch.NhaCungCaps on ml.IdNCC equals a.Id 
                              where SqlMethods.Like(ml.TenML,"%"+x+"%")
                              select new { ml.Id, ml.TenML, ml.CongSuat, ml.CongNghe, ml.TinhNang, ml.SoLuongTon, ml.DonGiaBan, ml.DonGiaNhap, ml.NamSX, a.TenNCC };
            return dsml;



        }
        public double maxGiaBan()
        {
            double ml = qlch.MayLanhs.Max(t=>t.DonGiaBan);
            return ml;
        }
        public List<MayLanh> getMLTV(List<string> listtenml)
        {
            List<MayLanh> kq = new List<MayLanh>();
            
                foreach (string tenml in listtenml)
                {
                    MayLanh ml = qlch.MayLanhs.Where(t => t.TenML == tenml).SingleOrDefault();
                    if (ml != null)
                        kq.Add(ml);
                }
                return kq;
           
        }
        public bool ktraML(int id)
        {
            MayLanh ml = qlch.MayLanhs.Where(t => t.Id == id).SingleOrDefault();
            if (ml == null)
                return false;
            return true;
        }
        public bool deleteMLbyNCC(int idncc)
        {
            try
            {
                List<MayLanh> ds = qlch.MayLanhs.Where(t => t.IdNCC == idncc).ToList();
                foreach (MayLanh ml in ds)
                {
                    if (ktraML(ml.Id))
                        deleteML(ml.Id);
                }
                return true;
            }
            catch { return false; }
        }
        public List<IQueryable> getML(string tenml)
        {
            List<IQueryable> kq = new List<IQueryable>();
            IQueryable dsml = from ml in qlch.MayLanhs join a in qlch.NhaCungCaps on ml.IdNCC equals a.Id where ml.TenML == tenml select new { ml.Id, ml.TenML, ml.CongSuat, ml.CongNghe, ml.TinhNang, ml.SoLuongTon, ml.DonGiaBan, ml.DonGiaNhap, ml.NamSX, a.TenNCC };
            if (dsml != null)
                kq.Add(dsml);
            return kq;
        }
        public IQueryable getML()
        {
            IQueryable dsml = from ml in qlch.MayLanhs join a in qlch.NhaCungCaps on ml.IdNCC equals a.Id select new {ml.Id, ml.TenML ,ml.CongSuat,ml.CongNghe,ml.TinhNang,ml.SoLuongTon,ml.DonGiaBan,ml.DonGiaNhap,ml.NamSX, a.TenNCC };
            return dsml;   
        }
        public IQueryable getML1()
        {
            return qlch.MayLanhs.Select(t => t);
        }
        public IQueryable getMLbyNCC(int idncc)
        {
            IQueryable dsml = from ml in qlch.MayLanhs where ml.IdNCC == idncc select new { ml.Id,ml.TenML};
            return dsml;
        }
        public bool updateDGB(int id, double dgb)
        {
            try
            {
                MayLanh a = qlch.MayLanhs.Where(t => t.Id == id).SingleOrDefault();
                if (a == null)
                    return false;
                a.DonGiaNhap = dgb;
               // a.DonGiaBan = dgb + 1000000;
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateSLT(int id, int sl)
        {
            try
            {
                MayLanh a = qlch.MayLanhs.Where(t => t.Id == id).SingleOrDefault();
                if (a == null)
                    return false;
                a.SoLuongTon = a.SoLuongTon - sl;
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public double getDonGiaBan(int id)
        {
            MayLanh ml = qlch.MayLanhs.Where(t => t.Id == id).Single();
            return ml.DonGiaBan;
        }
        public int getSLT(int id)
        {
            MayLanh ml = qlch.MayLanhs.Where(t => t.Id == id).SingleOrDefault();
            return ml.SoLuongTon;
        }
        public bool addML(int idncc, string tenml, string congsuat, DateTime namsx, string tinhnang, string congnghe, int slton, float dgnhap, float dgban)
        {
            try
            {
                MayLanh a = new MayLanh();
                a.IdNCC = idncc;
                a.TenML = tenml;
                a.CongSuat = congsuat;
                a.NamSX = namsx;
                a.TinhNang = tinhnang;
                a.CongNghe = congnghe;
                a.SoLuongTon = slton;
                a.DonGiaNhap = dgnhap;
                a.DonGiaBan = dgban;
                qlch.MayLanhs.InsertOnSubmit(a);
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool checkML(string tenml)
        {
            MayLanh a = qlch.MayLanhs.Where(t => t.TenML == tenml).SingleOrDefault();
            if (a == null)
                return true;
            return false;
        }
        public bool updateML(int id, int idncc, string tenml, string congsuat, DateTime namsx, string tinhnang, string congnghe, int slton, float dgnhap, float dgban)
        {
            try
            {
                MayLanh a = qlch.MayLanhs.Where(t => t.Id == id).SingleOrDefault();
                if (a == null)
                    return false;
                a.IdNCC = idncc;
                a.TenML = tenml;
                a.CongSuat = congsuat;
                a.NamSX = namsx;
                a.TinhNang = tinhnang;
                a.CongNghe = congnghe;
                a.SoLuongTon = slton;
                a.DonGiaNhap = dgnhap;
                a.DonGiaBan = dgban;
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteML(int id)
        {
            try
            {
                if (hdn.deleteCTHDNbyML(id) && hdb.deleteCTHDNbyML(id))
                {
                    MayLanh a = qlch.MayLanhs.Where(t => t.Id == id).SingleOrDefault();
                    if (a == null)
                        return false;
                    qlch.MayLanhs.DeleteOnSubmit(a);
                    qlch.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

    }
}
