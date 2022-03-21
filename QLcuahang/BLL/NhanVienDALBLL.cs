using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienDALBLL
    {
        HoaDonBan_DAL_BLL hdb = new HoaDonBan_DAL_BLL();
        HoaDonNhap_DAL_BLL hdn = new HoaDonNhap_DAL_BLL();
        public NhanVienDALBLL()
        { }
        QLCHDataContext qlch = new QLCHDataContext();
        public string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public List<NhanVien> searchML(string ten)
        {
            string x = convertToUnSign3(ten);
            List<NhanVien> listNV = (from nv in qlch.NhanViens select nv).ToList();
            List<NhanVien> result = listNV.FindAll(
            delegate (NhanVien math)
            {
                if (convertToUnSign3(math.TenNV.ToLower()).Contains(x))//CustomerName là tên cột
                    return true;
                else
                    return false;
            }
        );
            return result;
            //IQueryable dsml = from k in qlch.NhanViens
            //                  where SqlMethods.Like(k.TenNV, "%" + ten + "%")
            //                  select new { k.Id, k.TenNV, k.TenDN, k.MatKhau, k.SDTNV, k.IdLoaiNV };
            //return dsml;



        }
        public string getTenNV(string tenDN)
        {
            NhanVien a = qlch.NhanViens.Where(t => t.TenDN == tenDN).SingleOrDefault();
            return a.TenNV;
        }

        public IQueryable getTenNVbyTDN(string tenDN)
        {
            IQueryable dsnv = from k in qlch.NhanViens where k.TenDN == tenDN select new { k.Id, k.TenNV, k.TenDN, k.MatKhau, k.SDTNV, k.IdLoaiNV };
            return dsnv;
        }

        public IQueryable getNV()
        {
            IQueryable dsnv = from k in qlch.NhanViens select new { k.Id, k.TenNV, k.TenDN, k.MatKhau, k.SDTNV,k.IdLoaiNV };
            return dsnv;
        }
        public bool checkNv(int id)
        {
            NhanVien nv = qlch.NhanViens.Where(t => t.Id == id).SingleOrDefault();
            if (nv == null)
                return false;
            return true;
        }
        public List<NhanVien> getNVbyLoaiNV(int idlnv)
        {
            List<NhanVien> ds = qlch.NhanViens.Where(t => t.IdLoaiNV == idlnv).ToList();
            return ds;
        }
        public bool deleteNVbyLoaiNV(int idlnv)
        {
            try
            {
                List<NhanVien> ds = getNVbyLoaiNV(idlnv);
                foreach (NhanVien nv in ds)
                {
                    if(checkNv(nv.Id))
                        deleteNV(nv.Id);

                }
                qlch.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public NhanVien getNVbyID(int id)
        {
            NhanVien nhanVien = qlch.NhanViens.Where(t => t.Id == id).SingleOrDefault();
            return nhanVien;
        }
        public bool passwordChange(int id, string pass)
        {
            try
            {
                NhanVien nhanVien = qlch.NhanViens.Where(t => t.Id == id).SingleOrDefault();
                if (nhanVien == null)
                    return false;
                nhanVien.MatKhau = pass;
                qlch.SubmitChanges();
                return true;
            }
            catch
            { return false; }
        }
        public bool addNV( string tennv,string tendn,string mk,string sdt,int idloainv)
        {
            try
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.TenNV = tennv;
                nhanVien.TenDN = tendn;
                nhanVien.MatKhau = mk;
                nhanVien.SDTNV = sdt;
                nhanVien.IdLoaiNV = idloainv;
                qlch.NhanViens.InsertOnSubmit(nhanVien);
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteNV(int id)
        {
            try
            {
                if(hdb.deleteHDBbyNV(id)&&hdn.deleteHDNbyNV(id))
                {
                    NhanVien d = qlch.NhanViens.Where(t => t.Id == id).SingleOrDefault();
                    if (d == null)
                    {
                        return false;
                    }
                    qlch.NhanViens.DeleteOnSubmit(d);
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
        public bool updateNV(int id, string tennv, string tendn, string mk, string sdt, int idloainv)
        {
            try
            {
                NhanVien nhanVien = qlch.NhanViens.Where(t => t.Id == id).SingleOrDefault();
                if (nhanVien == null)
                    return false;
                nhanVien.TenNV = tennv;
                nhanVien.TenDN = tendn;
                nhanVien.MatKhau = mk;
                nhanVien.SDTNV = sdt;
                nhanVien.IdLoaiNV = idloainv;
                qlch.SubmitChanges();
                return true;
            }
            catch
            { return false; }
        }
        public bool ktraTenDN(string tendn)
        {
            NhanVien nhanVien = qlch.NhanViens.Where(t => t.TenDN == tendn).SingleOrDefault();
            if (nhanVien == null)
                return true;
            else
                return false;
        }
        public bool ktraKhoaChinh(int id)
        {
            NhanVien nhanVien = qlch.NhanViens.Where(t => t.Id == id).SingleOrDefault();
            if (nhanVien == null)
                return true;
            else
                return false;
        }

        public bool checkLogin(string TenDN, string mk)
        {
            NhanVien ds = qlch.NhanViens.Where(t => t.TenDN == TenDN && t.MatKhau == mk).SingleOrDefault();
            if (ds == null)
                return false;
            
            return true;
        }
        public int getIDLoaiNV(string TenDN)
        {
            NhanVien nv = qlch.NhanViens.Where(t => t.TenDN == TenDN).Single();
            return nv.IdLoaiNV;
        }

    }
}
