using GameDemo.Business.Abstract;
using GameDemo.DataAccess.Abstract;
using GameDemo.DataAccess.Validation.Abstract;
using GameDemo.Entity.Abstract;
using GameDemo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Business.Concrete
{
    class UserManager : IEntityService
    {
        List<IValidateService> _validateServices;
        List<ILoggerService> _loggerServices;
        public UserManager(List<ILoggerService> loggerServices, List<IValidateService> validateServices)
        {
            _loggerServices = loggerServices;
            _validateServices = validateServices;
        }

        public void Add(IEntity person)
        {
            foreach (var validator in _validateServices)
            {
                validator.Validate((Person)person);
            }
            foreach (var logger in _loggerServices)
            {
                logger.Add(person);
            }

        }

        public void Delete(IEntity person)
        {
            
            foreach (var logger in _loggerServices)
            {
                logger.Delete(person);
            }

        }

        public void Update(IEntity person)
        {
            
            foreach (var logger in _loggerServices)
            {
                logger.Update(person);
            }

        }
    }
}
