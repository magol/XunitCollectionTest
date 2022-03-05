using Xunit;

namespace CollectionTest;

/// <summary>
/// This class is created twice with two different objects of DatabaseFixture. The tests are run separately in these two instances of this test class.
/// </summary>
[Collection(name: "Database collection_1")]
[Collection("Database collection_2")]
public class UnitTest1
{
    private readonly DatabaseFixture _fixture;

    public UnitTest1(DatabaseFixture fixture)
    {
        _fixture = fixture;
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void Test1(int data)
    {
    }
}