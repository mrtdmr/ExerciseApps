using System;
using System.Collections;
using System.Collections.Generic;

namespace NullableTypes
{
    class Program
    {
        // value types can not be null
        static void Main(string[] args)
        {
            //DateTime? date = null;
            //Console.WriteLine("GetValueOrDefault:"+date.GetValueOrDefault());
            //Console.WriteLine("HasValue:"+date.HasValue);
            //Console.WriteLine("Value:"+date.Value);//exception
            //DateTime? date = new DateTime(2014, 1, 1);
            //DateTime date2 = date.GetValueOrDefault();
            //DateTime? date3 = date2;
            //DateTime date4 = date3 ?? DateTime.Today; //date3 değeri varsa date4=date3 olur. Yoksa bugün olur. date3!=null?date3.GetValueOrDefault():DateTime.Today ile aynısı
            //Console.WriteLine(date4);

            Tuple<int, string, int> tuple = new Tuple<int, string, int>(2, "Murat", 3);
            var person = Tuple.Create("Murat", "Demir", 34, "05.11.1984", "Denizli");
            Console.WriteLine(person.Item1);
            (int Id, string FirstName, string LastName) person2 = (1,"Murat","Demir");
            Console.WriteLine(person2.FirstName);
        }
    }
    
    class MyList<T>
    {
        void Add(T value) { }
        public T this[int index] { get { throw new NotImplementedException()}; }
    }
}
