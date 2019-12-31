using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutorial.Data
{
    public interface IRepository
    {
        void AddNewCustomer(Customer customer);
    }
}