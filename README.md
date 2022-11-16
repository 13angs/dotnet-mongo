# Dotnet mongo

## Usage:

- Install the package

```bash
dotnet add package 13angs.Dotnet.Mongo --version 0.0.1
```

- Register the config into DI container

```csharp
MongodbConfig mongodbConfig = Configuration.GetMongodbConfig();
builder.Services.AddSingleton(mongodbConfig);
```

- Use the service

```csharp
IMongoCollection<Blog?> _blog = MongodbCollectionService.GetCollection<Blog?>(Configuration);
```

- update the `appsetting.json`

```json
{
    "MongodbConfig": {
        "ConnectionString": "mongodb://root:P4ssw0rd@mongo-db:27017/",
        "DatabaseName": "blog_db",
        "CollectionName": "blogs"
    }
}
```

- run the Mongodb server

```bash
cd Sample && docker compose up -d
```

- navigate to http://localhost:5255