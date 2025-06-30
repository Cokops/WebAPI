using MongoDB.Bson.Serialization.Attributes;

namespace WebAPI.Core
{
    public class WorkFile
    {
        [BsonId]
        public int? Id { get; set; }
        public string? Name { get; set; }
        public DateTime LastCheck { get; set; }
        public DateTime EndCheck { get; set; }

    }
}
