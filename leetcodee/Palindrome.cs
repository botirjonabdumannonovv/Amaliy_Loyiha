
namespace leetcodee;

//public class Solution()
//{
//    public bool IsPalindrome(int x)
//    {
//        if(x < 0)
//            return false;
//        string convertToString = x.ToString();

//        char[] chars = convertToString.ToCharArray();
//        Array.Reverse(chars);
//        string reversed = new string(chars);

//        return convertToString.Equals(reversed);
//    }
//}
public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        int original = x;
        int reversed = 0;

        while (x > 0)
        {
            int digit = x % 10;
            reversed = reversed * 10 + digit;
            x = x / 10;
        }
        return original == reversed;
}
