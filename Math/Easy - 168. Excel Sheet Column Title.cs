Given a positive integer, return its corresponding column title as appear in an Excel sheet.

For example:

    1 -> A
    2 -> B
    3 -> C
    ...
    26 -> Z
    27 -> AA
    28 -> AB 
	
	
	
public class Solution
{
    public string ConvertToTitle(int n) 
    {
        StringBuilder  sb = new StringBuilder();
        while(n > 0)
        {
            //进制转换一定为0开始
            //26进制为0-25  字母为1-26 所以需要将其减一
            n--;
            sb.Insert(0, (char)(n % 26 + 'A'));
            n = n / 26;
        }
        return sb.ToString();
    }
}	
	

//递归
public class Solution 
{
    public string ConvertToTitle(int n) 
    {
        return n == 0 ? "" : ConvertToTitle((--n) / 26) + (char)(n % 26 + 'A');
    }
}