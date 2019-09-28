using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IPostBLL
    {
        int PostDelete(PostModel pm);
        List<PostModel> PostSelect();
        int PostAdd(PostModel pm);
        List<AttributeNameModel> ProfessionSelect();
    }
}
