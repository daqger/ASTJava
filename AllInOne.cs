using System;
public class Program
{
    public class Test {
        public int x = 50;
        public int y = 15;
        public int getArea (int  x , int  y ) 
        {
            return x  * y ;
        
        }
        public void setX (int  a ) 
        {
            x = a ;
        
        }
        public void setY (int  b ) 
        {
            y = b ;
        
        }
    
    }
    public static void Main (string [ ]  args ) 
    {
        Test t = new Test ();
        int RoomArea = t.getArea(t.x,t.y);
        Console.WriteLine("The room area is: " + RoomArea );
        int x = 0;
        int y = 0;
        for (int i = 0; i  < 5; i ++)
        {
            x = x  + 5;
            y = y  + 10;
        }
        t.setX(x);
        t.setY(y);
        int NeededArea = t.getArea(t.x,t.y);
        Console.WriteLine("The area you need is: " + NeededArea );
        if (RoomArea  < NeededArea ){
            Console.WriteLine("The room is too small");
        }
        else if (RoomArea  > NeededArea ){
            Console.WriteLine("That's an upgrade!");
        }
        else {
            Console.WriteLine("Area is acceptable");
        }
        int z;
        int num = 2;
        num+=2;
        switch (num ) {
            case 1: Console.WriteLine("First Output");
            break;
            case 2: Console.WriteLine("Second Output");
            break;
            case 3: Console.WriteLine("Third Output");
            break;
            default: Console.WriteLine("No Num Recieved");
            break;
        }
    
    }
}