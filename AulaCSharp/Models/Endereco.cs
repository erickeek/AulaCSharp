using Newtonsoft.Json;

namespace AulaCSharp.Models
{
    public class Endereco
    {
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("localidade")]
        public string Cidade { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }
    }
}