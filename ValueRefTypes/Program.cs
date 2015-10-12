using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRefTypes
{
    class Pet
    {
        public string name;
        public string type;
        public int age;

        public Pet() { }
        public Pet(string name, string type, int age)
        {
            this.name = name;
            this.type = type;
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine($"my name is {name}, I'm a {age} year old {type}.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value Type - creating numbers on the stack");
            int myInt = 25;
            int myInt2 = myInt;

            Console.WriteLine("myInt = {0}, myInt2 = {1}", myInt, myInt2);
            Console.WriteLine("myInt2 is assigned to myInt - they are 2 copies of a number");
            myInt = 250;
            Console.WriteLine("myInt got set to the value 250");
            Console.WriteLine("myInt = {0}, myInt2 = {1}", myInt, myInt2);
            Console.WriteLine();

            Pet coral = new Pet("coral", "dog", 7); //create pet coral the dog
            Pet chugar = coral; // create pet chugar - who is a pointer to coral

            coral.Display();
            chugar.Display();

            Pet cody = new Pet(); //create cody, assign him values from other pets
            // since cody has his own memory - changing his data doesn't effect the other
            // pets
            cody.type = coral.type;
            cody.name = "cody";
            cody.age = chugar.age;
            cody.Display(); 

            coral.type = "golden retriever"; // doesn't matter which of the 2 objects, same ref
            chugar.age = 5;
            Console.WriteLine();
            coral.Display();
            chugar.Display();
            chugar.type = "horse"; // now both objects
            Console.WriteLine();
            coral.Display();
            chugar.Display();

            Console.WriteLine();
            cody.type = "island dog";
            cody.Display();
            coral.Display();
            chugar.Display();




            Console.ReadKey();

        }
    }
}
