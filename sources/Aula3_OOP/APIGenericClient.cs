namespace Aula3_OOP
{
    public class APIGenericClient
    {
        private string _baseUrl;

        public class ApiResponse
        {
            public uint StatusCode = 200;
            public string Data = "OK";
        }

        public APIGenericClient(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        protected ApiResponse Request(string path)
        {
            try
            {
                // Código da requisição HTTP
                return new ApiResponse { StatusCode = 200, Data = "Resultado OK" };

            }
            catch (Exception e)
            {
                return new ApiResponse { StatusCode = 500, Data = e.Message };
            }
        }
    }
}
