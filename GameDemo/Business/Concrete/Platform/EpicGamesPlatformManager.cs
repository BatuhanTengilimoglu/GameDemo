using GameDemo.Business.Abstract;
using GameDemo.Entity.Abstract;
using GameDemo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Concrete.Platform
{
    class EpicGamesPlatformManager : IPlatformService
    {
        List<ISaleService> _saleServices;
        public EpicGamesPlatformManager(List<ISaleService> saleServices)
        {
            _saleServices = saleServices;
        }
        public void Buy(IEntity person, IEntity game)
        {
          
           Console.WriteLine((person as User).NickName+" "+game.Name + " adlı oyunu Epic Games'ten satın aldı.");
        }

        public void Refund(IEntity person, IEntity game)
        {
            Console.WriteLine((person as User).NickName+ " " + game.Name + " adlı oyunu Epic Games'e iade etti.");
        }
    }
}
