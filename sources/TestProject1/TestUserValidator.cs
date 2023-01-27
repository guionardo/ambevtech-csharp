using Aula3_OOP.Accounter;
using Aula3_OOP.Domain;
using Castle.Components.DictionaryAdapter.Xml;
using Moq;
using System.ComponentModel.DataAnnotations;

namespace TestProject1
{
    public class TestUserValidator
    {
        [Fact]
        public void ReceiveValidUserShouldNotThrowException()
        {
            var validUser = new User
            {
                Name = "1q234",
                Email = "abcd"
            };
            var validator = new UserValidator();

            validator.Validate(validUser);
        }

        [Fact]
        public void TestAccounter()
        {
            var user = new User { Name = "teste", Email = "aaaa" };
            var validator = new Mock<IUserValidator>();
            var userRepository = new Mock<IUserRepository>();
            userRepository.Setup(r => r.Save(It.IsAny<User>())).Throws(new Exception());

            var notifier = new Mock<INotifier>();
            var accounter = new UserAccounterBestApproach(user, validator.Object, userRepository.Object, notifier.Object);
            Assert.Throws<Exception>(() =>
            {
                accounter.ReceiveUser();
            });
        }
    }
}