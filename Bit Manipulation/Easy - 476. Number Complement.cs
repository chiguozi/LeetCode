Given a positive integer, output its complement number. The complement strategy is to flip the bits of its binary representation.

Note:

The given integer is guaranteed to fit within the range of a 32-bit signed integer.
You could assume no leading zero bit in the integer’s binary representation.
Example 1:

Input: 5
Output: 2
Explanation: The binary representation of 5 is 101 (no leading zero bits), and its complement is 010. So you need to output 2.
Example 2:

Input: 1
Output: 0
Explanation: The binary representation of 1 is 1 (no leading zero bits), and its complement is 0. So you need to output 0.

求一个数字的补码，但是数字开头不能有0。

public class Solution
{
    //找到num的1的最高位，与num的补集做交集。
    public int FindComplement(int num)
    {
        int mask = 1;
        while (mask < num) mask = (mask << 1) | 1;
        return ~num & mask;
    }
}


int findComplement(int num) 
{
    int mask = num;
    mask |= mask >> 1;
    mask |= mask >> 2;
    mask |= mask >> 4;
    mask |= mask >> 8;
    mask |= mask >> 16;
    return num ^ mask;
}


for example:
100110, its complement is 011001, the sum is 111111. So we only need get the min number large or equal to num, then do substraction

public int findComplement(int num) 
{
	int i = 0;
	int j = 0;
	
	while (i < num)
	{
		i += Math.pow(2, j);
		j++;
	}
        
        return i - num;
    }