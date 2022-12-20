using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionsTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal value = 279.98M;

        var cents = value.ToCents();

        Assert.AreEqual(27998, cents);
    }
}