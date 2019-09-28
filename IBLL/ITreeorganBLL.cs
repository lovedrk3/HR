using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface ITreeorganBLL
    {
        int StudentAdd(TreeorganModel sm);
        int StudentUpdate(TreeorganModel sm);
        int StudentDelete(TreeorganModel sm);
        List<TreeorganModel> StudentSelect();
        List<Dictionary<string, string>> SelectStudentBy3();

        List<Dictionary<string, string>> SelectStudentBy4(int id);

    }
}
