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
    public class PostBLL : IPostBLL
    {
        IPostDAO pd = IocCreate.CreatePostDAL();

        public int PostAdd(PostModel pm)
        {
            return pd.PostAdd(pm);
        }

        public int PostDelete(PostModel pm)
        {
            return pd.PostDelete(pm);
        }

        public List<PostModel> PostSelect()
        {
            return pd.PostSelect();
        }

        public List<AttributeNameModel> ProfessionSelect()
        {
            return pd.ProfessionSelect();
        }
    }
}
