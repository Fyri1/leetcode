

public class Solution
{
    static void Main(string[] args)
    {

        Console.WriteLine(RomanToInt("III"));

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

            if (i + 1 < S.Length && romanNumbersDictionary[s[i + 1]] > romanNumbersDictionary[currentRomanChar])
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

        /*        foreach (char c in S)
                {
                    int i = 0;

                    if (c == 'I')
                    {
                        nums[i] = 1;
                        i++;
                    }

                    else if(c == 'V')
                    {
                        nums[i] = 5;
                        i++;
                    }*/

        /*            if (c > c + 1)
                    {
                        result = result +c;
                    }
                    else if (c==c+1)
                    {
                        result = result + c;
                    }
                    else if(c < c + 1)
                    {
                        int a = c + 1;
                        int b = c;
                        int g = a - b;

                        result = result + g;


                    }*/






        return result;
    }

    
};

