using System;

public class Linearsearch
{
    static int LinearSearch(int[] arr, int target)
    {
        for(int i = 0; i<arr.Length; i++){
            if(arr[i]==target)
                return i;
            }
            return -1;
        }
    
    static void Main(){
        int[] numbers = { 10,20,30,40,50};
        int target = 40;
        int result = LinearSearch(numbers, target);
        
        if(result != -1)
        Console.WriteLine("element found IN " + result);
        
        else
        Console.WriteLine("element not found");
        
    }
}