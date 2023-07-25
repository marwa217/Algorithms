using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("text {0}  and integer = {1}",Level.Low.ToString(), ((int)Level.Low));
            //if (Gender.Female.Equals(Level.Medium))
            //    Console.WriteLine("Matched successful");
            //else
            //    Console.WriteLine("can not compare Enums");

            //Test(1, c: 2);

            //Example obj = new Example();
            //int i = obj.func(10);
            //Console.WriteLine("i = {0}", i);
            //Single j = obj.func(2.5f);
            //Console.WriteLine("j = {0}", j);

            //Console.WriteLine("please enter your number ");
            //string x = Console.ReadLine(); // 101010
            //string y = Console.ReadLine(); // 1010

            //var result = x.Intersect(y);
            //foreach (var dd in result)
            //{
            //    Console.WriteLine(dd);
            //}

            //Console.WriteLine("result = {0}", result.Count());
            
            // a can't see prop foo included in B class
            A a = new A();
            a.print(); // hello from A

            A b = new B();
            b.print(); // // hello from B

            // in case bs = new baseClass Result :: black and we can't cast to derived
            derivedClass bs = new derivedClass();
            Console.WriteLine(bs.hairColor); // black

            baseClass derived = bs ;
            derived.hairColor = "red";

            Console.WriteLine(bs.hairColor); // red
            Console.WriteLine(derived.hairColor);// red

            //List<int> numbers = new List<int> { 5, 5, 5, 2, 2, 4, 4, 4, 1, 1, 1, 6, 6, 1, 1 };
            //int max = GetMaxOfDublicates(numbers);
            //Console.WriteLine(max);


            Console.ReadKey();
        }

        public class Example
        {
            public int func(int k)
            {
                k = k + 10;
                return k;
            }
            public Single func(float k)
            {
                k = k + 3.4f;
                return k;
            }
        }

        public static void Test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }

        /* we can't overloading by return type */

        //public static int Test(int a, int b = 10, int c = 20)
        //{
        //    return a + b + c;

        //}

        public static int GetMaxOfDublicates(List<int> numbers)
        {
           
            var sortednumbers = numbers.OrderBy(y => y);
            var groupedNumbers = sortednumbers.GroupBy(y => y).ToList();
            var sequeneList = new List<List<int>>();
            int max = 0;
            for (int i = 0; i < groupedNumbers.Count() - 1; i++)
            {
                if (groupedNumbers[i + 1].Key - groupedNumbers[i].Key == 1)
                {
                    var items = groupedNumbers[i].Concat(groupedNumbers[i + 1]).ToList();
                    if (items.Count > max)
                        max = items.Count;

                    sequeneList.Add(items);
                }
            }
            return max;
        }
    }

    public class HackerEarth
    {
        string[] hack = new string[3];
        public string this[int h] {
            get
            {
                string h1 = hack[h];
                return h1;
            }
            set
            {
                hack[h] = value;
            }

        }
        public string this[double h]
        {
            get
            {

                return "Hello";
            }
            set
            {
                hack[0] = value;

            }
        }
    }

    public class A
    {
        public string boo;
        public virtual void print()
        {
            Console.WriteLine("Hello from Parent called A");
        }
    }

    public class B: A
    {
        public string foo;
        public override void print()
        {
            Console.WriteLine("Hello from child called B");
        }
    }


    public class baseClass
    {
        public string hairColor { get; set; }

        public baseClass()
        {
            hairColor = "black";
        }
    }

    public class derivedClass : baseClass
    {

    }
    enum Level
    {
        Low,
        Medium,
        High
    };
    enum Gender
    {
        Male,
        Female,
        UnKnown
    };
}
