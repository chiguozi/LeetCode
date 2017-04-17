Given an array of size n, find the majority element. The majority element is the element that appears more than ? n/2 ? times.

You may assume that the array is non-empty and the majority element always exist in the array.


//使用 dictionary计数
public class Solution 
{
    public int MajorityElement(int[] nums)
    {
        int res = nums[0];
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
                if(map[nums[i]] >= (nums.Length + 1) / 2)
                {
                    res = nums[i];
                    break;
                }
            }
            else
            {
                map.Add(nums[i], 1);
            }
        }
        return res;
    }
}

// Sorting
public int majorityElement1(int[] nums) 
{
    Arrays.sort(nums);
    return nums[nums.length/2];
}


//因为count >= n/2 所以可以用  否则会有问题  比如{3，3，4，5，6}
// Moore's voting algorithm
public class Solution {
    public int majorityElement(int[] num) {
        int major=num[0], count = 1;
        for(int i=1; i<num.length;i++){
            if(count==0){
                count++;
                major=num[i];
            }else if(major==num[i]){
                count++;
            }else count--;
            
        }
        return major;
    }
}

//000001111
//000001001
//000001001
//000001011
//000001001

//记录每一位的1和0的个数，num > 2 / n 所以个数多的就是第i位的值。
//各个位相与，即majorityElement

public int majorityElement(int[] num) 
{

    int ret = 0;

    for (int i = 0; i < 32; i++) {

        int ones = 0, zeros = 0;

        for (int j = 0; j < num.length; j++) {
            if ((num[j] & (1 << i)) != 0) {
                ++ones;
            }
            else
                ++zeros;
        }

        if (ones > zeros)
            ret |= (1 << i);
    }
    
    return ret;
}
