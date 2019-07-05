using System;

namespace Generics
{
    // Generic yapılara bazı sınırlandırmalar getirilebilir
    // where T : IComparable constraint to a interface
    // where T : Product constraint to a class
    // where T : struct T value tip olmalı
    // where T : class T referans tip olmalı
    // where t : new() T constructor olmalı
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        public void DoSomething(T value)
        {
            var obj = new T();
        }
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
