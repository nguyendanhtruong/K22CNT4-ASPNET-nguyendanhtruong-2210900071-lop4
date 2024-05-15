using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ndt.lesson04.Models
{
    public class NdtCustomerController : Controller
    {
        // GET: NdtCustomer
        public ActionResult Index()
        {
            return View();
        }
        // Action NdtCustomerDetail
        public ActionResult NdtCustomerDetail()
        {
            //tạo đối tượng dữ liệu
            var customer = new NdtCustomer()
            {
               CustomerId
               FirstName
            };
            return View();

        }
    }
}