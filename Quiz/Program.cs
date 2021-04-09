using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Quiz
{
    class Program
    {
        
        
        class QueueWithPriority<T1,T2> where T2 : IComparable
        {
            T1[] arr = new T1[0];
        }
        delegate int Add(int one, int two);
        class Person : IEnumerable
        {
            private readonly int ID;
            private static int count = 0;
            private event Add Event;
            public Person(string name)
            {
                Name = name;
                ID = count;
                ++count;
            }
            public Person()
            {
                Name = "NoName";
            }
            public string Name { get; set; }
            ~Person()
            {
                Console.WriteLine("Deleted Person");
            }

        }
        
        public static void Add_(int one, int two)
        {
            Console.WriteLine($"{one}+{two} = {one+two}");
        }
        static void Main(string[] args)
        {
            
            Add add = new Add((e, e2) => { return e + e2; });
            add += (e, e2) => { return e * e2; };
            Console.WriteLine(add?.Invoke(2, 5)); 
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            object[] arr = new object[2];
            // List, LinkedList, Tuple, Dictionary, SortedList , HashSet, Stack , Queue, ArrayList
            if (arr[0] is Person)
            {
                var tmp = arr[0] as Person;
                // Generic, Non-generic
                // List<int>,
                // ArrayList

            }
            Person vasya = new Person();
            for (int i = 0; i < 10; i++)
            {
                vasya = new Person();
            }

            string str = "new string";
            str = str.Remove(0,4);
            Console.WriteLine(str);
            //// SortedList(container), SortedDictionary (tree)
            //SortedList<int, string> sl = new SortedList<int, string>();
            //sl.Add(34, "Test");
            //foreach (var item in sl)
            //{
            //    sl.Remove(item.Key);
            //    Console.WriteLine($"{item.Key}, {item.Value}");
            //}

        }
    }
}
