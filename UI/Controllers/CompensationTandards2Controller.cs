using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class CompensationTandards2Controller : Controller
    {
        // GET: CompensationTandards2
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            Session["Ctid"] = Request["standard.standardId"];
            Session["CtName"] = Request["utilbean.primarKey"];
            Session["Date1"] = Request["utilbean.startDate"];
            Session["Date2"] = Request["utilbean.endDate"];
            string CtName= Request["utilbean.primarKey"];
            string Date1= Request["utilbean.startDate"];

            return Content("<script>window.location.href='../CompensationTandards/SelectShow2';</script>");
        }


        public ActionResult Index3()
        {
            return View();
        }

        public ActionResult Index4()
        {
            Session["Ctid"] = Request["standard.standardId"];
            Session["CtName"] = Request["utilbean.primarKey"];
            Session["Date1"] = Request["utilbean.startDate"];
            Session["Date2"] = Request["utilbean.endDate"];
            string CtName = Request["utilbean.primarKey"];
            string Date1 = Request["utilbean.startDate"];
            Session["bb"] = "aaa";
            return Content("<script>window.location.href='../CompensationTandards/SelectShow2';</script>");
        }
    }
}