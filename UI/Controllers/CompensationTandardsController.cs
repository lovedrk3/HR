using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using IOC;
using Model;
using System.Web.SessionState;
using Newtonsoft.Json;
using System.Globalization;

namespace UI.Controllers
{
    public class CompensationTandardsController : Controller
    {
        ICompensationTandardsBLL sb = IocCreate.CreateCompensationTandardsBLL();
        ICompensationProgramBLL sb2 = IocCreate.CreateCompensationProgramBLL();
        ICpsssBLL sb3= IocCreate.CreateCpsssBLL();
        // GET: CompensationTandards
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2(int currentPage, int pageSize)
        {
            int rows;
            List<CompensationTandardsModel> list = sb.FenYe<int>(currentPage, pageSize, out rows);
            Dictionary<string, object> di = new Dictionary<string, object>();
            di["list"] = list;
            di["rows"] = rows;

            return Content(JsonConvert.SerializeObject(di));
        }
        //薪酬标准登记
        [HttpGet]
        public ActionResult Add()
        {
            //List<CompensationProgramModel> list = sb2.CtSelect();
            return View();
        }

        public ActionResult Checked()
        {
            List<CpsssModel> list = sb3.CtSelect();
            return Content(JsonConvert.SerializeObject(list)); 
        }

        [HttpPost]
        public ActionResult Add(CompensationTandardsModel ctm, CompensationProgramModel cpm)
        {
            Decimal? SumMoney = 0;
            List<CompensationProgramModel> list = new List<CompensationProgramModel>();
            string money = Request["details[0].salary"];
            string[] sArray = money.Split(',');
            string id = Request["details[0].itemId"];
            string[] sArray2 = id.Split(',');
            string name = Request["details[0].itemName"];
            string[] sArray3 = name.Split(',');

            for (int i = 0; i < sArray.Length; i++)
            {



                cpm.Cpid = int.Parse(sArray2[i]);
                cpm.CpMoney = Decimal.Parse(sArray[i]);
                cpm.CpName = sArray3[i];
                cpm.Ctid = ctm.Ctid;
                SumMoney = SumMoney + cpm.CpMoney;
                int result2 = sb2.CtAdd(cpm);
            }







            ctm.bz = Request["standard.remark"];
            ctm.fhyj = null;
            ctm.CtMoney = SumMoney;
            ctm.CtState = 1;
            int result = sb.CtAdd(ctm);

            return Content("<script>alert('提交成功');window.location.href='../CompensationTandards/Index';</script>");
          
        }

        

        [HttpGet]
        public ActionResult Update(string id)
        {

            List<CompensationTandardsModel> list = sb.SelectCtBy(id);
            List<CompensationProgramModel> list2 = sb2.SelectCtBy(id);
            ViewBag.list = list2;
            return View(list);
        }


        [HttpPost]
        public ActionResult Update(CompensationTandardsModel ctm, CompensationProgramModel cpm)
        {
            Decimal? SumMoney = 0;
            List<CompensationProgramModel> list = new List<CompensationProgramModel>();
            string money = Request["details[0].salary"];
            string[] sArray = money.Split(',');
            string id = Request["details[0].itemId"];
            string[] sArray2 = id.Split(',');
            string name = Request["details[0].itemName"];
            string[] sArray3 = name.Split(',');

            for (int i = 0; i < sArray.Length; i++)
            {


                
                cpm.Cpid = int.Parse(sArray2[i]);
                cpm.CpMoney = Decimal.Parse(sArray[i]);
                cpm.CpName = sArray3[i];
                SumMoney = SumMoney + cpm.CpMoney;
                int result2 = sb2.CtUpdate(cpm);
            }

            ctm.bz = Request["details[0].bz"];
            string ddd = Request["dddd"];
            ctm.CtregistDate = DateTime.Parse(Request["dddd"]);
            ctm.fhyj = Request["standard.remark"];
            ctm.CtMoney = SumMoney;
            ctm.CtState = 2;
            int result = sb.CtUpdate(ctm);

            if (result > 0)
            {
                return Content("<script>alert('复核成功');window.location.href='../CompensationTandards/Index';</script>");
            }
            else
            {
                return Content(JsonConvert.SerializeObject(ctm));
            }
        }


        //薪酬标准变更
        [HttpGet]
        public ActionResult Update2(string id)
        {

            List<CompensationTandardsModel> list = sb.SelectCtBy(id);
            List<CompensationProgramModel> list2 = sb2.SelectCtBy(id); ;
            ViewBag.list = list2;
            return View(list);
        }


        [HttpPost]
        public ActionResult Update2(CompensationTandardsModel ctm, CompensationProgramModel cpm)
        {
            Decimal? SumMoney = 0;
            List<CompensationProgramModel> list = new List<CompensationProgramModel>();
            string money = Request["details[0].salary"];
            string[] sArray = money.Split(',');
            string id = Request["details[0].itemId"];
            string[] sArray2 = id.Split(',');
            string name = Request["details[0].itemName"];
            string[] sArray3 = name.Split(',');

            for (int i = 0; i < sArray.Length; i++)
            {



                cpm.Cpid = int.Parse(sArray2[i]);
                cpm.CpMoney = Decimal.Parse(sArray[i]);
                cpm.CpName = sArray3[i];
                SumMoney = SumMoney + cpm.CpMoney;
                int result2 = sb2.CtUpdate(cpm);
            }

            ctm.bz = Request["standard.remark"];
            ctm.CtregistDate = DateTime.Parse(Request["dddd"]);
            ctm.Ctregist = Request["userName"];
            ctm.fhyj= Request["fhyj"];
            ctm.CtMoney = SumMoney;
            ctm.CtState = 1;
            int result = sb.CtUpdate(ctm); 

            if (result > 0)
            {
                return Content("<script>alert('变更成功');window.location.href='../CompensationTandards/Index';</script>");
            }
            else
            {
                return Content(JsonConvert.SerializeObject(ctm));
            }
        }
        //薪酬标准查询
        public ActionResult SelectShow()
        {

            return View();
        }
       
        [HttpPost]
        public ActionResult SelectShows()
        {

           
            Session["Ctid"] = Request["standard.standardId"];
            ViewBag.Ctid= Request["standard.standardId"];
            Session["CtName"] = Request["utilbean.primarKey"];
            Session["Date1"] = Request["utilbean.startDate"];
            Session["Date2"] = Request["utilbean.endDate"];
            string ctid = Request["standard.standardId"];
            Response.Redirect("SelectShow2");
            return View();
        }
        public ActionResult SelectShow2()
        {

            
            return View();
        }

        public ActionResult SelectShow3(int currentPage, int pageSize)
        {
            int rows;
            string Ctid = "";
            string CtName = "";
            if (Session["Ctid"] == null)
            {
                Ctid = "";
            }
            else
            {
                Ctid = Session["Ctid"].ToString();
               
            }
            if (Session["CtName"] == null)
            {
                CtName = "";
            }
            else
            {
                CtName = Session["CtName"].ToString();
            }
            List<CompensationTandardsModel> list = new List<CompensationTandardsModel>();
            if (Session["Date1"] == null|| Session["Date1"].ToString()=="")
            {
                list = sb.FenYe3<object>(currentPage, pageSize, Ctid, CtName, out rows);
            }
            else
            {
                list = sb.FenYe2<object>(currentPage, pageSize, Ctid, CtName, DateTime.Parse(Session["Date1"].ToString()), DateTime.Parse(Session["Date2"].ToString()), out rows);
            }

                //List<CompensationTandardsModel> list = sb.FenYe2<object>(currentPage, pageSize, Session["Ctid"].ToString(), Session["CtName"].ToString(), DateTime.Parse(Session["Date1"].ToString()), DateTime.Parse(Session["Date2"].ToString()), out rows);

               
            Dictionary<string, object> di = new Dictionary<string, object>();
            di["list"] = list;
            di["rows"] = rows;
            ViewBag.c = list.Count();
            return Content(JsonConvert.SerializeObject(di));
         }

    }
}