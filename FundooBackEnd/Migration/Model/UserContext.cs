using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Migration.Model
{
    public class UserContext : System.Data.Entity.DbContext
    {
        public UserContext() 
            : base("connectionstring")  //// DataBase Name
        {

        }
        public System.Data.Entity.DbSet<Student> student { get; set; }      ////TableName and Student Rows and Columns Created
    }
}
