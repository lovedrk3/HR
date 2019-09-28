using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAO
{
    public interface IPostDAO
    {
        int PostAdd(PostModel sm);
        int PostUpdate(PostModel sm);
        int PostDelete(PostModel sm);
        List<PostModel> PostSelect();
        //查询职称
        List<AttributeNameModel> ProfessionSelect();
    }
}
