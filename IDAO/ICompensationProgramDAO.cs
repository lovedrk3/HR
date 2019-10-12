using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAO
{
   public interface ICompensationProgramDAO
    {
        int CpAdd(CompensationProgramModel sm);
        int CpUpdate(CompensationProgramModel sm);
        List<CompensationProgramModel> CpSelect();
        List<CompensationProgramModel> SelectCpBy(string id);
    }
}
