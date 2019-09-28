using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace IDAO
{
    public interface ISalarySettingDAO
    {
        int SalarySettingAdd(SalarySettingModel s);
        int SalarySettingDel(SalarySettingModel s);
        List<SalarySettingModel> SalarySettingSelect();
    }
}
