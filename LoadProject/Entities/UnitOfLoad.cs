using Newtonsoft.Json;

namespace LoadProject.Entities
{
    public class UnitOfLoad
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("loadId")]
        public int LoadId { get; set; }

        [JsonProperty("teacherId")]
        public int TeacherId { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("subjectId")]
        public int SubjectId { get; set; }

        [JsonProperty("term")]
        public int Term { get; set; }

        [JsonProperty("row")]
        public int Row { get; set; }

        [JsonProperty("studentsCount")]
        public int StudentsCount { get; set; }
    }
}
