using IBLL;
using IOC;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class TreeorganController : Controller
    {
        // GET: Treeorgan
        IOneorganBLL sb2 = IocCreate.CreateOneorganBLL();
        ITwoorganBLL sb = IocCreate.CreateTwoorganBLL();
        ITreeorganBLL sb3 = IocCreate.CreateTreeorganBLL();
        public ActionResult Index()
        {
            object list = sb3.SelectStudentBy3();
            ViewBag.l = list;
            return View();
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            List<Dictionary<string, string>> list = sb3.SelectStudentBy4(id);
            ViewBag.list2 = list;
            return View();
        }

        [HttpPost]
        public ActionResult Update(TreeorganModel om)
        {
            om.ThName = Request["cftk.thirdKindName"];
            om.Oid = int.Parse(Request["cffk.firstKindId123Oid"]);
            om.Tid = int.Parse(Request["cffk.firstKindId123Tid"]);
            om.Thid = int.Parse(Request["cftk.thirdKindId"]);
            om.Sid = int.Parse(Request["cftk.thirdKindSaleId"]);
            om.yesno = int.Parse(Request["cftk.thirdKindIsRetail"]);
            int result = sb3.StudentUpdate(om);
            if (result > 0)
            {
                return Content("<script>alert('修改成功 ');window.location.href='../Index';</script>");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
        public ActionResult Del(int id)
        {
            TreeorganModel om = new TreeorganModel();
            om.Thid = id;
            int result = sb3.StudentDelete(om);
            if (result > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='../Index';</script>");
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
            object list2 = sb3.SelectStudentBy3();
            ViewBag.l = list2;
            return View(list); 
        }
        [HttpPost]
        public ActionResult Add(TreeorganModel om)
        {
            om.ThName = Request["cftk.thirdKindName"];
            om.Oid = int.Parse(Request["cftk.firstKindId"]);
            om.Tid = int.Parse(Request["cftk.secondKindId"]);
            om.Sid = int.Parse(Request["cftk.thirdKindSaleId"]);
            om.yesno = int.Parse(Request["cftk.thirdKindIsRetail"]);
            int result = sb3.StudentAdd(om);

            if (result > 0)
            {
                return Content("<script>alert('添加成功');window.location.href='../Treeorgan/Index';</script>");
            }
            else
            {
                return RedirectToAction("Index");
            }


        }
    }
}