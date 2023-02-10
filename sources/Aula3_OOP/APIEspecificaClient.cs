using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3_OOP
{
    public class APIEspecificaClient : APIGenericClient
    {
        public APIEspecificaClient() : base("http://api_especial.dev")
        {
        }

        public bool EndpointAtivo()
        {
            var response = Request("/");
            return response.StatusCode == 200;
        }
    }
}
