using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDb.Models;

[Table("investment-db", Schema = "investment-db")]
public class User
{
    [Key]
    [BsonId]
    // [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId _id { get; set; }
    //
    // public double price { get; set; }
    //
    // public DateTime time { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public IEnumerable<HistoricalData>? HistoricalData { get; set; }
    public IEnumerable<HistoricalData>? HistoricalDataMinute { get; set; }
    public IEnumerable<Stock>? Stocks { get; set; }
    public IEnumerable<Cash> Cash { get; set; }
}

public class HistoricalData
{
    public string account { get; set; }
    public double value { get; set; }
    public string date { get; set; }
}

public class Stock
{
    public string account { get; set; }
    public string symbol { get; set; }
    public string currency { get; set; }
    public double count { get; set; }
    public double averageCost { get; set; }
}

public class Cash
{
    public string account { get; set; }
    public string currency { get; set; }
    public double value { get; set; }
}