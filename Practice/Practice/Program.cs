using System;
using System.Security.Cryptography.X509Certificates;

class GFG {
    public static int Sum(){
        int[] numbers = { 5, 8, 3, 4, 2 };
        int sum = 0;
        foreach(int n in numbers)
        {
            sum= sum+n;
        }
        return sum;
    }
    public static int VowelCount(){
        int vowelCount = 0;
        string name = "Write an algorithm to count the number of vowels (a, e, i, o, u) in a given string.";
        foreach(char n in name)
        {
            if (n == 'a' || n == 'e' || n == 'i' || n == 'o' || n == 'u')
            {
                vowelCount++;
            }
        }
        return vowelCount;
    }
    // Main Method
    public static void Main(String[] args)
    {
       
       System.Console.WriteLine(VowelCount());
    }
}