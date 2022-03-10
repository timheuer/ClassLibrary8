using ClassLibrary8;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var c = new Class1();
        Assert.AreEqual(3, c.Add(1, 2));
    }

    [TestMethod]
    public void TestMethod2()
    {
        var c = new Class1();
        Assert.IsFalse(c.Add(1, 2) == 8);
    }
}
