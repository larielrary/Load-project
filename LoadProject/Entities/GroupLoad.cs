using Newtonsoft.Json;

namespace LoadProject.Entities
{
    public class GroupLoad
    {
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("unitOfLoadId")]
        public int UnitOfLoadId { get; set; }
    }
}
