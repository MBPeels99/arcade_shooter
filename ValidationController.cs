using System.Text.RegularExpressions;

public class ValidationController
{
    public bool IsMatch(string input, string pattern)
    {
        Regex regex = new Regex(pattern);
        return regex.IsMatch(input);
    }


}
