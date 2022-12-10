public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> setN = new HashSet<int>() { 0, 1 };
        while (!setN.Contains(n))
        {
            setN.Add(n);
            n = GetNextHappyNumber(n);
        }

        if (n == 1)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public int GetNextHappyNumber(int n)
    {
        int rep = 0;
        while (n > 0)
        {
            rep += ((n % 10) * (n % 10));
            n = n / 10;
        }
        return rep;
    }
}