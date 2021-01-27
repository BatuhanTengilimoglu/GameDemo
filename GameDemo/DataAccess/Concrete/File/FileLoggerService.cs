using GameDemo.DataAccess.Abstract;
using GameDemo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.DataAccess.Concrete.File
{
    class FileLoggerService : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine(entity.Name + " " + "dosyaya eklendi.");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine(entity.Name + " " + "dosyadan silindi.");
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine(entity.Name + " " + "dosyada güncellendi.");
        }
    }
}
