using FB.Core;
using FB.Core.Rules;

var fizzBuzz = new FizzBuzz();
fizzBuzz.AddRule(new FizzRule(1));
fizzBuzz.AddRule(new BuzzRule(1));
fizzBuzz.AddRule(new FizzBuzzRule(0));

var results = fizzBuzz.Compute(20);

Console.WriteLine(string.Join(",", results!));
