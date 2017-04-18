Given a List of words, return the words that can be typed using letters of alphabet on only one row's of American keyboard like the image below.


American keyboard


Example 1:
Input: ["Hello", "Alaska", "Dad", "Peace"]
Output: ["Alaska", "Dad"]
Note:
You may use one character in the keyboard more than once.
You may assume the input string will only contain letters of alphabet.

//记录每个字母的行索引
public class Solution 
{
    Dictionary<char, int> charPosMap = new Dictionary<char, int>()
    {
        {'q', 1}, {'w', 1}, {'e', 1}, {'r', 1}, {'t', 1}, {'y', 1},{'u', 1}, {'i', 1}, {'o', 1}, {'p', 1},
        {'a', 2}, {'s', 2}, {'d', 2}, {'f', 2}, {'g', 2}, {'h', 2}, {'j', 2}, {'k', 2}, {'l', 2},
        {'z', 3}, {'x', 3}, {'c', 3}, {'v', 3}, {'b', 3}, {'n', 3}, {'m', 3}
    };
    int H2LDiff = 'A' - 'a';
    public string[] FindWords(string[] words) 
    {
        List<string> output = new List<string>();
        
        for(int i = 0; i < words.Length; i++)
        {
            if(CheckWordSameLine(words[i]))
            {
                output.Add(words[i]);
             
            }
        }
        return output.ToArray();
    }
    
    bool CheckWordSameLine(string word)
    {
        if(string.IsNullOrEmpty(word))
            return false;
        int line = GetCharLine(word[0]);
        for(int i = 1; i < word.Length; i++)
        {
            if(GetCharLine(word[i]) != line)
                return false;
        }
        return true;
    }
    
    int GetCharLine(char cha)
    {
        if(charPosMap.ContainsKey(cha))
            return charPosMap[cha];
        return charPosMap[(char)(cha - H2LDiff)];
    }
}


//按照字母表顺序记录每个字母所在的行。
//处理单词时，将字母偏移，与数组位置对应。

class Solution {
public:
	vector<string> findWords(vector<string>& words) {
		int m[] = { 2,3,3,2,1,2,2,2,1,2,2,2,3,3,1,1,1,1,2,1,1,3,1,3,1,3 };
		vector<string> ans;
		for (int i = 0; i < words.size(); i++) {
			if (words[i].size() == 0)
				continue;
			int now = m[upper(words[i][0])];
			bool is = true;
			for (int j = 1; j < words[i].size(); j++) {
				if (m[upper(words[i][j])] != now) {
					is = false;
					break;
				}
			}
			if (is)
				ans.push_back(words[i]);
		}
		return ans;
	}
	int upper(char a) {
		if (a >= 'a'&&a <= 'z')
			return a - 'a';
		return a - 'A';
	}
};