using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShafiqMVC.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string ImageName { get; set; }
    }

    public class UserContext : DbContext
    {

        public UserContext() : base("Data Source=./SQLSERVER2012;Initial Catalog=UserContext; Integrated Security=SSPI")
        {

        }

        public DbSet<User> Users { get; set; }
    }



    public class UserVM
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public HttpPostedFileBase image { get; set; }
    }
}