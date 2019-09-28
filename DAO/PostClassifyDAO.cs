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
    public class PostClassifyDAO : DaoBase<PostClassify>, IPostClassifyDAO
    {
        public int PostClassifyAdd(PostClassifyModel pcm)
        {
            PostClassify p = new PostClassify() { PostClassifyId = pcm.PostClassifyId, PostClassifyName = pcm.PostClassifyName };
            return Add(p);
        }

        public int PostClassifyDelete(PostClassifyModel pcm)
        {
            PostClassify po = new PostClassify() { PostClassifyId = pcm.PostClassifyId, PostClassifyName = pcm.PostClassifyName };
            return Delete(po);
        }

        public List<PostClassifyModel> PostClassifySelect()
        {
            List<PostClassify> list = Select();
            List<PostClassifyModel> list2 = new List<PostClassifyModel>();
            foreach (PostClassify item in list)
            {
                PostClassifyModel sm = new PostClassifyModel() { PostClassifyId = item.PostClassifyId, PostClassifyName = item.PostClassifyName };
                list2.Add(sm);
            }
            return list2;
        }

        public List<Dictionary<string, string>> PostSel()
        {
            MyDbContext db = new MyDbContext();
            var res = db.PostClassify.AsNoTracking()
            .Join(db.Post, c => c.PostClassifyId, s => s.PostClassifyId, (c, s) => new { c.PostClassifyId, c.PostClassifyName, s.PostId, s.PostName });
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
            foreach (var item in res)
            {
                Dictionary<string, string> di = new Dictionary<string, string>();
                di.Add("PostClassifyId", item.PostClassifyId.ToString());
                di.Add("PostClassifyName", item.PostClassifyName);
                di.Add("PostId", item.PostId.ToString());
                di.Add("PostName", item.PostName);
                list.Add(di);
            }
            return list;
        }
    }
}
