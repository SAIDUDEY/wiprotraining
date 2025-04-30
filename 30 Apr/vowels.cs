using System;

public class Vowels{
    
    static int CountVowels(string input)
    {
        int count = 0;
        string vowels = "aeiouAEIOU";
        
        foreach (char c in input){
            if (vowels.Contains(c))
            count++;
            
        }
        return count;
    }
    
    static void Main()
    {
        string sentence = "hello im seshu";
        Console.WriteLine(CountVowels(sentence));
    }
}