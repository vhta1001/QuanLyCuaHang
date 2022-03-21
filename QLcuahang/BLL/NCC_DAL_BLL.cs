using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NCC_DAL_BLL
    {
        MayLanh_DAL_BLL ml = new MayLanh_DAL_BLL();
        public NCC_DAL_BLL() { }
        QLCHDataContext qlch = new QLCHDataContext();
        public IQueryable getNCC()
        {
            return qlch.NhaCungCaps.Select(t => t);
        }
        public bool checkNCC(string tenNCC)
        {
            NhaCungCap ncc= qlch.NhaCungCaps.Where(t => t.TenNCC == tenNCC).SingleOrDefault();
            if (ncc == null)
                return true;
            return false;
        }
        public bool addNCC(string tenNCC, string diaChiNCC, string sdtNCC)
        {
            try 
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.TenNCC = tenNCC;
                ncc.DiaChi = diaChiNCC;
                ncc.SDTNCC = sdtNCC;
                qlch.NhaCungCaps.InsertOnSubmit(ncc);
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateNCC(int id, string tenNCC, string diaChiNCC, string sdtNCC)
        {
            try
            {
                NhaCungCap ncc = qlch.NhaCungCaps.Where(t => t.Id == id).SingleOrDefault();
                ncc.TenNCC = tenNCC;
                ncc.DiaChi = diaChiNCC;
                ncc.SDTNCC = sdtNCC;
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool deleteNCC(int id)
        {
            try
            {
                if (ml.deleteMLbyNCC(id))
                {
                    NhaCungCap ncc = qlch.NhaCungCaps.Where(t => t.Id == id).SingleOrDefault();
                    if (ncc == null)
                        return false;
                    qlch.NhaCungCaps.DeleteOnSubmit(ncc);
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
