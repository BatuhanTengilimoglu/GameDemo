using GameDemo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.DataAccess.Abstract
{
    //loglarımız için metotlar
    
    interface ILoggerService
    {
        void Add(IEntity entity);
        void Delete(IEntity entity);
        void Update(IEntity entity);
    }
}
