using MongoDB.Driver;

namespace CalculatorWebApp.Models
{
    public class CalculatorDBContext
    {
        private readonly IMongoDatabase _mongoDatabase;

        public CalculatorDBContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _mongoDatabase = client.GetDatabase("CalculatorDB");
        }

        public IMongoCollection<Calculator> CalculatorRecord
        {
            get
            {
                return _mongoDatabase.GetCollection<Calculator>("CalculatorRecord");
            }
        }
    }
}
