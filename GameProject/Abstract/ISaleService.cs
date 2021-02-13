using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ISaleService
    {
        void Sale(User user, Sale sale);
    }
}
