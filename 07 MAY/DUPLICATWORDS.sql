using System;

class Program
{
    public static void Main(string[] args)

    {

        string str = Console.ReadLine();

        string[] s = str.Split(" ");

        bool[] b = new bool[s.Length];

        Method(s, b);
    }

        public static void Method(string[] s, bool[] b)
        {
        for (int i = 0; i < s.Length; i++)
        {
            if (b[i] == false)
            {
              for(int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        b[j] = true;
                    }
                }
            }
        }
        for(int k = 0; k < b.Length; k++)
        {
            if (b[k] == true) {

                Console.WriteLine(s[k]);
            }
        }
       }
    
      
    }
