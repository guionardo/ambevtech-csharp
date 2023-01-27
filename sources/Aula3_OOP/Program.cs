
using Aula3_OOP;
using Aula3_OOP.Accounter;
using Aula3_OOP.Domain;
using System.ComponentModel.DataAnnotations;


//var api = new APIEspecificaClient();
//Console.WriteLine(api.EndpointAtivo());

var user = new User
{
    Name = "Guionardo",
};

IUserValidator validator = new UserValidator();
INotifier notifier = new Notifier();
IUserRepository repository = new UserRepository();

var accounter = new UserAccounterBestApproach(user, validator, repository, notifier);

accounter.ReceiveUser();



