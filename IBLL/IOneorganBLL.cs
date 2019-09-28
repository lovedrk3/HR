using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IOneorganBLL
    {
        int OneorganAdd(OneorganModel sm);
        int OneorganUpdate(OneorganModel sm);
        int OneorganDelete(OneorganModel sm);
        List<OneorganModel> OneorganSelect();
        List<OneorganModel> SelectStudentBy(int id);
    }
}
