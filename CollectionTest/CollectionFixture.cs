using System;
using Xunit;

namespace CollectionTest;

public class DatabaseFixture : IDisposable
{
    public DatabaseFixture(string connectionString, string someOtherParameter)
    {
        Db = new SqlConnection(connectionString);

        // ... initialize data in the test database ...
    }

    public void Dispose()
    {
        // ... clean up test data from the database ...
    }

    public SqlConnection Db { get; private set; }
}

[CollectionDefinition("Database collection_1", parameters: new[] { "myConnectionString1", "Some other information"})]
public class DatabaseCollection_1 : ICollectionFixture<DatabaseFixture>
{
    // This class has no code, and is never created. Its purpose is simply
    // to be the place to apply [CollectionDefinition] and all the
    // ICollectionFixture<> interfaces.
}

[CollectionDefinitionAttribute("Database collection_2", "myConnectionString2", "...")]
public class DatabaseCollection_2 : ICollectionFixture<DatabaseFixture>
{
    // This class has no code, and is never created. Its purpose is simply
    // to be the place to apply [CollectionDefinition] and all the
    // ICollectionFixture<> interfaces.
}