Given a non negative integer number num. For every numbers i in the range 0 ≤ i ≤ num calculate the number of 1's in their binary representation and return them as an array.

Example:
For num = 5 you should return [0,1,1,2,1,2].

Follow up:

It is very easy to come up with a solution with run time O(n*sizeof(integer)). But can you do it in linear time O(n) /possibly in a single pass?
Space complexity should be O(n).
Can you do it like a boss? Do it without using any builtin function like __builtin_popcount in c++ or in any other language.


//将数字前几位和最后一位切分。
//数组的1的总个数是前几位数字的1的个数 + 最后一位的1的个数。
public class Solution {
    public int[] CountBits(int num) 
    {
        List<int> ret = new List<int>();
        ret.Add(0);
        for(int i = 1; i <= num; i++)
        {
            int value = ret[i >> 1] + i % 2;
            ret.Add(value);
        }
        return ret.ToArray();
    }
}