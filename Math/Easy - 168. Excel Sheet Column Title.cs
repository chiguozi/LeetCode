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
            //����ת��һ��Ϊ0��ʼ
            //26����Ϊ0-25  ��ĸΪ1-26 ������Ҫ�����һ
            n--;
            sb.Insert(0, (char)(n % 26 + 'A'));
            n = n / 26;
        }
        return sb.ToString();
    }
}	
	

//�ݹ�
public class Solution 
{
    public string ConvertToTitle(int n) 
    {
        return n == 0 ? "" : ConvertToTitle((--n) / 26) + (char)(n % 26 + 'A');
    }
}