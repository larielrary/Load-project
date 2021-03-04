using Newtonsoft.Json;

namespace LoadProject.Entities
{
    public class Faculty
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
