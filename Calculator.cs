using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CalculatorWebApp.Models
{
    public class Calculator
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operator { get; set; }
        public int Result { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
