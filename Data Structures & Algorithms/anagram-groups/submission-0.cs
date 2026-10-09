public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var anagramGroups = new Dictionary<string, List<string>>();
        foreach (string str in strs)
        {
            var charArray = str.ToCharArray();

            Array.Sort(charArray);
            var sortedStr = new string(charArray);

            if (!anagramGroups.ContainsKey(sortedStr))
            {
                anagramGroups[sortedStr] = new List<string>();
            }

            anagramGroups[sortedStr].Add(str);
        }
        return new List<List<string>>(anagramGroups.Values);
    }
}