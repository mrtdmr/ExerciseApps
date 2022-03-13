namespace DelegateApp12032022
{
    public class Delegates
    {
        public delegate bool FilterDelegate(Person p);

        /*Demo 1*/
        public void Demo1()
        {
            List<string> names = new List<string>() { "ahmet", "mehmet", "hatice", "selim" };
            names.ForEach(x => Console.WriteLine(x));
            names.RemoveAll(Filter);
            names.ForEach(x => Console.WriteLine(x));
        }
        bool Filter(string s)
        {
            return s.Contains("i");
        }
        /******************/

        /*Demo 2*/
        public void Demo2()
        {
            Person p1 = new Person { Name = "Murat", Age = 37 };
            Person p2 = new Person { Name = "Ahmet", Age = 12 };
            Person p3 = new Person { Name = "Mehmet", Age = 70 };
            Person p4 = new Person { Name = "Hatice", Age = 17 };
            List<Person> personList = new List<Person>() { p1, p2, p3, p4 };
            DisplayPeople("Kids", personList, IsMinor);
            DisplayPeople("Seniors", personList, IsSenior);
            DisplayPeople("Adults", personList, IsAdult);
        }
        public void DisplayPeople(string title, List<Person> personList, FilterDelegate filter)
        {
            Console.WriteLine(title);
            personList.ForEach(p =>
            {
                if (filter(p))
                {
                    Console.WriteLine("{0} is {1} years old.", p.Name, p.Age);
                }
            });
        }
        public bool IsMinor(Person p) => p.Age < 18;
        public bool IsAdult(Person p) => p.Age >= 18 && p.Age < 65;
        public bool IsSenior(Person p) => p.Age >= 65;
        /*****************************/
    }
}
