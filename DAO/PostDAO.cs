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
    public class PostDAO : DaoBase<Post>, IPostDAO
    {
        public int PostAdd(PostModel p)
        {
            Post po = new Post() { PostId = p.PostId, PostName = p.PostName, PostClassifyId = p.PostClassifyId };
            return Add(po);
        }

        public int PostDelete(PostModel p)
        {
            Post po = new Post() { PostId = p.PostId, PostName = p.PostName };
            return Delete(po);
        }

        public List<PostModel> PostSelect()
        {
            List<Post> list = Select();
            List<PostModel> list2 = new List<PostModel>();
            foreach (Post item in list)
            {
                PostModel sm = new PostModel() { PostId = item.PostId, PostName = item.PostName };
                list2.Add(sm);
            }
            return list2;
        }

        public List<AttributeNameModel> ProfessionSelect()
        {
            MyDbContext db = new MyDbContext();
            List<AttributeName> list = db.AttributeName.AsNoTracking().Where(e => e.ATID == 14).Select(e => e).ToList();
            List<AttributeNameModel> list2 = new List<AttributeNameModel>();
            foreach (AttributeName item in list)
            {
                AttributeNameModel am = new AttributeNameModel() { ATID=item.ATID,ANName=item.ANName,ANID=item.ANID};
                list2.Add(am);
            }
            return list2;
        }

        public int PostUpdate(PostModel p)
        {
            throw new NotImplementedException();
        }
    }
}
