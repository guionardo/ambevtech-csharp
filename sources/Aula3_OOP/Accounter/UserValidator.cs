using Aula3_OOP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_OOP.Accounter
{
    public class UserValidator : IUserValidator
    {
        public void Validate(User user)
        {
            if (string.IsNullOrEmpty(user.Name))
                throw new ArgumentNullException("name");
            if (string.IsNullOrEmpty(user.Email))
                throw new ArgumentNullException("email");
        }

        public void Nadaver()
        {
            Console.WriteLine("NADA");
        }
    }
}
