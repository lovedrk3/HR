using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using IDAO;
using IOC;
using Model;

namespace BLL
{
    public class CpsssBLL : ICpsssBLL
    {
        ICpsssDAO pd = IocCreate.CreateCpsssDAL();
        public List<CpsssModel> CtSelect()
        {
            return pd.CtSelect();
        }
    }
}
