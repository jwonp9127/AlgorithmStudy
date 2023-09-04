
public class Solution {
    private static int GCD(int a, int b){
        if(a % b == 0)  return b;
        return GCD(b, a % b);
    }

    private static int LCM(int a, int b){
        return a * b / GCD(a, b);
    }
    
    public int[] solution(int n, int m) {
        return new int[2]{GCD(n, m), LCM(n, m)};
    }
}