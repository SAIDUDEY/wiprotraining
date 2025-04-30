using System;

public class CountRepeat
{
    public static void Main(string[] args)
    {
        int[] a = {1,2,1,3,2,1};
        
        bool[] flag = new bool[a.Length];
        
        for(int i=0;i<a.Length;i++)
        {
            if(flag[i])
                continue;
            int count=1;
            
            for(int j=i+1;j<a.Length;j++)
            {
                if(a[i]==a[j])
                {
                    count++;
                    flag[j]=true;
                    
                }
            }
            Console.WriteLine("Element "+a[i]+" occures "+count+" times");
        }
    }
}