using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutorial.Data
{
    public class Repository:IRepository
    {
        workerEntities1 _entities = new workerEntities1();
        public void AddNewCustomer(Customer customer)
        {
           if( !_entities.Database.Exists())
            {
                _entities.Database.CreateIfNotExists();
            }
            _entities.Customers.Add(customer);
            _entities.SaveChanges();
        }
    }
}