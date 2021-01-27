using GameDemo.DataAccess.Validation.Abstract;
using GameDemo.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.DataAccess.Validation.Concrete
{
    class MernisValidateService : IValidateService
    {
        public void Validate(Person person)
        {
            if (person.Name.Length>1 && person.LastName.Length>1 && person.NationalityId.Length==11 && person.YearOfBirth>1800)
            {
                Console.WriteLine(person.Name +" "+ person.LastName +" "+"mernis doğrulamasından geçti.");
            }
            else
            {
                throw new Exception(person.Name + " " + person.LastName + " " + "mernis doğrulamasından geçemedi.");
            }
        }
    }
}
