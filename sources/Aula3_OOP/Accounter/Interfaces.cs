using Aula3_OOP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_OOP.Accounter
{
    public interface IUserValidator
    {
        void Validate(User user);
    }

    public interface IUserRepository
    {
        void Save(User user);
    }

    public interface INotifier
    {
        void Notify(string message);
    }
}
