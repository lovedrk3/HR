using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IBLL
{
    public interface ISalarySettingBLL
    {
        int SalarySettingAdd(SalarySettingModel s);
        int SalarySettingDel(SalarySettingModel s);
        List<SalarySettingModel> SalarySettingSelect();
    }
}
