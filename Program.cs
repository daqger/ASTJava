using System;
public class Program
{
    public static void Main (string [ ]  args ) 
    {
        int [, ] numbers = new int  [3, 3] ;
        int temp = 0;
        for (int x = 0; x  < 3; x ++)
        {
            for (int y = 0; y  < 3; y ++)
            {
                numbers [x , y ] =temp ;
                temp ++;
            }
        }
        string output = "";
        for (int x = 0; x  < 3; x ++)
        {
            for (int y = 0; y  < 3; y ++)
            {
                output = output  + " " + numbers  [x , y ] ;
            }
            output = output  + "\n";
        }
        Console.WriteLine(output );
    
    }
}