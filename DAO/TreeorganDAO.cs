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
    public class TreeorganDAO : DaoBase<Treeorgan>, ITreeorganDAO
    {
        public List<TreeorganModel> SelectStudentBy(int id)
        {

            MyDbContext db = CreateContext();
            List<Treeorgan> list = db.Treeorgan.AsNoTracking()
                  .Where(e => e.Thid == id)
                  .Select(e => e)
                  .ToList();
            List<TreeorganModel> list2 = new List<TreeorganModel>();
            foreach (Treeorgan item in list)
            {
                TreeorganModel sm = new TreeorganModel() { Thid = item.Thid, Oid = item.Oid, Tid = item.Tid, ThName = item.ThName, yesno = item.yesno, Sid = item.Sid };
                list2.Add(sm);
            }
            return list2; ;
        }

        public int StudentAdd(TreeorganModel sm)
        {
            Treeorgan stu = new Treeorgan() { Thid = sm.Thid, Oid = sm.Oid, Tid = sm.Tid, ThName = sm.ThName, yesno = sm.yesno, Sid = sm.Sid };
            return Add(stu);
        }

        public int StudentDelete(TreeorganModel sm)
        {
            Treeorgan stu = new Treeorgan() { Thid = sm.Thid, Oid = sm.Oid, Tid = sm.Tid, ThName = sm.ThName, yesno = sm.yesno, Sid = sm.Sid };
            return Delete(stu);
        }

        public List<TreeorganModel> StudentSelect()
        {
            List<Treeorgan> list = Select();
            List<TreeorganModel> list2 = new List<TreeorganModel>();
            foreach (Treeorgan item in list)
            {
                TreeorganModel sm = new TreeorganModel() { Thid = item.Thid, Oid = item.Oid, Tid = item.Tid, ThName = item.ThName, yesno = item.yesno, Sid = item.Sid };
                list2.Add(sm);
            }
            return list2;
        }

        public int StudentUpdate(TreeorganModel sm)
        {
            Treeorgan stu = new Treeorgan() { Thid = sm.Thid, Oid = sm.Oid, Tid = sm.Tid, ThName = sm.ThName, yesno = sm.yesno, Sid = sm.Sid };
            return Update(stu);
        }


        public List<Dictionary<string, string>> SelectStudentBy3()
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();


            using (MyDbContext db = new MyDbContext())
            {
                var result9 = from e in db.Treeorgan
                              join p in db.Twoorgan on e.Tid equals p.Tid
                              join s in db.Oneorgan
                                on e.Oid equals s.Oid
                              select new { s.Oid, s.OName, p.Tid, p.TName, e.Thid, e.ThName, e.Sid, e.yesno };


                foreach (var item in result9)
                {

                    Dictionary<string, string> di = new Dictionary<string, string>();


                    di.Add("Oid", item.Oid.ToString());
                    di.Add("OName", item.OName);
                    di.Add("Tid", item.Tid.ToString());
                    di.Add("TName", item.TName.ToString());
                    di.Add("Thid", item.Thid.ToString());
                    di.Add("ThName", item.ThName);
                    di.Add("Sid", item.Sid.ToString());
                    di.Add("yesno", item.yesno.ToString());
                    list.Add(di);
                }
                return list;
            }
        }


        public List<Dictionary<string, string>> SelectStudentBy4(int id)
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();


            using (MyDbContext db = new MyDbContext())
            {
                var result9 = from e in db.Treeorgan
                              join p in db.Twoorgan on e.Tid equals p.Tid
                              join s in db.Oneorgan
                                on e.Oid equals s.Oid
                              where e.Thid == id
                              select new { s.Oid, s.OName, p.Tid, p.TName, e.Thid, e.ThName, e.Sid, e.yesno };


                foreach (var item in result9)
                {

                    Dictionary<string, string> di = new Dictionary<string, string>();


                    di.Add("Oid", item.Oid.ToString());
                    di.Add("OName", item.OName);
                    di.Add("Tid", item.Tid.ToString());
                    di.Add("TName", item.TName.ToString());
                    di.Add("Thid", item.Thid.ToString());
                    di.Add("ThName", item.ThName);
                    di.Add("Sid", item.Sid.ToString());
                    di.Add("yesno", item.yesno.ToString());
                    list.Add(di);
                }
                return list;
            }
        }


    }
}
