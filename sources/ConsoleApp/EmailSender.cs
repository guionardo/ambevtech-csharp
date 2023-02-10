using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class EmailSender
    {
        class ConfigSMTP
        {
            string _host;
            int _port;
            string _username;
            string _password;

            ConfigSMTP()
            {

            }
        }

        Action<bool> _onEmailSent;
        Func<string, bool> _funcExample;

        public void Acao(bool sucesso, string mensagem)
        {

        }
        public bool AcaoFunc(string mensagem)
        {
            Console.WriteLine(mensagem);
            return true;
        }

        public EmailSender(Action<bool> onEmailSent)
        {
            _funcExample = AcaoFunc;
            var retorno = _funcExample("TESTE");
            _onEmailSent= onEmailSent;
        }

        ~EmailSender()
        {
        }

        public void Send(string message)
        {
            Console.WriteLine("Sending ", message);
            Task.Run(() =>
            {
                Thread.Sleep(5000);
                _onEmailSent(true);
            });
        }
        

    }

    
}
