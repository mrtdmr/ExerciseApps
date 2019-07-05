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

            int a = 5;
            dynamic b = a;
            long l = b;
        }
    }
}
