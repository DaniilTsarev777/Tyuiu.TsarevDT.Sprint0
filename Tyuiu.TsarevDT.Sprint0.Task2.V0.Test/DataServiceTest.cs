using Tyuiu.TsarevDT.Sprint0.Task2.V0.Lib;
namespace Tyuiu.TsarevDT.Sprint0.Task2.V0.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckGetMessageValid()
    {
        var name = "Danya";
        var res = DataService.GetMessage(name);
        Assert.AreEqual("Привет, Danya", res);
    }
}