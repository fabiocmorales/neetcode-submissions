public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        var dictionary = new Dictionary<char, int>();

        foreach (var c in s)
        {
            dictionary[c] = dictionary.GetValueOrDefault(c, 0) + 1;
        }

        foreach (var c in t)
        {
            if (!dictionary.ContainsKey(c))
            {
                return false;
            }
            dictionary[c]--;
            if (dictionary[c] == 0)
            {
                dictionary.Remove(c);
            }
        }

        return dictionary.Count == 0;
    }
}