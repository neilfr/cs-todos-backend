using cs_todos_backend.Stuff;
using Xunit;
using Assert = NUnit.Framework.Assert;

namespace Tests.Stuff;

public class DoStuff2Tests
{
    [Fact]
    public void ShouldReturn9()
    {
        var stuff = new DoStuff();

        var result = stuff.GetX();
        
        Assert.AreEqual(9, result);
    }

    [Xunit.Theory]
    [InlineData(5)]
    [InlineData(2)]
    public void ShouldNotReturnIncorrectAnswers(int value)
    {
        var stuff = new DoStuff();

        var result = stuff.GetX();
        
        Assert.AreNotEqual(value, result);
    }
}