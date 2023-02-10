using Aula3_OOP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_OOP.Accounter
{
    public class UserAccounterBadApproach
    {
        private User _user;

        public UserAccounterBadApproach(User user)
        {
            _user = user;

        }

        public void Validate()
        {
            if (string.IsNullOrEmpty(_user.Name))
                throw new ArgumentNullException("name");
            if (string.IsNullOrEmpty(_user.Email))
                throw new ArgumentNullException("email");
        }

        public void Persist()
        {
            // CODE FOR SAVING THE USER DATA INTO FILE
            File.WriteAllText("user.txt", _user.ToString());
            // Will throw exception if cannot write
        }

        public void NotifyAdmin()
        {
            // CODE FOR SENDING EMAIL TO ADMIN
            Console.WriteLine($"Hey, admin. New user is comming {_user}");
        }


        public void ReceiveUser()
        {
            Validate();
            Persist();
            NotifyAdmin();
        }
    }
}
