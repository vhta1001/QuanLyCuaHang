using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ManHinh_DAL_BLL
    {
        public ManHinh_DAL_BLL() { }
        QLCHDataContext qlch = new QLCHDataContext();
        public IQueryable getMH()
        {
            return qlch.ManHinhs.Select(t => t);
        }
        public List<ManHinh> mh()
        {
            return qlch.ManHinhs.Select(t => t).ToList();
        }
    }
}
