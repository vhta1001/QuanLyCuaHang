using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiNV_DAL_BLL
    {
        public LoaiNV_DAL_BLL() { }
        QLCHDataContext qlch = new QLCHDataContext();
        public string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public List<LoaiNV> searchML(string ten)
        {
            string x = convertToUnSign3(ten);
            List<LoaiNV> listNV = (from nv in qlch.LoaiNVs select nv).ToList();
            List<LoaiNV> result = listNV.FindAll(
            delegate (LoaiNV math)
            {
                if (convertToUnSign3(math.TenLoaiNV.ToLower()).Contains(x))//CustomerName là tên cột
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
        public IQueryable getLoaiNV()
        {
            return qlch.LoaiNVs.Select(t => t);
        }
        public string getID(string tenloai)
        {
            LoaiNV loainv = qlch.LoaiNVs.Where(t => t.TenLoaiNV == tenloai).SingleOrDefault();
            if (loainv != null)
                return loainv.Id.ToString();
            return "";
        }
        public bool addLoaiNV(string tenloainv)
        {
            try
            {
                LoaiNV loaiNV = new LoaiNV();
                loaiNV.TenLoaiNV = tenloainv;
                qlch.LoaiNVs.InsertOnSubmit(loaiNV);
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteLoaiNV(int id)
        {
            try 
            { 
                LoaiNV loaiNV = qlch.LoaiNVs.Where(t => t.Id == id).SingleOrDefault();
                if (loaiNV == null)
                {
                    return false;
                }
                qlch.LoaiNVs.DeleteOnSubmit(loaiNV);
                qlch.SubmitChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool updateLoaiNV(int id,string tenLoaiNV)
        {
            try
            {
                LoaiNV loaiNV = qlch.LoaiNVs.Where(t => t.Id == id).SingleOrDefault();
                if (loaiNV == null)
                    return false;
                loaiNV.TenLoaiNV = tenLoaiNV;
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ktraTenLoaiNV(int  id)
        {
            LoaiNV loaiNV = qlch.LoaiNVs.Where(t => t.Id == id).SingleOrDefault();
            if (loaiNV == null)
                return true;
            else
                return false;
        }
    }
}
