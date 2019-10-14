using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAO;
using EFEntity;

namespace DAO
{
    public class CompensationTandardsDAO : DaoBase<CompensationTandards>, ICompensationTandardsDAO
    {
        public int CtAdd(CompensationTandardsModel sm)
        {
            CompensationTandards stu = new CompensationTandards() { Ctid = sm.Ctid, CtName = sm.CtName, CtMoney = sm.CtMoney, CtMan = sm.CtMan, Ctregist = sm.Ctregist, bz = sm.bz, fhyj = sm.fhyj, CtregistDate = sm.CtregistDate,CtState=sm.CtState };
            return Add(stu);
        }

        public int CtDelete(CompensationTandardsModel sm)
        {
            CompensationTandards stu = new CompensationTandards() { Ctid = sm.Ctid, CtName = sm.CtName, CtMoney = sm.CtMoney, CtMan = sm.CtMan, Ctregist = sm.Ctregist, bz = sm.bz, fhyj = sm.fhyj };
            return Delete(stu);
        }

        public List<CompensationTandardsModel> CtSelect()
        {
            MyDbContext db = new MyDbContext();
            List<CompensationTandards> list = Select();
            List<CompensationTandardsModel> list2 = new List<CompensationTandardsModel>();
            foreach (CompensationTandards item in list)
            {
                CompensationTandardsModel sm = new CompensationTandardsModel() { Ctid = item.Ctid, CtName = item.CtName, CtMoney = item.CtMoney, CtMan = item.CtMan, Ctregist = item.Ctregist, bz = item.bz, fhyj = item.fhyj };
                list2.Add(sm);
            }
            return list2;
        }

        public int CtUpdate(CompensationTandardsModel sm)
        {

            CompensationTandards stu = new CompensationTandards() { Ctid = sm.Ctid, CtName = sm.CtName, CtMoney = sm.CtMoney, fhyj = sm.fhyj , CtMan = sm.CtMan, Ctregist = sm.Ctregist, bz = sm.bz, CtregistDate=sm.CtregistDate,CtState=sm.CtState};
            return Update(stu);
        }

        public List<CompensationTandardsModel> SelectCtBy(string id)
        {
            MyDbContext db = CreateContext();
            List<CompensationTandards> list = db.CompensationTandards.AsNoTracking()
                  .Where(e => e.Ctid == id)
                  .Select(e => e)
                  .ToList();
            List<CompensationTandardsModel> list2 = new List<CompensationTandardsModel>();
            foreach (CompensationTandards item in list)
            {
                CompensationTandardsModel sm = new CompensationTandardsModel() { Ctid = item.Ctid, CtName = item.CtName, CtMoney = item.CtMoney, CtMan = item.CtMan, Ctregist = item.Ctregist, bz = item.bz, fhyj = item.fhyj, CtregistDate=item.CtregistDate };
                list2.Add(sm);
            }
            return list2;
        }

        public List<CompensationTandardsModel> FenYe<K>(int currentPage, int PageSize, out int rows)
        {
            List<CompensationTandardsModel> list = new List<CompensationTandardsModel>();
            MyDbContext db = CreateContext();
            var result4 = db.Set<CompensationTandards>()
             
                .AsNoTracking()
                .OrderBy(e => e.Ctid);
            
            
            var data = result4
                .Where(e=>e.CtState==1)
                 .Skip((currentPage - 1) * PageSize)//忽略多少条数
                 .Take(PageSize)//取多少条数
                 .ToList();
            
            foreach (var item in data)
            {
                CompensationTandardsModel pm = new CompensationTandardsModel()
                {
                    Ctid = item.Ctid,
                    CtName = item.CtName,
                    CtMoney = item.CtMoney,
                    CtMan = item.CtMan,
                    Ctregist = item.Ctregist,
                    CtregistDate = item.CtregistDate,
                    bz = item.bz,
                    fhyj = item.fhyj,
                   
                };
                list.Add(pm);

            }
            rows = result4.Count();//总行数
            return list;

        }


        public List<CompensationTandardsModel> FenYe2<K>(int currentPage, int PageSize, string Ctid,string CtName,DateTime dt1,DateTime dt2, out int rows)
        {
            List<CompensationTandardsModel> list = new List<CompensationTandardsModel>();
            MyDbContext db = CreateContext();
            var result4 = db.Set<CompensationTandards>()
                .AsNoTracking()
                .OrderBy(e => e.Ctid);
            
            var data = result4
                 .Where(e=>e.Ctid.Contains(Ctid) &&e.CtName.Contains(CtName)&& e.CtregistDate <= dt2 && e.CtregistDate>=dt1&&e.CtState==2 )
                 .Skip((currentPage - 1) * PageSize)//忽略多少条数
                 .Take(PageSize)//取多少条数
                 .ToList();
            
            foreach (var item in data)
            {
                CompensationTandardsModel pm = new CompensationTandardsModel()
                {
                    Ctid = item.Ctid,
                    CtName = item.CtName,
                    CtMoney = item.CtMoney,
                    CtMan = item.CtMan,
                    Ctregist = item.Ctregist,
                    CtregistDate = item.CtregistDate,
                    bz = item.bz,
                    fhyj = item.fhyj,
                   

                };
                list.Add(pm);

            }
            rows = data.Count();//总行数
            return list;
        }


        public List<CompensationTandardsModel> FenYe3<K>(int currentPage, int PageSize, string Ctid, string CtName, out int rows)
        {
            int num = 0;
            List<CompensationTandardsModel> list = new List<CompensationTandardsModel>();
            MyDbContext db = CreateContext();
            var result4 = db.Set<CompensationTandards>()
                .AsNoTracking()
                .OrderBy(e => e.Ctid);
            
            var data = result4
                 .Where(e => e.Ctid.Contains(Ctid) && e.CtName.Contains(CtName)&& e.CtState == 2)
                 .Skip((currentPage - 1) * PageSize)//忽略多少条数
                 .Take(PageSize)//取多少条数
                 .ToList();
            foreach (var item in data)
            {
                CompensationTandardsModel pm = new CompensationTandardsModel()
                {
                    Ctid = item.Ctid,
                    CtName = item.CtName,
                    CtMoney = item.CtMoney,
                    CtMan = item.CtMan,
                    Ctregist = item.Ctregist,
                    CtregistDate = item.CtregistDate,
                    bz = item.bz,
                    fhyj = item.fhyj,
                    

                };
                num = list.Count();
                list.Add(pm);

            }
            rows = data.Count();
            return list;
        }





    }
}
