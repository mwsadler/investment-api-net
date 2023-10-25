using MongoDb.Models;
using MongoFramework;

namespace MongoDb.MongoDbContext
{
    public class MongoDbContext : MongoFramework.MongoDbContext
    {
        public MongoDbContext(IMongoDbConnection connection) : base(connection)
        {
        }
        public MongoDbSet<User> Books { get; set; }
        
        protected override void OnConfigureMapping(MappingBuilder mappingBuilder)
        {
            // mappingBuilder.Entity<Book>()
            //     .HasProperty(m => m._id, b => b.HasElementName("_id"))
            //     .HasProperty(m => m.price, b => b.HasElementName("price"))
            //     .HasProperty(m => m.time, b => b.HasElementName("time"))
            // .ToCollection("gas-price");
            
            mappingBuilder.Entity<User>()
                .HasProperty(m => m._id, b => b.HasElementName("_id"))
                // .HasProperty(m => m.HistoricalData, b => b.HasElementName("historicalData"))
                .HasProperty(m => m.HistoricalDataMinute, b => b.HasElementName("historicalDataMinute"))
                .HasProperty(m => m.Stocks, b => b.HasElementName("stocks"))
                .HasProperty(m => m.Cash, b => b.HasElementName("cash"))
                .ToCollection("investment-db");
            
            // mappingBuilder.Entity<Cash>()
            //     .
        }
    }
}