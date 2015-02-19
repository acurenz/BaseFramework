using AcurenzAppFramework.Data;
using AcurenzAppFramework.Service;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcurenzAppFramework.Controllers.Customer
{
    public class CustomerAddressTypeController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IUnitOfWork _unitofwork;

        public CustomerAddressTypeController(ICustomerService customerService, IUnitOfWork unitofwork)
        {
            _customerService = customerService;
            _unitofwork = unitofwork;
        }
        // GET: CustomerAddressType
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAll()
        {
            if (_customerService != null)
            {
                var customerAddressTypes = _customerService.GetAllCustomerAddressTypes().ToList();
                return Json(new { Result = true, data = customerAddressTypes }, JsonRequestBehavior.AllowGet);
            }
            // return View();
            return null;
        }

        [HttpPost]
        public EmptyResult Save(CustomerAddress address)
        {
            if (_customerService != null)
            {
                address.CreatedBy = "aravind";
                address.DateCreated = DateTime.Now;
                address.DateEffective = DateTime.Now;
                address.DateUpdated = DateTime.Now;
                address.IsVerified = true;
                address.DateEnd = null;
                address.Customer = _customerService.GetCustomer(address.CustomerNumber);
                var customerAddress = _customerService.Add(address);
                _unitofwork.Save();
                return new EmptyResult();
            }
            // return View();
            return null;
        }
    }
}