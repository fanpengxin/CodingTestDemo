using FB.Core.Rules;

namespace BF.Core.Tests
{
    public class FizzRuleTests
    {
        [Fact]
        public void Should_OrderPlace_IS_1()
        {
            var fizRule = new FizzRule(1);
            Assert.Equal(1, fizRule.OrderPlace);
        }
        [Fact]
        public void Should_ReplacedBy_IS_Fizz()
        {
            var fizRule = new FizzRule(1);
            Assert.Equal("Fizz", fizRule.ReplacedBy);
        }
        [Fact]
        public void Should_IsMatch_Return_True()
        {
            var fizRule = new FizzRule(1);
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    var result = fizRule.IsMatch(i);
                    Assert.True(result);
                }
            }
        }
        [Fact]
        public void Should_IsMatch_Return_False()
        {
            var fizRule = new FizzRule(1);
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 != 0)
                {
                    var result = fizRule.IsMatch(i); 
                    Assert.False(result);
                }
            }
        }
    }
}