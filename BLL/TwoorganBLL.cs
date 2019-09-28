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
    public class TwoorganBLL : ITwoorganBLL
    {

        ITwoorganDAO sd = IocCreate.CreateTwoorganDAL();
        public List<TwoorganModel> SelectStudentBy(int id)
        {
            return sd.SelectStudentBy(id);
        }

        public int StudentAdd(TwoorganModel sm)
        {
            return sd.StudentAdd(sm);
        }

        public int StudentDelete(TwoorganModel sm)
        {
            return sd.StudentDelete(sm);
        }

        public List<TwoorganModel> StudentFenYe<K>(int currentPage, int PageSize, out int rows)
        {
            throw new NotImplementedException();
        }

        public List<TwoorganModel> StudentSelect()
        {
            return sd.StudentSelect();
        }

        public int StudentUpdate(TwoorganModel sm)
        {
            return sd.StudentUpdate(sm);
        }

        public List<Dictionary<string, string>> SelectStudentBy2()
        {
            return sd.SelectStudentBy2();
        }

        public List<Dictionary<string, string>> SelectStudentBy3(int id)
        {
            return sd.SelectStudentBy3(id);
        }
    }
}
