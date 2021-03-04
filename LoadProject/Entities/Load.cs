using Newtonsoft.Json;

namespace LoadProject.Entities
{
    public class Load
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
