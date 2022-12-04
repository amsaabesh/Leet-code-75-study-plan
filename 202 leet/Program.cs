using System;
public class HappyNumber
{
    public static int happynum(int num)//happy number function
    {
        int rem = 0, sum = 0;   
        while (num > 0){//Calculate the sum of squares of digits 
            rem = num % 10;
            sum = sum + (rem * rem);
            num = num / 10;
        }
        return sum;
    }
    public static void Main(){
        int n = Convert.ToInt16(Console.ReadLine());//input
        int r = n;
        while (r != 1 && r != 4){//codition for happy number function
            r = happynum(r);
        }   
        if (r == 1)//happy ends with 1
            Console.WriteLine("true");  

        else if (r == 4)//unhappy ends with 4
            Console.WriteLine("false");
        Console.ReadLine();
    }
}