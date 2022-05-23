using System;

namespace Z_1
{

    class A
    {
        public int a;
        public int b;
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Print()
        {
            double x = 1 / (1 + ((a + b) / 2));
            Console.WriteLine(x);
        }
        public void Print2()
        {
            double x = Math.Pow(a - b, 2);
            Console.WriteLine(x);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A (6,2);
            obj.Print();
            obj.Print2();
        }
    }
}
