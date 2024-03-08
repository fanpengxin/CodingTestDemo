namespace FB.Core.Rules;

public class FizzRule : IRule
{
    private readonly int _orderPlace;
    public FizzRule(int orderPlace)
    {
        _orderPlace = orderPlace;
    }
    public int OrderPlace => _orderPlace;

    public string ReplacedBy { get => "Fizz"; }

    public bool IsMatch(int input)
    {
        return input % 3 == 0;
    }
}
