public class Solution {
    public string solution(int a, int b) {
        int[] monthDays = new int[12]{31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        string[] Day = new string[7]{"THU", "FRI", "SAT", "SUN", "MON", "TUE", "WED"};
        
        int days = 0;
        
        for(int i = 0; i < a - 1; i++)
            days += monthDays[i];
        days += b;
        
        return Day[days % 7];
    }
}