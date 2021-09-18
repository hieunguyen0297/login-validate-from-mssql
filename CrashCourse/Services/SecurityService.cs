using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrashCourse.Models;

namespace CrashCourse.Services
{
    public class SecurityService
    {       

        UsersDAO usersDAO = new UsersDAO();

        public bool IsValid(UserModel user)
        { 
            
            //return true if found in the list of knownUsers
            return usersDAO.FindUserByNameAndPassword(user);  
        }








        /*
        public SecurityService()
        {
            
            knownUsers.Add(new UserModel() { Id = 0, UserName = "hieu", Password = "hieu" });
            knownUsers.Add(new UserModel() { Id = 1, UserName = "john", Password = "john" });
            knownUsers.Add(new UserModel() { Id = 2, UserName = "lisa", Password = "lisa" });
           


        } 
        */

    }
}
