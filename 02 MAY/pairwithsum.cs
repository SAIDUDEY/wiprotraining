using System;

class program
{
    static void FindPairWithSum(int[] arr, int target){
        for(int i = 0; i < arr.Length; i++){
            for(int j = i+1; j<arr.Length; j++){
                if(arr[i] + arr[j]  == target){
                    Console.WriteLine(target);
                }
                
            }
        }
    }
    
    static void Main(){
        int[] numbers = {2,4,5,3,7};
        
        int targetsum  = 6;
        
       FindPairWithSum(numbers, targetsum);
    }
}