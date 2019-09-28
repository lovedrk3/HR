using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAO
{
    public interface ITwoorganDAO
    {
        int StudentAdd(TwoorganModel sm);
        int StudentUpdate(TwoorganModel sm);
        int StudentDelete(TwoorganModel sm);
        List<TwoorganModel> StudentSelect();
        List<TwoorganModel> SelectStudentBy(int id);
        List<TwoorganModel> StudentFenYe<K>(int currentPage, int PageSize, out int rows);

        List<Dictionary<string, string>> SelectStudentBy2();
        List<Dictionary<string, string>> SelectStudentBy3(int id);



    }
}
