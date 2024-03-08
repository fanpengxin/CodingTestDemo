using FB.Core.Rules;
using FB.Core;

namespace BF.Core.Tests;

public class FizzBuzzTests
{
    [Fact]
    public void Should_Return_ErrorMessage_If_Rules_Count_Is_0()
    {
        var fizBuz = new FizzBuzz();
        fizBuz.Compute(10);

        Assert.Equal("Please add rules.", fizBuz.ErrorMessage);
    }

    [Fact]
    public void Should_Return_ErrorMessage_If_Input_Value_Not_Greater_Than_0()
    {
        var fizBuz = new FizzBuzz();
        fizBuz.AddRule(new FizzRule(1));
        var result = fizBuz.Compute(-1);

        Assert.Equal("Error, input value must be greater than 0.", fizBuz.ErrorMessage);
    }

    [Fact]
    public void Should_Fizz_Replaced_When_FizzRule_Added_In()
    {
        var fizBuz = new FizzBuzz();
        fizBuz.AddRule(new FizzRule(1));
        var result = fizBuz.Compute(16);

        Assert.Equal("1,2,Fizz,4,5,Fizz,7,8,Fizz,10,11,Fizz,13,14,Fizz,16", string.Join(",", result!));
    }

    [Fact]
    public void Should_Fizz_Buzz_Replaced_When_FizzRule_Buzz_Added_In()
    {
        var fizBuz = new FizzBuzz();
        fizBuz.AddRule(new FizzRule(1));
        fizBuz.AddRule(new BuzzRule(2));
        var result = fizBuz.Compute(16);

        Assert.Equal("1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,Fizz,16", string.Join(",", result!));
    }

    [Fact]
    public void Should_Fizz_Buzz_AND_FizzBuzz_Replaced_When_FizzRule_Buzz_AND_FizzBuzzRule_Added_In()
    {
        var fizBuz = new FizzBuzz();
        fizBuz.AddRule(new FizzRule(1));
        fizBuz.AddRule(new BuzzRule(2));
        fizBuz.AddRule(new FizzBuzzRule(0));
        var result = fizBuz.Compute(16);

        Assert.Equal("1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16", string.Join(",", result!));
    }

    [Fact]
    public void Should_Throw_Exceptoin_If_FizzBuzz_OrderPlace_Not_The_Smallest()
    {
        var fizBuz = new FizzBuzz();
        fizBuz.AddRule(new FizzRule(1));
        fizBuz.AddRule(new BuzzRule(2));
        fizBuz.AddRule(new FizzBuzzRule(3));
        var result = fizBuz.Compute(16);

        Assert.Equal("FizzBuzzRule PlaceOrder must be the smallest one.", fizBuz.ErrorMessage);
    }
}

