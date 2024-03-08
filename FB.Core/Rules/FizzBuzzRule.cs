namespace FB.Core.Rules;

public class FizzBuzzRule : IRule
{
    private readonly int _orderPlace;
    public FizzBuzzRule(int orderPlace)
    {
        _orderPlace = orderPlace;
    }
    public int OrderPlace => _orderPlace;

    public string ReplacedBy { get => "FizzBuzz"; }
    public bool IsMatch(int input)
    {
        return input % 3 == 0 && input % 5 == 0;
    }
}
