namespace FB.Core.Rules;

public class BuzzRule : IRule
{
    private readonly int _orderPlace;

    public BuzzRule(int orderPlace)
    {
        _orderPlace = orderPlace;
    }
    public int OrderPlace => _orderPlace;
    public string ReplacedBy { get => "Buzz"; }
    public bool IsMatch(int input)
    {
        return input % 5 == 0;
    }
}
