public class Solution {
    public bool solution(int x) {
        int temp = x;
        int sum = 0;
        int i;
        for(i = 0; temp>=1; i++){
            sum += (temp % 10);
            temp /= 10;
        }
        return (x % sum == 0);
    }
}