using CaseStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace CaseStudy.Controllers
{
    public class HomeController : Controller
    {
        public PaymentDbEntities db=new PaymentDbEntities();
        EntityListViewModel model=new EntityListViewModel();    

        public ActionResult Index()
        {
            using (var context = new PaymentDbEntities())
            {
                var data = context.Invoices.ToList();
                return View(data);
            } 
        }

        public ActionResult Index2(int id)
        { 
            using (var context = new PaymentDbEntities())
            {
                var data = context.Payments.Where(x=>x.InvoiceId==id).ToList();
                return View(data.ToList());
            }
        }
       
        public ActionResult Index3(int id)
        {
           
            var q1 = db.Payments.Where(x => x.InvoiceId == id).ToList();
                      
            return View(q1.ToList());
        }
        public ActionResult getlist(int id)
        {

            var q1 = (from c in db.Invoices
                      join pt in db.Payments on c.INVOICEID equals pt.InvoiceId into ps_jointable
                      from p in ps_jointable
                      select new { c.INVOICEID, p.InvoiceId });

            return View(q1.ToList());


        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}