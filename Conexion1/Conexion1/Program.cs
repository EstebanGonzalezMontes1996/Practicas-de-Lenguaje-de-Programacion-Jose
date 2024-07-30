using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;


namespace Conexion1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<OUT> list = GithubApi();

            Console.WriteLine(list[0].message, list[1].documentation_url, list[2].status );

        }

        public static List<OUT> GithubApi()
        {
            try
            {
                using (RestClient client = new RestClient("https://api.github.com/users/%3CJonaHdzDev%3E"))
                {
                    RestRequest request = new RestRequest();
                    string respuesta;
                    var response = client.Get(request);
                    respuesta = response.Content;

                    List<OUT> salida = JsonConvert.DeserializeObject<List<OUT>>(respuesta);

                    return salida;
                }
            }
            catch
            {
                List<OUT> salida = new List<OUT>();
                return salida;
            }

        }
    }
}
