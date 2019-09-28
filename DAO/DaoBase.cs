using EFEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
  public  class DaoBase<T> where T : class
    {
        // MyDbContext db = new MyDbContext();
        public static void WriteLog(Exception ex)
        {
            using (StreamWriter sw = new StreamWriter("错误日志.txt", true))
            {
                sw.WriteLine("错误内容：" + ex.Message);
                sw.WriteLine("错误时间:" + DateTime.Now);
            }
        }
        public static MyDbContext CreateContext() {
            MyDbContext db= CallContext.GetData("s") as MyDbContext;
            if (db==null)
            {
                db = new MyDbContext();
                CallContext.SetData("s", db);
            }
            return db;
        }

        public void FenLi(T t)
        {
            //1 创建ObjectDbContext对象
            MyDbContext db = CreateContext();
            var ObjContext = ((IObjectContextAdapter)db).ObjectContext;

            //2 创建新的 ObjectSet< TEntity > 实例
            var objSet = ObjContext.CreateObjectSet<T>();
            //3 为特定对象创建实体键，如果实体键已存在，则返回该键。
            var objKey = ObjContext.CreateEntityKey(objSet.EntitySet.Name, t);
            //4 返回具有指定实体键的对象。
            object objT;
            var ext = ObjContext.TryGetObjectByKey(objKey, out objT);
            //5 从对象上下文移除对象。
            if (ext)
            {
                ObjContext.Detach(objT);
            }
        }
        public int Add(T t)
        {
            MyDbContext db = CreateContext();
            int res = 0;
            try
            {
                db.Set<T>().Add(t);
                res = db.SaveChanges();
            }
            catch (Exception ex)
            {
                //WriteLog(ex);
            }
            return res;
                
        }

        public int Update(T t) {

            MyDbContext db = CreateContext();
            int res = 0;
            try
            {
                FenLi(t);
                db.Set<T>().Attach(t);
                db.Entry<T>(t).State = System.Data.Entity.EntityState.Modified;
                res = db.SaveChanges();
            }
            catch (Exception ex)
            {
                
                //WriteLog(ex);
            }
            return res;
        }
        public int Delete(T t) {
            MyDbContext db = CreateContext();
            int res = 0;
            try
            {
                FenLi(t);
                db.Set<T>().Attach(t);
                db.Entry<T>(t).State = System.Data.Entity.EntityState.Deleted;
                res = db.SaveChanges();
            }
            catch (Exception ex)
            {

                //WriteLog(ex);
            }
            return res;
        }

        public List<T> Select() {
            List<T> list = new List<T>();
            try
            {
                list=CreateContext().Set<T>().AsNoTracking().Select(e => e).ToList();
            }
            catch (Exception ex)
            {
                //WriteLog(ex);
            }
            return list;
        } 
    }
}
