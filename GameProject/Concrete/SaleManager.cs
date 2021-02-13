using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class SaleManager:ISaleService
    {
        public void Sale(User user, Sale sale)
        {
            Console.WriteLine(user.FirstName + user.LastName + ", " + sale.GameName + " bought this game !!!!");
        }
    }
}
