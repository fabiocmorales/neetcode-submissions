public class Solution
{
    public bool IsPalindrome(string s)
    {
        var a = 0;
        var b = s.Length - 1;

        while (a < b)
        {
            while (a < b && !char.IsLetterOrDigit(s[a])) a++;
            while (b > a && !char.IsLetterOrDigit(s[b])) b--;

            if (a > b) return false;
            if (char.ToLower(s[a]) != char.ToLower(s[b])) return false;

            a++;
            b--;
        }
        return true;
    }
}