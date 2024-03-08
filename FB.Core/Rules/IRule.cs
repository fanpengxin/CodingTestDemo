namespace FB.Core.Rules;

public interface IRule
{
    int OrderPlace { get; }
    string ReplacedBy { get; }
    bool IsMatch(int input);
}
