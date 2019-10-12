using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using IDAO;
using IOC;
using Model;

namespace BLL
{
    public class CompensationTandardsBLL : ICompensationTandardsBLL
    {
        ICompensationTandardsDAO sd = IocCreate.CreateCompensationTandardsDAL();
        public int CtAdd(CompensationTandardsModel sm)
        {
            return sd.CtAdd(sm);
        }

        public int CtDelete(CompensationTandardsModel sm)
        {
            return sd.CtDelete(sm);
        }

        public List<CompensationTandardsModel> CtSelect()
        {
            return sd.CtSelect();
        }

        public int CtUpdate(CompensationTandardsModel sm)
        {
            return sd.CtUpdate(sm);
        }

        public List<CompensationTandardsModel> SelectCtBy(string id)
        {
            return sd.SelectCtBy(id);
        }
        public List<CompensationTandardsModel> FenYe<K>(int currentPage, int PageSize, out int rows)
        {
            return sd.FenYe<K>(currentPage, PageSize, out rows);
        }

        public List<CompensationTandardsModel> FenYe2<K>(int currentPage, int PageSize, string Ctid, string CtName, DateTime dt1, DateTime dt2, out int rows)
        {
            return sd.FenYe2<K>(currentPage,PageSize,Ctid,CtName,dt1,dt2, out rows);
        }

        public List<CompensationTandardsModel> FenYe3<K>(int currentPage, int PageSize, string Ctid, string CtName, out int rows)
        {
            return sd.FenYe3<K>(currentPage, PageSize, Ctid, CtName, out rows);
        }
    }
}
