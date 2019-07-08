using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAndLambdas
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            #region Linq

            //string sentence = "I love cats";
            //string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            //int[] numbers = { 5, 6, 8, 7, 9, 35, 2, 87, 15, 97, 1, 57, 68, 550, 1250, 354 };

            //var catsWithA = from cat in catNames
            //                where cat.Contains("a") && cat.Length < 5
            //                select cat;
            //Console.WriteLine(string.Join(",", catsWithA));

            //var getTheNumbers = from number in numbers
            //                    where number > 5 && number < 10
            //                    select number;

            //var getTheNumbers = from number in numbers
            //                    where number > 5
            //                    where number < 10
            //                    orderby number
            //                    select number;

            //Console.WriteLine(string.Join(",", getTheNumbers)); // Sorgu çağrıldığı anda çalıştırılır.

            // Lİnq with objects:

            //List<Person> people = new List<Person>()
            //{
            //    new Person("Tod", 180, 70, Gender.Male),
            //    new Person("John", 170, 88, Gender.Male),
            //    new Person("Anna", 150, 48, Gender.Female),
            //    new Person("Kyle", 164, 77, Gender.Male),
            //    new Person("Anna", 164, 77, Gender.Male),
            //    new Person("Maria", 160, 55, Gender.Female),
            //    new Person("John", 160, 55, Gender.Female)
            //};
            //var fourCharPeople = from p in people
            //                     where (p.Name.Length == 4)
            //                     orderby p.Name descending, p.Height
            //                     select p;
            //foreach (var item in fourCharPeople)
            //{
            //    Console.WriteLine($"Name : {item.Name}, Weight : {item.Height}");
            //}

            #endregion

            #region Lambda

            string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            List<int> numbers = new List<int>() { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };
            object[] mix = { 1, "string", 'd', new List<int>() { 1, 2, 3, 4 }, new List<int>() { 5, 2, 3, 4 }, "dd", 's', "Hello Kitty", 1, 2, 3, 4, };
            List<Warrior> warriors = new List<Warrior>()
            {
                new Warrior() { Height = 100 },
                new Warrior() { Height = 80 },
                new Warrior() { Height = 100 },
                new Warrior() { Height = 70 },
            };

            //Linq:
            //var oddNumbers = from n in numbers
            //                 where n % 2 == 1
            //                 select n;
            //Console.WriteLine(string.Join(", ",oddNumbers));

            //Lambda:
            //var oddNumbers = numbers.Where(n => (n % 2 == 1));
            //List<int> oddNumbers = numbers.Where(n => (n % 2 == 1)).ToList();
            //Console.WriteLine(string.Join(", ", oddNumbers));
            //double average = catNames.Average(cat => cat.Length);
            //Console.WriteLine(average);
            //double minCatNameLength = catNames.Min(cat => cat.Length);
            //Console.WriteLine(minCatNameLength);
            //double maxCatNameLength = catNames.Max(cat => cat.Length);
            //Console.WriteLine(maxCatNameLength);
            //double sumCatNameLength = catNames.Sum(cat => cat.Length);
            //Console.WriteLine(sumCatNameLength);

            //var allIntegers = mix.OfType<int>().Where(i=>i<3);
            //Console.WriteLine(string.Join(", ",allIntegers));
            //var allIntList = mix.OfType<List<int>>().ToList();
            //for (int i = 0; i < allIntList.Count; i++)
            //{
            //    Console.WriteLine($"Int Lists[{i}]: "+string.Join(", ",allIntList[i]));
            //}

            //Select vs Where
            //List<int> shortWarriors = warriors.Where(w => w.Height == 100) // warrior nesnesi döner
            //                            .Select(wh => (wh.Height)) // Height özelliği döner
            //                            .ToList();
            //Console.WriteLine(string.Join(", ",warriors));
            //warriors.ForEach(w => Console.WriteLine(w.Height));
            //shortWarriors.ForEach(sw => Console.WriteLine(sw));
            #endregion
        }
        private static int[] StringToIntArray(string array) {
            int[] arrayFromString = array.Split(' ')
                                        .Select(element => int.Parse(element))
                                        .ToArray();
            return arrayFromString;
        }
    }
    internal class Person
    {
        private Gender gender;

        public string Name { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public Gender Gender { get; set; }

        public Person(string name, int height, int weight, Gender gender)
        {
            Name = name;
            Height = height;
            Weight = weight;
            Gender = gender;
        }
    }
    internal enum Gender
    {
        Male,
        Female
    }
    internal class Warrior
    {
        public int Height { get; set; }
    }

}
