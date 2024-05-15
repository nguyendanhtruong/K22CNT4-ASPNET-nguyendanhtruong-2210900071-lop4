using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
                CustomerId = 1,
                FirstName = "Nguyễn Danh",
                LastName = "Trường",
                Address = "K22CNTT4",
                YearofBirth = 2004,
            };
            ViewBag.customer = customer;
            return View();

        }
        //Get : Ndtlistcustomer
        public ActionResult Ndtlistcustomer()
        {
            var list = new List<NdtCustomer>()
            {
             new NdtCustomer()
            {  CustomerId=1,
               FirstName="Nguyễn Danh",
               LastName="Trường",
               Address="K22CNTT4",
               YearofBirth=2004
              },
             new NdtCustomer()
             {
               CustomerId=2,
               FirstName="Nguyễn ",
               LastName="Trường",
               Address="K22CNTT4",
               YearofBirth=2004
             },
              new NdtCustomer()
             {
               CustomerId=3,
               FirstName="Danh",
               LastName="Trường",
               Address="K22CNTT4",
               YearofBirth=2004
             },
               new NdtCustomer()
             {
               CustomerId=4,
               FirstName="Nguyễn ",
               LastName="Trường 6262",
               Address="K22CNTT4",
               YearofBirth=2004
             },

        };
            ViewBag.list = list; //đưa dữ liệu ra view bằng đối tượng view bag

            return View();
    }
    }
}