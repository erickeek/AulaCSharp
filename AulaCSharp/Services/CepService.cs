using AulaCSharp.Models;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace AulaCSharp.Services
{
    public class CepService
    {
        public static Endereco Consultar(string cep)
        {
            using (var client = new WebClient { Encoding = Encoding.UTF8 })
            {
                var jsonData = client.DownloadString($"https://viacep.com.br/ws/{cep}/json/");

                return JsonConvert.DeserializeObject<Endereco>(jsonData);
            }
        }
    }
}