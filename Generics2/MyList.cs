using System;

namespace Generics2
{
    class MyList<T>
    {
        private T[] items;

        public int Count { get; private set; }
        public int Capacity { get; private set; }
        public T this[int index]//this = instance of MyList class.
        {
            get { return items[index]; }
            set { items[index] = value; }
        }
        public MyList()
        {
            items = new T[2];
            Capacity = 2;
            Count = 0;
        }
        public void Add(T item)
        {
            if (Count == Capacity)
            {
                T[] clone = (T[])items.Clone();
                Capacity *= 2;
                items = new T[Capacity];
                Array.Copy(clone, 0, items, 0, clone.Length);
            }
            items[Count] = item;
            Count++;
        }
        public static MyList<T> operator +(MyList<T> list1, MyList<T> list2)
        {
            MyList<T> result = new MyList<T>();
            if (list1.Count != list2.Count)
            {
                throw new InvalidOperationException("Lists are of different sizes.");
            }
            else
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    result.Add((dynamic)list1[i] + (dynamic)list2[i]);
                }
            }
            return result;
        }
        public override string ToString()
        {
            string tempString = String.Empty;
            for (int i = 0; i < Count; i++)
            {
                if (i < Count - 1)
                {
                    tempString += items[i] + ", ";
                }
                else
                {
                    tempString += items[i];
                }
            }
            return tempString;
            //return string.Join(", ", items);
        }
    }
}
