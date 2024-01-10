using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserService
    {
        private readonly TestDbContext testDbContext;
        public UserService(TestDbContext testDbContext)
        {
            this.testDbContext = testDbContext;
        }
        public List<User> GetAll()
        {
            return testDbContext.Users.ToList();
        }
    }
}
