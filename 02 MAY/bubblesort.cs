using System;

public class Bubble
{
    static void BubbleSort(int[] arr){
        
        int n = arr.Length;
        for(int i = 0; i < n-1; i++){
            for( int j = 0; j  < n-1; j++){
                if(arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
            }    
            }
        }
    } 
    
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.WriteLine(num + " ");
            
        }
        Console.WriteLine();
        
        
    }
    
    static void Main()
    {
        int[] numbers = {33, 22, 11, 55, 88,44};
        Console.WriteLine(" origial array");
        PrintArray(numbers);
        
        BubbleSort(numbers);
        Console.WriteLine("sorted array");
        PrintArray(numbers);
    }
    }