using System;

namespace Dynamic
{
    class Program
    {
        //static languages: at compile time. C#,Java..
        //dynamic langulages : at run time. Javascript, Ruby, Python
        static void Main(string[] args)
        {
            //dynamic excelObject = "DLR:Dynamic Language Runtime";
            //excelObject.Optimize();//Normalde Optimize diye bir metod yok.

            //dynamic name = "Murat";//Brada string
            //name++; //exception
            //name = 10;//Burada integer
            //name++;//sorun yok
            //Console.WriteLine(name);

            //dynamic a = 10;
            //dynamic b = 5;
            //var c = a+b;

            var name = "murat";
            name = "demir";
            //name = 424;
            dynamic surname = "Murat";
            surname = 1500;
            int[] myArray = { 1, 2, 3 };
            Array.Resize<int>(ref myArray, myArray.Length + 1);
            myArray[3] = 1; 
        }
    }
}
