using GameDemo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Abstract
{
    interface IPlatformService
    {
        void Buy(IEntity person, IEntity game);
        void Refund(IEntity person, IEntity game);
    }
}
