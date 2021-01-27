using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entity.Concrete
{
    //User özellikleri
    class User : Person
    {
        public string NickName { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }

    }
}
