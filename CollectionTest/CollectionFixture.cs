using System;
using Xunit;

namespace CollectionTest
{

    public class DatabaseFixture : IDisposable
    {
        /// <summary>
        /// Is used if no connection string is given
        /// </summary>
        public DatabaseFixture() : this("DefaultConnectionString", "something else")
        {
        }

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

    [CollectionDefinition("Database collection")]
    public class DatabaseCollection : ICollectionFixture<DatabaseFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
