using System.Linq;

public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        return ((double) arr.Sum() / arr.Length);
    }
}