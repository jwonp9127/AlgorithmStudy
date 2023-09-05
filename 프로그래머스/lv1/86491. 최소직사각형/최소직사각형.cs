using System;

public class Solution {
    public int solution(int[,] sizes) {
        int w = 0, h = 0;
        for(int i = 0; i < sizes.GetLength(0); i++){
            int bigger = sizes[i, 0] > sizes[i, 1] ? sizes[i, 0] : sizes[i, 1];
            int smaller = sizes[i, 0] > sizes[i, 1] ? sizes[i, 1] : sizes[i, 0];
            
            if(bigger > w)  w = bigger;
            if(smaller > h) h = smaller;
        }   

        return w*h;
    }
}