using Newtonsoft.Json;

namespace LoadProject.Entities
{
    public class Group
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("facultyId")]
        public int FacultyId { get; set; }
    }
}
