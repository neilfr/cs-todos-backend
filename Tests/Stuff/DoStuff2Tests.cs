using cs_todos_backend.Stuff;
using Xunit;
using Assert = NUnit.Framework.Assert;

namespace Tests;

public class DoStuff2Tests
{
    [Fact]
    public void ShouldReturn9()
    {
        var stuff = new DoStuff();

        var result = stuff.GetX();
        
        Assert.AreEqual(9, result);
    }
}