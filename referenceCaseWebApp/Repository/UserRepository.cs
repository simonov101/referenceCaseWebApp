using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using referenceCaseWebApp.DAL.Models;
    
    
namespace referenceCaseWebApp.Repository
{
    public class UserRepository : IUserRepository
    {
        public User GetUser()
        {
            User user = null;

            using (var db = new Ref_Case_DBContext())
            {
                user = db.Users.FirstOrDefault();
            }

            return user;
        }

        public User GetUserandEmployee()
        {
            User user = null;

            using (var db = new Ref_Case_DBContext())
            {
                user = db.Users
                       .Include(x => x.Employee)
                       .FirstOrDefault();
            }

            return user;
        }
    }
}
