using GameDemo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.DataAccess.Validation.Abstract
{
    interface IValidateService
    {
        void Validate(Person person);
    }
}
