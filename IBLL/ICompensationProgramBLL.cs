using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IBLL
{
   public interface ICompensationProgramBLL
    {
        int CtAdd(CompensationProgramModel sm);
        int CtUpdate(CompensationProgramModel sm);
        List<CompensationProgramModel> CtSelect();
        List<CompensationProgramModel> SelectCtBy(string id);
    }
}
