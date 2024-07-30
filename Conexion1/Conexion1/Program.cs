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

            Console.WriteLine(list[0].login, list[1].id, list[1].node_id, list[1].avatar_urllist[1].gravatar_idlist[1].urllist[1].html_urllist[1].followers_urllist[1].following_urllist[1].gists_urllist[1].starred_urllist[1].subscriptions_urllist[1].organizations_urllist[1].repos_urllist[1].events_urllist[1].received_events_urllist[1].typelist[1].site_adminlist[1].namelist[1].companylist[1].bloglist[1].locationlist[1].emaillist[1].hireablelist[1].biolist[1].twitter_usernamelist[1].public_reposlist[1].public_gistslist[1].followerslist[1].followinglist[1].created_atlist[1].updated_at );

        }

        public static List<Cuenta> GithubApi()
        {
            try
            {
                using (RestClient client = new RestClient("https://api.github.com/users/EstebanGonzalezMontes1996"))
                {
                    RestRequest request = new RestRequest();
                    string respuesta;
                    var response = client.Get(request);
                    respuesta = response.Content;

                    List<Cuenta> salida = JsonConvert.DeserializeObject<List<Cuenta>>(respuesta);

                    return salida;
                }
            }
            catch
            {
                List<Cuenta> salida = new List<Cuenta>();
                return salida;
            }

        }
    }
}
