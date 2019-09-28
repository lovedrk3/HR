using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IPostClassifyBLL
    {
        int PostClassifyDelete(PostClassifyModel pm);
        List<PostClassifyModel> PostClassifySelect();
        int PostClassifyAdd(PostClassifyModel sm);
        List<Dictionary<string, string>> PostSel();
    }
}
