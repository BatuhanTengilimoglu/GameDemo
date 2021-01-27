using GameDemo.Business.Concrete.Platform;
using GameDemo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Concrete.Sale
{
    class DailySaleManager : ISaleService
    {
        public void Sale(IEntity game,IEntity platform)
        {
            Console.WriteLine(game.Name + platform.Name + " " + "günlük indirimde");
        }
    }
}
