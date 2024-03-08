using FB.Core.Rules;

namespace BF.Core.Tests;

public class BuzzRuleTests
{
    [Fact]
    public void Should_OrderPlace_IS_2()
    {
        var buzRule = new BuzzRule(2);
        Assert.Equal(2, buzRule.OrderPlace);
    }
    [Fact]
    public void Should_ReplacedBy_IS_Buzz()
    {
        var buzRule = new BuzzRule(2);
        Assert.Equal("Buzz", buzRule.ReplacedBy);
    }
    [Fact]
    public void Should_IsMatch_Return_True()
    {
        var buzRule = new BuzzRule(2);
        for (int i = 1; i < 100; i++)
        {
            if (i % 5 == 0)
            {
                var result = buzRule.IsMatch(i);
                Assert.True(result);
            }
        }
    }
    [Fact]
    public void Should_IsMatch_Return_False()
    {
        var buzRule = new BuzzRule(2);
        for (int i = 1; i < 100; i++)
        {
            if (i % 5 != 0)
            {
                var result = buzRule.IsMatch(i);
                Assert.False(result);
            }
        }
    }
}
