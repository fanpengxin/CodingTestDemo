using FB.Core.Rules;

namespace BF.Core.Tests;

public class FizzBuzzRuleTests
{
    [Fact]
    public void Should_OrderPlace_IS_0()
    {
        var fizzbuzzRule = new FizzBuzzRule(0);
        Assert.Equal(0, fizzbuzzRule.OrderPlace);
    }
    [Fact]
    public void Should_ReplacedBy_IS_FizzBuzz()
    {
        var fizzbuzzRule = new FizzBuzzRule(0);
        Assert.Equal("FizzBuzz", fizzbuzzRule.ReplacedBy);
    }
    [Fact]
    public void Should_IsMatch_Return_True()
    {
        var fizzbuzzRule = new FizzBuzzRule(0);
        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                var result = fizzbuzzRule.IsMatch(i);
                Assert.True(result);
            }
        }
    }
    [Fact]
    public void Should_IsMatch_Return_False()
    {
        var fizzbuzzRule = new FizzBuzzRule(0);
        for (int i = 1; i < 100; i++)
        {
            if (!(i % 3 == 0 && i % 5 == 0))
            {
                var result = fizzbuzzRule.IsMatch(i);
                Assert.False(result);
            }
        }
    }
}

