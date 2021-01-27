using GameDemo.Business.Abstract;
using GameDemo.Entity.Abstract;
using GameDemo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Concrete.Platform
{
    class SteamPlatformManager : IPlatformService
    {
        List<ISaleService> _saleServices;
        public SteamPlatformManager(List<ISaleService> saleServices)
        {
            _saleServices = saleServices;
        }
        public void Buy(IEntity person, IEntity game)
        {
            Console.WriteLine((person as User).NickName + " " + game.Name + " adlı oyunu Steam'den satın aldı.");
        }

        public void Refund(IEntity person, IEntity game)
        {
            Console.WriteLine((person as User).NickName + " " + game.Name + " adlı oyunu Steam'a iade etti.");
        }
    }
}
