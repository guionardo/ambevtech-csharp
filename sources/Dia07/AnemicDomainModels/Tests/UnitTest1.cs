using AnemicDomainModels.Models;

namespace Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("47 22221111", true)]
        [InlineData("99999-2222", true)]
        [InlineData("+55 23 12341234", true)]
        [InlineData("abcd", false)]
        public void TestPhoneNumber(string phoneNumber, bool isValid)
        {
            try
            {
                var phone = new PhoneNumber(phoneNumber);
                if (!isValid)
                {
                    Assert.Fail($"Telefone {phoneNumber} deveria ser inválido");
                }
            }
            catch
            {
                if (isValid)
                {
                    Assert.Fail($"Telefone {phoneNumber} deveria ser válido");
                }
            }
        }

        [Theory]
        [InlineData("96980389904", true)]
        [InlineData("12345678901234", false)]
        [InlineData("00000000000", false)]
        public void TestDocumento(string document, bool isValid)
        {
            try
            {
                var doc = new Document(document);
                if (!isValid)
                {
                    Assert.Fail($"Documento {document} deveria ser inválido");
                }
            }
            catch
            {
                if (isValid)
                {
                    Assert.Fail($"Document {document} deveria ser válido");
                }
            }
        }
    }
}