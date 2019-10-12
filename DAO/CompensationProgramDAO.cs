using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using EFEntity;
using IDAO;

namespace DAO
{
    public class CompensationProgramDAO : DaoBase<CompensationProgram>, ICompensationProgramDAO
    {
        public int CpAdd(CompensationProgramModel sm)
        {
            CompensationProgram stu = new CompensationProgram() { Cpid = sm.Cpid, CpName = sm.CpName, CpMoney = sm.CpMoney,Ctid=sm.Ctid};
            return Add(stu);
        }

        public List<CompensationProgramModel> CpSelect()
        {
            MyDbContext db = new MyDbContext();
            List<CompensationProgram> list = Select();
            List<CompensationProgramModel> list2 = new List<CompensationProgramModel>();
            foreach (CompensationProgram item in list)
            {
                CompensationProgramModel sm = new CompensationProgramModel() { Cpid = item.Cpid, CpName = item.CpName, CpMoney = item.CpMoney};
                list2.Add(sm);
            }
            return list2;
        }

        public int CpUpdate(CompensationProgramModel sm)
        {
            CompensationProgram stu = new CompensationProgram() { Cpid = sm.Cpid, CpName = sm.CpName, CpMoney = sm.CpMoney ,Ctid=sm.Ctid};
                    
            return Update(stu);
        }

        public List<CompensationProgramModel> SelectCpBy(string id)
        {
            MyDbContext db = CreateContext();
            List<CompensationProgram> list = db.CompensationProgram.AsNoTracking()
                  .Where(e => e.Ctid == id)
                  .Select(e => e)
                  .ToList();
            List<CompensationProgramModel> list2 = new List<CompensationProgramModel>();
            foreach (CompensationProgram item in list)
            {
                CompensationProgramModel sm = new CompensationProgramModel() { Cpid = item.Cpid, CpName = item.CpName, CpMoney = item.CpMoney,Ctid=item.Ctid };
                list2.Add(sm);
            }
            return list2; ;
        }


    }
}
