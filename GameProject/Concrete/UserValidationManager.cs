using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class UserValidationManager:IUserValidationService
    {
        public bool Check(User user)
        {
            if (user.TcNo == 123456 
                && user.FirstName == "John" 
                && user.LastName == "Brown" 
                && user.BirthYear == 1995)
            {
                return true;
            }else if (user.TcNo == 654321
                      && user.FirstName == "Jason"
                      && user.LastName == "Derulo"
                      && user.BirthYear == 1970)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
