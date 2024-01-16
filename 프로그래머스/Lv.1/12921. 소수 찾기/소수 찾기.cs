using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        bool isPrime;
        
        List<bool> prime = new List<bool>{};
        prime.Add(false);
        
        for(int i = 0; i < n; i++){
            prime.Add(true);
        }        
        
        for(int i = 2; i <= n; i++){
            if(prime[i - 1] == false){
                continue;
            }
            
            isPrime = true;
            for(int j = 2; j * j <= i; j++){
                if(i % j == 0){
                    isPrime = false;
                    break;
                }
            }
            prime[i - 1] = isPrime;
            if(isPrime){
                answer++;
                for(int j = 1; j <= (n - n % i)/i; j++){
                    prime[j * i - 1] = false;
                }
            }
        }
        return answer;
    }
}