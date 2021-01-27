using GameDemo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entity.Concrete
{
    //Oyun Özellikleri
    class Game : IEntity
    {
        public int Id { get; set; }
        public string Name { get ; set ; }
        public string Publisher { get; set; }
        public double Price { get; set; }
    }
}
