using GameDemo.DataAccess.Abstract;
using GameDemo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.DataAccess.Concrete.Database
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine(entity.Name + " " + "veritabanına eklendi");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine(entity.Name + " " + "veritabanından silindi");
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine(entity.Name + " " + "veritabanında güncellendi");
        }
    }
}
