using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            ///get input
            string input;
            input=Console.ReadLine();

            /////Q1
            // Q1 q1=new Q1();
            // var str1=q1.process1(input);
            // if(str1=="ALLOWED"){
            //     Console.ForegroundColor=ConsoleColor.Green;
            //     System.Console.WriteLine(str1);
            // }
            // else if(str1=="REJECTED"){
            //     Console.ForegroundColor=ConsoleColor.Red;
            //     System.Console.WriteLine(str1);
            // }


            /////Q2
            // Q2 q2=new Q2();
            // var str2=q2.process2(input);
            //  if(str2=="ALLOWED"){
            //     Console.ForegroundColor=ConsoleColor.Green;
            //     System.Console.WriteLine(str2);
            // }
            // else if(str2=="REJECTED"){
            //     Console.ForegroundColor=ConsoleColor.Red;
            //     System.Console.WriteLine(str2);
            // }


            /////Q3
            Q3 q3=new Q3();
            var arr=q3.process1(input);
            foreach(var t in arr){
                System.Console.Write(t+" ");
            }
            Console.ReadKey();
        }
    }
}
