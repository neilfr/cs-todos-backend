using cs_todos_backend.Stuff;

namespace Tests.Stuff;

public class DoStuffTests
{
    [Test]
    public void ShouldReturn9()
    {
        var stuff = new DoStuff();

        var result = stuff.GetX();
        
        Assert.AreEqual(9, result);
    } 
}