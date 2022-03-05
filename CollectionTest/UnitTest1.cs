using Xunit;

namespace CollectionTest;

/// <summary>
/// This class is created twice with two different objects of DatabaseFixture. The tests are run separately in these two instances of this test class.
/// The parameters are used as parameters to the constructor of DatabaseFixture
/// </summary>
[Collection(name: "Database collection", parameters: new[] { "myConnectionString1", "Some other information" })]
[Collection("Database collection", "myConnectionString2", "...")]
public class UnitTest1
{
    private readonly DatabaseFixture _fixture;

    public UnitTest1(DatabaseFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void Test1()
    {

    }
}