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
    public class TwoorganController : Controller
    {
        // GET: Twoorgan
        IOneorganBLL sb2 = IocCreate.CreateOneorganBLL();
        ITwoorganBLL sb = IocCreate.CreateTwoorganBLL();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            List<Dictionary<string, string>> list = sb.SelectStudentBy2();
            return Content(JsonConvert.SerializeObject(list));
        }


        [HttpGet]
        public ActionResult Update(int id)
        {

            List<Dictionary<string, string>> list = sb.SelectStudentBy3(id);
            ViewBag.list = list;


            return View();

        }

        [HttpPost]
        public ActionResult Update(TwoorganModel om)
        {

            om.Tid = int.Parse(Request["cfsk.secondKindId2"]);
            om.Pid = int.Parse(Request["cffk.firstKindSalaryId"]);
            om.Sid = int.Parse(Request["cffk.firstKindSaleId"]);
            om.TName = Request["cffk.firstKindName"];
            om.Oid = int.Parse(Request["cffk.firstKindId123"]);
            int result = sb.StudentUpdate(om);

            if (result > 0)
            {
                return Content("<script>alert('修改成功 ');window.location.href='../Twoorgan/Index';</script>");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }


        [HttpGet]
        public ActionResult Add()
        {
            List<OneorganModel> list = sb2.OneorganSelect();
            return View(list);

        }


        [HttpPost]
        public ActionResult Add(string TName,int Pid,int Sid)
        {
            TwoorganModel om = new TwoorganModel() { Oid= int.Parse(Request["cfsk.firstKindId"]) ,TName=TName,Pid=Pid,Sid=Sid};
            int result = sb.StudentAdd(om);

            if (result > 0)
            {
                return Content("<script>alert('添加成功');window.location.href='../Twoorgan/Index';</script>");
            }
            else
            {
                return RedirectToAction("Index");
            }


        }

        public ActionResult Del(int id)
        {
            TwoorganModel om = new TwoorganModel();
            om.Tid = id;
            int result = sb.StudentDelete(om);
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