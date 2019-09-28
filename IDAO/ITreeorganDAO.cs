using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAO
{
    public interface ITreeorganDAO
    {
        int StudentAdd(TreeorganModel sm);
        int StudentUpdate(TreeorganModel sm);
        int StudentDelete(TreeorganModel sm);
        List<TreeorganModel> StudentSelect();
        List<TreeorganModel> SelectStudentBy(int id);

        List<Dictionary<string, string>> SelectStudentBy3();

        List<Dictionary<string, string>> SelectStudentBy4(int id);

    }
}
