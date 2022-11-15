using Microsoft.Extensions.Configuration;

namespace Dotnet.Mongo
{
  public static class MongodbConfigExtension
  {
    public static MongodbConfig GetMongodbConfig(this IConfiguration configuration)
    {
      if (configuration == null)
      {
        throw new ArgumentNullException(nameof(configuration));
      }

      return new MongodbConfig{
        ConnectionString=configuration["MongodbConfig:ConnectionString"],
        DatabaseName=configuration["MongodbConfig:DatabaseName"],
        CollectionName=configuration["MongodbConfig:CollectionName"]
      };
    }
  }
}