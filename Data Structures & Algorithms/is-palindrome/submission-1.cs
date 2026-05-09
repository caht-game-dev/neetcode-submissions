public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        string cleaned = "";

        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                cleaned += char.ToLower(c);
            }
        }

        var max = cleaned.Length - 1;

        for (int i = 0; i < cleaned.Length; i++)
        {
            if (cleaned[i] != cleaned[max - i])
            {
                return false;
            }
        }

        return true;
    }
}