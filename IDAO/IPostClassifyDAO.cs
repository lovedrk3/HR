using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAO
{
    public interface IPostClassifyDAO
    {
        int PostClassifyAdd(PostClassifyModel pcm);
        int PostClassifyDelete(PostClassifyModel pcm);
        List<PostClassifyModel> PostClassifySelect();
        List<Dictionary<string, string>> PostSel();
    }
}
