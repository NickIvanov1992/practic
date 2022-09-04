///Given a roman numeral, convert it to an integer.

public class Solution2
{
    public int RomanToInt(string s)
    {
        var numbers = new Dictionary<char, int>
      {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
      };

        int arab = numbers[s[s.Length - 1]];

        for (int i = s.Length - 2; i >= 0; i--)
        {
            if (numbers[s[i]] < numbers[s[i + 1]])
            {
                arab -= numbers[s[i]];
            }
            else
            {
                arab += numbers[s[i]];
            }
        }
        return arab;
    }
}