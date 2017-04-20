The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

Given two integers x and y, calculate the Hamming distance.

Note:
0 ≤ x, y < 231.

Example:

Input: x = 1, y = 4

Output: 2

Explanation:
1   (0 0 0 1)
4   (0 1 0 0)
       ↑   ↑

The above arrows point to positions where the corresponding bits are different.

汉明距离是指两个数字异或后，其2进制中1的个数。


public class Solution {
    public int HammingDistance(int x, int y) 
    {
        int diff = x ^ y;
        int count = 0;
        while(diff > 0)
        {
            if((diff & 1) == 1)
                count++;
            diff = diff >> 1;
        }
        return count;
    }
}

// n & (n - 1) != 0 表示数字里还有1
class Solution {
public:
    int hammingDistance(int x, int y) {
        int dist = 0, n = x ^ y;
        while (n) {
            ++dist;
            n &= n - 1;
        }
        return dist;
    }
};