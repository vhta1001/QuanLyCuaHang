using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Linq;


namespace DAL
{
    class NV_DAL
    {
        public NV_DAL()
        { }
        dataDataContext qlch = new dataDataContext();
        public IQueryable loadNV()
        {
            IQueryable dsnv = from nv in qlch.NhanViens select new {nv.IdNV,nv.TenNV, nv.TenDN,nv.MatKhau,nv.SDTNV,nv.IdLoaiNV};
            return dsnv;
        }
    }
}
