using IBLL;
using IDAO;
using IOC;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PostClassifyBLL : IPostClassifyBLL
    {
        IPostClassifyDAO ipd = IocCreate.CreatePostClassifyDAL();

        public int PostClassifyAdd(PostClassifyModel sm)
        {
            return ipd.PostClassifyAdd(sm);
        }

        public int PostClassifyDelete(PostClassifyModel pm)
        {
            return ipd.PostClassifyDelete(pm);
        }

        public List<PostClassifyModel> PostClassifySelect()
        {
            return ipd.PostClassifySelect();
        }

        public List<Dictionary<string, string>> PostSel()
        {
            return ipd.PostSel();
        }
    }
}
