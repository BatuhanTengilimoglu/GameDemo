﻿using GameDemo.Business.Concrete.Platform;
using GameDemo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Concrete.Sale
{
    class HalloweenSaleManager : ISaleService
    {
        public void Sale(IEntity game,IEntity platform)
        {
            Console.WriteLine(game.Name + platform.Name + " " + "cadılar bayramına özel indirimde");
        }
    }
}
