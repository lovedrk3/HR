using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IBLL;
using IDAO;
using DAO;
using IOC;
namespace BLL
{
    public class SalarySettingBLL : ISalarySettingBLL
    {
        ISalarySettingDAO isd = IocCreate.CreateSalarySettingDAL();
        public int SalarySettingAdd(SalarySettingModel s)
        {
            return isd.SalarySettingAdd(s);
        }

        public int SalarySettingDel(SalarySettingModel s)
        {
            return isd.SalarySettingDel(s);
        }

        public List<SalarySettingModel> SalarySettingSelect()
        {
            return isd.SalarySettingSelect();
        }
    }
}
