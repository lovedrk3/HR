using EFEntity;
using IDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAO
{
    public class OneorganDAO : DaoBase<Oneorgan>, IOneorganDAO
    {
        public int OneorganAdd(OneorganModel sm)
        {
            Oneorgan stu = new Oneorgan() { Oid = sm.Oid, OName = sm.OName, Pid = sm.Pid, SID = sm.SID };
            return Add(stu);
        }

        public int OneorganDelete(OneorganModel sm)
        {
            Oneorgan stu = new Oneorgan() { Oid = sm.Oid, OName = sm.OName, Pid = sm.Pid, SID = sm.SID };
            return Delete(stu);
        }

        public List<OneorganModel> OneorganSelect()
        {
            List<Oneorgan> list = Select();
            List<OneorganModel> list2 = new List<OneorganModel>();
            foreach (Oneorgan item in list)
            {
                OneorganModel sm = new OneorganModel() { Oid = item.Oid, OName = item.OName, Pid = item.Pid, SID = item.SID };
                list2.Add(sm);
            }
            return list2;
        }

        public int OneorganUpdate(OneorganModel sm)
        {
            Oneorgan stu = new Oneorgan() { Oid = sm.Oid, OName = sm.OName, Pid = sm.Pid, SID = sm.SID };
            return Update(stu);
        }

        public List<OneorganModel> SelectStudentBy(int id)
        {
            MyDbContext db = CreateContext();
            List<Oneorgan> list = db.Oneorgan.AsNoTracking()
                  .Where(e => e.Oid == id)
                  .Select(e => e)
                  .ToList();
            List<OneorganModel> list2 = new List<OneorganModel>();
            foreach (Oneorgan item in list)
            {
                OneorganModel sm = new OneorganModel() { Oid = item.Oid, OName = item.OName, Pid = item.Pid, SID = item.SID };
                list2.Add(sm);
            }
            return list2; 
        }
    }
}
