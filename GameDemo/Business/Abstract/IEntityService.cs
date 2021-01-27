using GameDemo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Abstract
{
    interface IEntityService
    {
        void Add(IEntity entity);
        void Delete(IEntity entity);
        void Update(IEntity entity);
    }
}
