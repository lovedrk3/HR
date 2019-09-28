using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using IOC;
using Model;
using Newtonsoft.Json;
namespace UI.Controllers
{
    public class SalarySettingController : Controller
    {
        ISalarySettingBLL isb = IocCreate.CreateSalarySettingBLL();
        // GET: SalarySetting
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return Content(JsonConvert.SerializeObject(isb.SalarySettingSelect()));
        }
        public ActionResult Del(int id)
        {
            SalarySettingModel ss = new SalarySettingModel() { SID = id };
            if (isb.SalarySettingDel(ss) > 0)
            {
                return Content("");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(string SName)
        {
            SalarySettingModel ss = new SalarySettingModel() { SName = SName };
            if (isb.SalarySettingAdd(ss) > 0)
            {
                return Content("<script>alert('添加成功');window.location.href='Index'</script>");
            }
            return View();
        }
    }
}