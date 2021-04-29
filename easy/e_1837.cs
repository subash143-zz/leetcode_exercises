// https://leetcode.com/problems/sum-of-digits-in-base-k/
// 1837. Sum of Digits in Base K

public class Solution
{
	public int SumBase(int n, int k)
	{
		int res = 0;
		while (n > 0)
		{
			res+=n % k;
			n/=k;
		}
		return res;
		
	}
}