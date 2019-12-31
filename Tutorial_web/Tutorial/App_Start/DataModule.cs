using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tutorial.Data;

namespace Tutorial.App_Start
{
    public class DataModule:Module
    {
        private string connStr;
        public DataModule(string connString)
        {
            this.connStr = connString;
        }
        protected override void Load(ContainerBuilder builder)
        {
            

            builder.RegisterType<IRepository>().As<Repository>().InstancePerRequest();
            

            base.Load(builder);
        }
    }
}