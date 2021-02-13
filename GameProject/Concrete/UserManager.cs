using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class UserManager:IUserService
    {
        IUserValidationService _userValidationService;
        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(User user)
        {
            if (_userValidationService.Check(user) == true)
            {
                Console.WriteLine("Login is Success, " + user.FirstName + " " + user.LastName);
            }
            else
            {
                Console.WriteLine(user.FirstName + " " + user.LastName + ", Your e-Devlet account has not been verified!");
            }
        }

        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + user.LastName + " your account has been updated !!");
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName + user.LastName + " your account has been deleted !!");
        }
    }
}
