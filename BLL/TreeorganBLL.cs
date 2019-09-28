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
    public class TreeorganBLL : ITreeorganBLL
    {
        ITreeorganDAO sd = IocCreate.CreateTreeorganDAL();

        public List<TreeorganModel> SelectStudentBy(int id)
        {
            return sd.SelectStudentBy(id);
        }

        public List<Dictionary<string, string>> SelectStudentBy3()
        {
            return sd.SelectStudentBy3();
        }

        public int StudentAdd(TreeorganModel sm)
        {
            return sd.StudentAdd(sm);
        }

        public int StudentDelete(TreeorganModel sm)
        {
            return sd.StudentDelete(sm);
        }

        public List<TreeorganModel> StudentSelect()
        {
            return sd.StudentSelect();
        }

        public int StudentUpdate(TreeorganModel sm)
        {
            return sd.StudentUpdate(sm);
        }


        public List<Dictionary<string, string>> SelectStudentBy4(int id)
        {
            return sd.SelectStudentBy4(id);
        }
    }
}
