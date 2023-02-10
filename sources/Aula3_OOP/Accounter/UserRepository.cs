using Aula3_OOP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_OOP.Accounter
{
    internal class UserRepository : IUserRepository
    {
        public void Save(User user)
        {
            // CODE FOR SAVING THE USER DATA INTO FILE
            File.WriteAllText("user.txt", user.ToString());
            // Will throw exception if cannot write
        }
    }
}
