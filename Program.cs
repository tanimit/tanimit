using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
     int result=90;

if(result>=80 || result==100){

        Console.WriteLine("A+");
}else if(result>=70){
     Console.WriteLine("A");
}else if(result>=60){
     Console.WriteLine("A-");
}else if(result>=50){
     Console.WriteLine("B");
}
else if(result>=40){
     Console.WriteLine("c");
}else if(result>=33){
     Console.WriteLine("D");
}else{
    Console.WriteLine("you are fail");
}


    }
}