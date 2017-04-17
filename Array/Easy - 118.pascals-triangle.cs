Given numRows, generate the first numRows of Pascal's triangle.

For example, given numRows = 5,
Return

[
     [1],
    [1,1],
   [1,2,1],
  [1,3,3,1],
 [1,4,6,4,1]
]


public class Solution 
{
	//a[i][j] = a[i-1][j-1] + a[i - 1][j]
    public IList<IList<int>> Generate(int numRows) 
    {
        List<IList<int>> res = new List<IList<int>>();
        if(numRows == 0)
            return res;
        res.Add(new List<int>() {1});
        for(int i = 1; i < numRows; i++)
        {
            int[] row = new int[i + 1];
            row[0] = 1;
            row[i] = 1;
            for(int j = 1; j < i; j++)
            {
                row[j] = res[i - 1][j - 1] + res[i - 1][j];
            }
            res.Add(new List<int>(row));
        }
        return res;
    }
}