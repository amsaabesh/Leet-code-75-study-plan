//1480. Running Sum of 1d Array
public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        var res = 0;
        var list = new List<int>();
        foreach (var n in nums)
        {
            res += n;
            list.Add(res);
        }
        return list.ToArray();
    }
}