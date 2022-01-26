using System;
using cls.pasta;

namespace objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Arus = new Hero("Arus", 23, "Knight");
            wizard wizard = new wizard("wizard", 99, "Devil");

            Console.WriteLine(wizard.attack());
            Console.WriteLine(Arus.attack());
        }
    }
}
