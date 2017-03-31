using MongoDB.Bson.Serialization.Attributes;

namespace AIP.Model
{
    public interface IEntity<TKey>
    {
        [BsonId]
        TKey Id { get; set; }
    }

    public interface IEntity : IEntity<string>
    {

    }
}
