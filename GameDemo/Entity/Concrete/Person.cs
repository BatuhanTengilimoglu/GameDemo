using GameDemo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entity.Concrete
{
    //Person Özellikleri
    class Person : IEntity
    {
        public string Name { get ; set ; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public int YearOfBirth { get; set; }
    }
}
