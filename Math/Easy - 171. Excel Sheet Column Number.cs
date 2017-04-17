Related to question Excel Sheet Column Title

Given a column title as appear in an Excel sheet, return its corresponding column number.

For example:

    A -> 1
    B -> 2
    C -> 3
    ...
    Z -> 26
    AA -> 27
    AB -> 28 
	
	
public class Solution 
{
    public int TitleToNumber(string s) 
    {
        int res = 0;
        for(int i = 0; i < s.Length; i++)
        {
            res = 26 * res + (s[i] - 'A' + 1);
        }
        return res;
    }
}


//倒序计算
class Solution {
public:
    int titleToNumber(string s) {
        int col = 0;
        for(int i = s.length(); i > 0; i--) {
            col += (s[i - 1] - 'A' + 1) * pow(26, (s.length() - i));
        }
        return col;
    }
};