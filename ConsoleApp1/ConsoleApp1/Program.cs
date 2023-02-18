

public class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine("Num II : " + RomanToInt("II"));
        Console.WriteLine("Num III : " + RomanToInt("III"));
        Console.WriteLine("Num LVIII : " + RomanToInt("LVIII"));
        Console.WriteLine("Num MCMXCIV : " + RomanToInt("MCMXCIV"));
    }


    /*In a first task with roman figures 
     * I use Dictionary for seving data */
    static int RomanToInt(string S)
    {
        Dictionary<char, int> romanNumbersDictionary = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
        int sum = 0;


        for (int i = 0; i < S.Length; i++)
        {
            char currentRomanChar = S[i];
            romanNumbersDictionary.TryGetValue(currentRomanChar, out int num);
            /*TryGetValue its method for using dictionary */
            /*With the help it I compare an array element and search by key*/

            if (i + 1 < S.Length && romanNumbersDictionary[S[i + 1]] > romanNumbersDictionary[currentRomanChar])
            {
                sum -= num;
            }
            else
            {
                sum += num;
            }
        }
        return sum;





    }



};

   

