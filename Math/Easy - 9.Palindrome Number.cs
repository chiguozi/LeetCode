Determine whether an integer is a palindrome. Do this without extra space.

Some hints:
Could negative integers be palindromes? (ie, -1)

If you are thinking of converting the integer to string, note the restriction of using extra space.

You could also try reversing an integer. However, if you have solved the problem "Reverse Integer", you know that the reversed integer might overflow. How would you handle such case?

There is a more generic way of solving this problem.



public class Solution 
{
    public bool IsPalindrome(int x) 
    {
		//负数和0结尾的数字都不是回文
        if(x < 0 ||(x != 0 &&  x % 10 == 0))
            return false;
        int res = 0;
        while(res < x)
        {
			//将x的末尾加到res的头部
            res = res * 10 + x % 10;
            x /= 10;
        }
		//当res == x(长度为偶数) 或者 res / 10 == x(长度为奇数) 才是回文
        return (res == x) || (res / 10 == x);
    }
}