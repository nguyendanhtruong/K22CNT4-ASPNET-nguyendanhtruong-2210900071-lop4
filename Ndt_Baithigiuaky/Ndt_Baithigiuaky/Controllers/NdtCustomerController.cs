using Ndt_Baithigiuaky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ndt_Baithigiuaky.Controllers
{
    public class NdtCustomerController : Controller
    {
        private static List<NdtCustomer> ndtCustomers = new List<NdtCustomer>()
             {
            new NdtCustomer() { _2210900071_CusId = "2210900071",
                Ndt_FullName = "Nguyễn Danh Trường", Ndt_Address = "Ninh Bình ",
                Ndt_Email = "truong626215gmail.com", Ndt_Balance = 1000,
                Ndt_Phone = "0797475264"},

            new NdtCustomer() { _2210900071_CusId = "22006",
                Ndt_FullName = "Nguyễn Thị Thủy", Ndt_Address = "Hà Nội",
                Ndt_Email = "kha1567gmail.com", Ndt_Balance = 1000,
                Ndt_Phone = "123456789"},
            new NdtCustomer() { _2210900071_CusId = "221000",
                Ndt_FullName = "Hoàng Đức Dược",
                Ndt_Address = "Hà Nội",
                Ndt_Email = "khoa1682gmail.com",
                Ndt_Balance = 1000,
                Ndt_Phone = "123456789"},
            new NdtCustomer() { _2210900071_CusId = "2210090",
                Ndt_FullName = "Nguyễn Hoàng Anh",
                Ndt_Address = "Hà Nội",
                Ndt_Email = "hai6682gmail.com",
                Ndt_Balance = 1000,
                Ndt_Phone = "123456789"},
            new NdtCustomer() { _2210900071_CusId = "221020",
                Ndt_FullName = "Nguyễn Huy Hoàng",
                Ndt_Address = "Hà Nội",
                Ndt_Email = "now682gmail.com",
                Ndt_Balance = 1000,
                Ndt_Phone = "123456789"}
        };

        // GET: NdtCustomer
        public ActionResult NdtIndex()
        {
            return View(ndtCustomers);
        }
        public ActionResult NdtCreate()
        {
            return View();
        }
        // POST: /Customer/Create
        [HttpPost]
        public ActionResult NdtCreate(NdtCustomer cus)
        {
            ndtCustomers.Add(cus);
            return RedirectToAction("NdtIndex");
        }
        // GET: NdtDetail
        [HttpGet]
        public ActionResult NdtDetail(string id)
        {
            NdtCustomer customer = ndtCustomers.FirstOrDefault(c => c._2210900071_CusId == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
        // GET: NtEdit
        public ActionResult NdtEdit()
        {
            // Logic to fetch data and pass it to the view
            return View();
        }

        // POST: NdtEdit
        [HttpPost]
        public ActionResult NdtEdit(FormCollection collection)
        {
            try
            {

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }



        }
    }
}