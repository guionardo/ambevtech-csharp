using Aula3_OOP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_OOP.Accounter
{
    public class UserAccounterBestApproach
    {
        private User _user;
        private IUserValidator _validator;
        private IUserRepository _repository;
        private INotifier _notifier;

        public UserAccounterBestApproach(User user, IUserValidator userValidator, IUserRepository userRepository, INotifier notifier)
        {
            _user = user;
            _validator = userValidator;
            _repository = userRepository;
            _notifier = notifier;

        }

        public void ReceiveUser()
        {
            _validator.Validate(_user);
            _repository.Save(_user);
            _notifier.Notify($"Hey, admin. New user is comming {_user}");
        }
    }
}
