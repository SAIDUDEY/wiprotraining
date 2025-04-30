using System;

public class Array{
    
    static void Printarray(int[4] arr){
        
    
    for(int i = 0; i<=arr.Length; i++){
        Console.WriteLine(arr[i]);
    }
    }
    
    static void Main()
    {
    int[] numbers = {10,20,30,40,50};
    Printarray(numbers);
}
}