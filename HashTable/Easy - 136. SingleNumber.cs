Given an array of integers, every element appears twice except for one. Find that single one.

Note:
Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

//原理： 
//1. 相同数字异或结果为0  A ^ A = 0
//2. 异或满足交换律   A ^ B ^ A = A ^ A ^ B = B
public class Solution 
{
    public int SingleNumber(int[] nums) 
    {
        int result = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            result ^= nums[i] ;
        }
        return result;
    }
}


//使用哈希表
public class Solution 
{
    public int SingleNumber(int[] nums) 
    {
        HashSet<int> set = new HashSet<int>();       
        for(int i = 0; i < nums.Length; i++)
        {
            if(set.Contains(nums[i]))
                set.Remove(nums[i]);
            else
                set.Add(nums[i]);
        }
        var iter = set.GetEnumerator();
        iter.MoveNext();
        return iter.Current;
    }
}