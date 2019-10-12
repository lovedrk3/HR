using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IBLL
{
   public interface ICompensationTandardsBLL
    {
        int CtAdd(CompensationTandardsModel sm);
        int CtUpdate(CompensationTandardsModel sm);
        int CtDelete(CompensationTandardsModel sm);
        List<CompensationTandardsModel> CtSelect();
        List<CompensationTandardsModel> SelectCtBy(string id);
        List<CompensationTandardsModel> FenYe<K>(int currentPage, int PageSize, out int rows);
        List<CompensationTandardsModel> FenYe2<K>(int currentPage, int PageSize, string Ctid, string CtName, DateTime dt1, DateTime dt2, out int rows);

        List<CompensationTandardsModel> FenYe3<K>(int currentPage, int PageSize, string Ctid, string CtName, out int rows);
    }
}
