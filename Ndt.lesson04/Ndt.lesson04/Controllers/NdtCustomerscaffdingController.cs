using Ndt.lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ndt.lesson04.Models;

namespace Ndt.lesson04.Controllers
{
    public class NdtCustomerscaffdingController : Controller
    {
        // GET: NdtCustomerscaffding
        private static List<NdtCustomer> listCustomer = new List<NdtCustomer>()
            {
             new NdtCustomer()
        {
            CustomerId = 1,
               FirstName = "Nguyễn Danh",
               LastName = "Trường",
               Address = "K22CNTT4",
               YearofBirth = 2004
              },
             new NdtCustomer()
        {
            CustomerId = 2,
               FirstName = "Nguyễn ",
               LastName = "Trường",
               Address = "K22CNTT4",
               YearofBirth = 2004
             },
              new NdtCustomer()
        {
            CustomerId = 3,
               FirstName = "Danh",
               LastName = "Trường",
               Address = "K22CNTT4",
               YearofBirth = 2004
             },
               new NdtCustomer()
        {
            CustomerId = 4,
               FirstName = "Nguyễn ",
               LastName = "Trường 6262",
               Address = "K22CNTT4",
               YearofBirth = 2004
             },

        };
        // GET: NdtCustomerscaffding
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult NdtCreate()
        {
            var model = new NdtCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult NdtCreate(NdtCustomer model)
        {
            // thêm mới đối tượng khách hàng vào ds dữ liệ
            listCustomer.Add(model);
            //return view(model)
            //chuyển về trang danh sách 
            return RedirectToAction("Index");
        }
        public ActionResult NdtEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerId==id);
            return View(customer);
        }
    }
}