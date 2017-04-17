Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:
Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].

```
public class Solution 
{
	//遍历数组  复杂度O(n^2)
    public int[] TwoSum(int[] nums, int target) 
    {
        int i = 0;
        int j = 0;
        bool needBreak = false;
        for(i = 0; i < nums.Length - 1; i++)
        {
            for(j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    needBreak = true;
                    break;
                }
  
            }
            if(needBreak)
                break;
        }
        return new int[] {i, j};
    }
}
```

```
public class Solution 
{
	//遍历，使用字典缓存，判断差值是否在字典中
	//复杂度 O(n)
    public int[] TwoSum(int[] nums, int target) 
    {
        int[] output = new int[2];
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if(!map.ContainsKey(diff))
            {
                if(!map.ContainsKey(nums[i]))
                    map.Add(nums[i], i);
            }
            else
            {
                output[1] = i;
                output[0] = map[diff];
            }
        }
        
        return output;
    }
}
```


