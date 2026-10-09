public class Solution
{
    private const string prefix = "<start>";
    private const string sufix = "<end>";

    public string Encode(IList<string> strs)
    {
        var result = "";

        foreach (var str in strs)
        {
            result += prefix + str + sufix;
        }

        return result;
    }

    public List<string> Decode(string s)
    {
        var result = new List<string>();
        var accumulating = "";

        foreach (var str in s)
        {
            accumulating += str;

            if(accumulating.StartsWith(prefix) && accumulating.EndsWith(sufix))
            {
                result.Add(accumulating.Substring(prefix.Length, accumulating.Length - prefix.Length - sufix.Length));
                accumulating = "";
            }
        }

        return result;
    }
}