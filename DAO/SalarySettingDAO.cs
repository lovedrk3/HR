using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAO;
using EFEntity;

namespace DAO
{
    public class SalarySettingDAO :DaoBase<SalarySetting>,ISalarySettingDAO
    {
        public int SalarySettingAdd(SalarySettingModel s)
        {
            SalarySetting ss = new SalarySetting() { SID=s.SID,SName=s.SName};
            return Add(ss);
        }

        public int SalarySettingDel(SalarySettingModel s)
        {
            SalarySetting ss = new SalarySetting() { SID = s.SID, SName = s.SName };
            return Delete(ss);
        }

        public List<SalarySettingModel> SalarySettingSelect()
        {
            List<SalarySetting> list = Select();
            List<SalarySettingModel> list2 = new List<SalarySettingModel>();
            foreach (SalarySetting item in list)
            {
                SalarySettingModel sm = new SalarySettingModel() { SID=item.SID,SName=item.SName };
                list2.Add(sm);
            }
            return list2;
        }
    }
}
