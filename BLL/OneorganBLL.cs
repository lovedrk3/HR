using IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IOC;
using IDAO;

namespace BLL
{
    public class OneorganBLL : IOneorganBLL
    {
        IOneorganDAO sd = IocCreate.CreateOneorganDAL();

      

        public int OneorganAdd(OneorganModel sm)
        {
            return sd.OneorganAdd(sm);
        }

        public int OneorganDelete(OneorganModel sm)
        {
            return sd.OneorganDelete(sm);
        }

        public List<OneorganModel> OneorganSelect()
        {
            return sd.OneorganSelect();
        }

        public int OneorganUpdate(OneorganModel sm)
        {
            return sd.OneorganUpdate(sm);
        }

        public List<OneorganModel> SelectStudentBy(int id)
        {
            return sd.SelectStudentBy(id);
        }
    }
}
