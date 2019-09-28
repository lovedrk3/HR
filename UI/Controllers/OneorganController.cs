using IBLL;
using IOC;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class OneorganController : Controller
    {
        IOneorganBLL sb = IocCreate.CreateOneorganBLL();
        // GET: Oneorgan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            List<OneorganModel> list = sb.OneorganSelect();
            return Content(JsonConvert.SerializeObject(list));
        }
        [HttpGet]
        public ActionResult Update(int id)
        {

            List<OneorganModel> list = sb.SelectStudentBy(id);
            return View(list);

        }

        [HttpPost]
        public ActionResult Update(OneorganModel om)
        {
            om.Oid = int.Parse(Request["cffk.firstKindId"]);
            om.OName = Request["cffk.firstKindName"];
            om.Pid = int.Parse(Request["cffk.firstKindSalaryId"]);
            om.SID = int.Parse(Request["cffk.firstKindSaleId"]);
            int result = sb.OneorganUpdate(om);

            if (result > 0)
            {
                return Content("<script>alert('修改成功');window.location.href='../Oneorgan/Index';</script>");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }


        [HttpGet]
        public ActionResult Add()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Add(string OName,int Pid,int SID)
        {
            //om.OName = Request["cffk.firstKindName"];
            //om.Pid = int.Parse(Request["cffk.firstKindSalaryId"]);
            //om.SID = int.Parse(Request["cffk.firstKindSaleId"]);
            OneorganModel om = new OneorganModel() { OName=OName,Pid=Pid,SID=SID};
            int result = sb.OneorganAdd(om);

            if (result > 0)
            {
                return Content("<script>alert('添加成功');window.location.href='../Oneorgan/Index';</script>");
            }
            else
            {
                return RedirectToAction("Index");
            }


        }

        public ActionResult Del(int id)
        {
            OneorganModel om = new OneorganModel();
            om.Oid = id;
            int result = sb.OneorganDelete(om);
            if (result > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='../Index';</script>");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }


    }
}