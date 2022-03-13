namespace InterviewApp
{
    internal class Question
    {
        public void Main()
        {
            var str = "Welcome to Csharp corner";
            //Console.WriteLine($"{str} is " + (IsPalindrom(str) == true ? "Palindrom" : "Not Palindrom"));
            //Console.WriteLine($"{str}<===>{ReverseWord(str)}");
            int[] array = { 1, 2, 3,4,5,6 };
            var resultArray = OneToTwoArray(array);
        }
        public bool IsPalindrom(string str)
        {
            var reverse = "";
            for (int i = str.Length - 1; i >= 0; i--)
                reverse += str[i];
            Console.WriteLine(str + "<==>" + reverse);
            return str == reverse;
        }
        public string ReverseWord(string str)
        {
            var stringArray = str.Split(" ");
            var reverse = "";
            for (int i = stringArray.Length - 1; i >= 0; i--)
                reverse += stringArray[i] + " ";
            return reverse;
        }
        public int[,] OneToTwoArray(int[] arr) {
            var index = 0;
            int[,] result = new int[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i,j]=arr[index];
                    index++;
                }
            }
            return result;
        }
    }
}
