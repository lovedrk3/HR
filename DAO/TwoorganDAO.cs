using EFEntity;
using IDAO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TwoorganDAO : DaoBase<Twoorgan>, ITwoorganDAO
    {
        public List<TwoorganModel> SelectStudentBy(int id)
        {

            MyDbContext db = CreateContext();
            List<Twoorgan> list = db.Twoorgan.AsNoTracking()
                  .Where(e => e.Tid == id)
                  .Select(e => e)
                  .ToList();
            List<TwoorganModel> list2 = new List<TwoorganModel>();
            foreach (Twoorgan item in list)
            {
                TwoorganModel sm = new TwoorganModel() { Tid = item.Tid, TName = item.TName, Pid = item.Pid, Sid = item.Sid };
                list2.Add(sm);
            }
            return list2; ;
        }

        public int StudentAdd(TwoorganModel sm)
        {
            Twoorgan stu = new Twoorgan() { Tid = sm.Tid, TName = sm.TName, Pid = sm.Pid, Sid = sm.Sid, Oid = sm.Oid };
            return Add(stu);
        }

        public int StudentDelete(TwoorganModel sm)
        {
            Twoorgan stu = new Twoorgan() { Tid = sm.Tid, TName = sm.TName, Pid = sm.Pid, Sid = sm.Sid, Oid = sm.Oid };
            return Delete(stu);
        }

        public List<TwoorganModel> StudentFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<TwoorganModel> StudentSelect()
        {
            List<Twoorgan> list = Select();
            List<TwoorganModel> list2 = new List<TwoorganModel>();
            foreach (Twoorgan item in list)
            {
                TwoorganModel sm = new TwoorganModel() { Tid = item.Tid, TName = item.TName, Pid = item.Pid, Sid = item.Sid, Oid = item.Oid };
                list2.Add(sm);
            }
            return list2;
        }

        public int StudentUpdate(TwoorganModel sm)
        {
            Twoorgan stu = new Twoorgan() { Tid = sm.Tid, TName = sm.TName, Pid = sm.Pid, Sid = sm.Sid, Oid = sm.Oid };
            return Update(stu);
        }

        public List<Dictionary<string, string>> SelectStudentBy2()
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();


            using (MyDbContext db = new MyDbContext())
            {
                var result9 = from e in db.Oneorgan
                              join p in db.Twoorgan
                                on e.Oid equals p.Oid
                              select new { II级编号 = p.Tid, I级编号 = p.Oid, 学生姓名 = p.TName, 班级名称 = e.OName, 薪酬 = p.Pid, 销售 = p.Sid };


                foreach (var item in result9)
                {

                    Dictionary<string, string> di = new Dictionary<string, string>();


                    di.Add("Tid", item.II级编号.ToString());
                    di.Add("OName", item.班级名称);
                    di.Add("TName", item.学生姓名);
                    di.Add("Pid", item.薪酬.ToString());
                    di.Add("Sid", item.销售.ToString());

                    list.Add(di);
                }
                return list;
            }

        }



        public List<Dictionary<string, string>> SelectStudentBy3(int id)
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();


            using (MyDbContext db = new MyDbContext())
            {
                var result9 = from e in db.Oneorgan
                              join p in db.Twoorgan
                                on e.Oid equals p.Oid
                              where p.Tid == id
                              select new { II级编号 = p.Tid, I级编号 = e.Oid, 学生姓名 = p.TName, 班级名称 = e.OName, 薪酬 = p.Pid, 销售 = p.Sid };


                foreach (var item in result9)
                {

                    Dictionary<string, string> di = new Dictionary<string, string>();


                    di.Add("Tid", item.II级编号.ToString());
                    di.Add("OName", item.班级名称);
                    di.Add("TName", item.学生姓名);
                    di.Add("Pid", item.薪酬.ToString());
                    di.Add("Sid", item.销售.ToString());
                    di.Add("Oid", item.I级编号.ToString());

                    list.Add(di);
                }
                return list;
            }
        }
    }
}
