using GameDemo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Concrete.Platform
{
    interface ISaleService
    {
        void Sale(IEntity game,IEntity platform);
        
    }
}
