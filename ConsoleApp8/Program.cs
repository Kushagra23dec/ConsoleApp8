using System;

namespace ConsoleApp8
{   
    class P
    {
        int age;
        string name;

       public P()
        {
            age = 21;
            name = "Kushagra";
        }

        // it is not required, the real method is ToString()...
        public string toString()
        {
            return age + " " + name;
        }

        override
        public string ToString()
        {
            return age + "  " + name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            P p = new P();

            Console.WriteLine("*****************************************************************");

            Console.WriteLine(p);
        }
    }
}
