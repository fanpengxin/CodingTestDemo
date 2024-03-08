using FB.Core.Rules;

namespace FB.Core;

public class FizzBuzz
{
    private List<IRule> rules = new List<IRule>();
    public string ErrorMessage { get; set; } = "";

    public void AddRule(IRule rule)
    {
        rules?.Add(rule);
    }

    public List<string>? Compute(int input)
    {
        List<string> output = new List<string>();
        try
        {
            if (rules.Count == 0)
            {
                ErrorMessage = "Please add rules.";
                throw new Exception(ErrorMessage);
            }
            if (rules.Count > 1)
            {
                var firstRule = rules.OrderBy(a => a.OrderPlace).FirstOrDefault();
                var fbRule = rules.Find(a => a.ReplacedBy == "FizzBuzz");
                if (firstRule != null && fbRule != null)
                {
                    if (firstRule.ReplacedBy != fbRule.ReplacedBy)
                    {
                        ErrorMessage = "FizzBuzzRule PlaceOrder must be the smallest one.";
                        throw new Exception(ErrorMessage);
                    }
                }
            }
            if (input <= 0)
            {
                ErrorMessage = "Error, input value must be greater than 0.";
                throw new Exception(ErrorMessage);
            }

            for (int i = 1; i <= input; i++)
            {
                output.Add(replacedBy(i));
            }
            return output;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return null;
        }
        finally
        {
            output = new List<string>();
        }
    }

    private string replacedBy(int input)
    {
        foreach (var rule in rules!.OrderBy(a => a.OrderPlace))
        {
            if (rule.IsMatch(input))
            {
                return rule.ReplacedBy;
            }
        }
        return input.ToString();
    }
}
