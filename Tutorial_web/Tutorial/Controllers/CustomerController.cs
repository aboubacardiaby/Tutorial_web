using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tutorial.Data;

namespace Tutorial.Controllers
{
    public class CustomerController : Controller
    {
        public CustomerController(IRepository repository)
        {
            _repository = repository;
        }

        public IRepository _repository { get; }

        // GET: Customer
        public ActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Create( Models.Customer cust)
        {
            _repository.AddNewCustomer(new Customer()
            {           
                Address = cust.Address,
                Email = cust.Email,
                Name = cust.Name,
                Phone = cust.Phone,
                Id=2
            });
            return View();
        }
    }
}