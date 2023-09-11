using System;

class Solution
{
    public bool IsPrime(int num)
    {
        if(num <= 1)
            return false;

        for (int i = 2; i < num / 2; i++)
        {
            if(num % i == 0)
                return false;
        }

        return true;
    }

    public int solution(int[] nums)
    {
        int answer = 0;

        for(int i = 0; i < nums.Length - 2; i++)
        {
            for(int j = i + 1; j < nums.Length - 1; j++)
            {
                for(int k = j + 1; k < nums.Length; k++)
                {
                    if(IsPrime(nums[i] + nums[j] + nums[k]))
                        answer++;
                }
            }
        }

        return answer;
    }
}