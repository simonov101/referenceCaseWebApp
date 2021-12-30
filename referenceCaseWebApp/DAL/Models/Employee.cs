using System;
using System.Collections.Generic;

#nullable disable

namespace referenceCaseWebApp.DAL.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Users = new HashSet<User>();
        }

        public int EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Role { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
