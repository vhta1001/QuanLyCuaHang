using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhanQuyen_DAL_BLL
    {
        ManHinh_DAL_BLL manHinh_DAL_BLL = new ManHinh_DAL_BLL();
        
        public PhanQuyen_DAL_BLL() { }
        QLCHDataContext qlch = new QLCHDataContext();
        public IQueryable getPQ()
        {
            return qlch.PhanQuyens.Select(t => t);
        }
        public List<PhanQuyen> getPQbyNV(int idloainv)
        {
            
            
            List<PhanQuyen> kq = qlch.PhanQuyens.Where(t => t.IdLoaiNV == idloainv).ToList();
            return kq;

        }
        public IQueryable getPQbyLoaiNV(int idloainv)
        {
            IQueryable ds = from a in qlch.PhanQuyens where a.IdLoaiNV == idloainv select new {a.Id, a.IdLoaiNV, a.IdManHinh,a.CoQuyen };
            return ds;
        }

        public IQueryable getIDby(int idloainv)
        {
            return qlch.PhanQuyens.Select(t => t).Where(t => t.IdLoaiNV == idloainv);
        }
        public bool checkPQ(int id)
        {
            PhanQuyen pq = qlch.PhanQuyens.Where(t => t.Id == id).SingleOrDefault();
            if (pq == null)
                return true;
            return false;
        }
        public bool deletePQbyLoaiNV(int idlnv)
        {
            try
            {
                List<PhanQuyen> ds = qlch.PhanQuyens.Where(t => t.IdLoaiNV == idlnv).ToList();
                foreach (PhanQuyen mh in ds)
                {
                    if(!checkPQ(mh.Id))
                    { deletePQ(mh.Id); }
                    
                }
                qlch.SubmitChanges();
                return true;



            }
            catch { return false; }
        }
        public bool addPQbyLoaiNV(int idlnv)
        {
            try
            {
                List<ManHinh> ds = manHinh_DAL_BLL.mh();
                foreach (ManHinh mh in ds)
                {
                    addPQ(idlnv, mh.Id, true);
                }
                return true;



            }
            catch { return false; }
        }
        public bool addPQ(int idloainv, string idmh, bool coquyen)
        {
            try
            {
                PhanQuyen phanQuyen = new PhanQuyen();
                phanQuyen.IdLoaiNV = idloainv;
                phanQuyen.IdManHinh = idmh;
                phanQuyen.CoQuyen = coquyen;
                qlch.PhanQuyens.InsertOnSubmit(phanQuyen);
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deletePQ(int id)
        {
            try
            {
                PhanQuyen phanQuyen = qlch.PhanQuyens.Where(t => t.Id == id).SingleOrDefault();
                if (phanQuyen == null)
                    return false;
                qlch.PhanQuyens.DeleteOnSubmit(phanQuyen);
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool PQ(int id, bool coquyen)
        {
            try
            {
                PhanQuyen phanQuyen = qlch.PhanQuyens.Where(t => t.Id == id).SingleOrDefault();
                if (phanQuyen == null)
                    return false;
                phanQuyen.CoQuyen = coquyen;
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
