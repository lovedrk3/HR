using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IBLL;
using IOC;
using IDAO;


namespace BLL
{
    public class CompensationProgramBLL : ICompensationProgramBLL
    {
        ICompensationProgramDAO sd = IocCreate.CreateCompensationProgramDAL();
        public int CtAdd(CompensationProgramModel sm)
        {
            return sd.CpAdd(sm);
        }

    

        public List<CompensationProgramModel> CtSelect()
        {
            return sd.CpSelect();
        }

        public int CtUpdate(CompensationProgramModel sm)
        {
            return sd.CpUpdate(sm);
        }

        public List<CompensationProgramModel> SelectCtBy(string id)
        {
            return sd.SelectCpBy(id);
        }
    }
}
