public class Solution {
    public bool solution(string s) {
        if(s.Length != 4 && s.Length != 6)
            return false;
        foreach(char component in s)
            if('0' > component || '9' < component)
                return false;
        return true;
    }
}