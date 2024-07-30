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
            List<Cuenta> list = GithubApi();

            //Verifica que la lista tenga almenos un dato
            if (list.Count > 0)
            {
                //Obtiene el primer valor de la lista
                var cuenta = list[0];

                //Imprime los valores de la lista
                Console.WriteLine($"Login: {cuenta.login}\n, ID: {cuenta.id}\n , Node ID: {cuenta.node_id}, \n Avatar URL: {cuenta.avatar_url}\n, Gravatar ID: {cuenta.gravatar_id}\n, URL: {cuenta.url}\n, HTML URL: {cuenta.html_url}\n, Followers URL: {cuenta.followers_url}\n, Following URL: {cuenta.following_url}\n, Gists URL: {cuenta.gists_url}\n, Starred URL: {cuenta.starred_url}\n, Subscriptions URL: {cuenta.subscriptions_url}\n, Organizations URL: {cuenta.organizations_url}\n, Repos URL: {cuenta.repos_url}\n, Events URL: {cuenta.events_url}\n, Received Events URL: {cuenta.received_events_url}\n, Type: {cuenta.type}\n, Site Admin: {cuenta.site_admin}\n, Name: {cuenta.name}\n, Company: {cuenta.company}\n, Blog: {cuenta.blog}\n, Location: {cuenta.location}\n, Email: {cuenta.email}\n, Hireable: {cuenta.hireable}\n, Bio: {cuenta.bio}\n, Twitter Username: {cuenta.twitter_username}\n, Public Repos: {cuenta.public_repos}\n, Public Gists: {cuenta.public_gists}\n, Followers: {cuenta.followers}\n, Following: {cuenta.following}\n, Created At: {cuenta.created_at}\n, Updated At: {cuenta.updated_at}\n");
            }
            else
            {
                Console.WriteLine("No data retrieved from the API.");
            }
            Console.ReadKey();  
        }


        //Metodo para obtener los datos de la pagina
        public static List<Cuenta> GithubApi()
        {
            try
            {
                using (RestClient client = new RestClient("https://api.github.com/users/EstebanGonzalezMontes1996"))
                {
                    RestRequest request = new RestRequest();
                    var response = client.Get(request);
                    string respuesta = response.Content;

                    Cuenta cuenta = JsonConvert.DeserializeObject<Cuenta>(respuesta);
                    List<Cuenta> salida = new List<Cuenta> { cuenta };

                    return salida;
                }
            }
            catch
            {
                return new List<Cuenta>();
            }
        }
    }
}
