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
        public ActionResult List()
        {
            var list = new List<Models.Customer>();
           var result = _repository.GetAll();
            foreach (var item in result)
            {
                list.Add(new Models.Customer()
                {
                    Address = item.Address,
                    CustomerId = item.Id.ToString(),
                    Email = item.Email,
                    Name = item.Name,
                    Phone = item.Phone
                });
            }
            return View(list);
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