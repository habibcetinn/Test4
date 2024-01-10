using DAL.Models;
using Microsoft.EntityFrameworkCore;
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
            var result = testDbContext.Users.FromSqlRaw("exec GetAllUsers").ToList(); 
            return result;
        }
        public void InsertUser (User user)
        {

            testDbContext.Users.Add(user);
            testDbContext.SaveChanges();
        }
        public void UpdateUser (User user)
        {
             var updateUser = testDbContext.Users.FirstOrDefault(x=>x.Id==user.Id);
            updateUser.Id = user.Id;
            updateUser.UserCode=user.UserCode;
            updateUser.Email=user.Email;
            testDbContext.Update(updateUser);
            testDbContext.SaveChanges();
        }
        public void DeleteUser (User user)
        {
            var deleteUser=testDbContext.Users.FirstOrDefault(x=>x.Id== user.Id);
            testDbContext.Users.Remove(deleteUser);
            testDbContext.SaveChanges();
        }
        public User GetUserById (int id)
        {
            var user = testDbContext.Users.FirstOrDefault(x=> x.Id==id);
            return user;
        }

    }
}
