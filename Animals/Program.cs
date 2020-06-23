using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{


    public abstract class Animal
    {
        public float Weight { get; set; }

        public string Color { get; set; }

        public Animal(string color, float weight)
        {
            Color = color;
            Weight = weight;
        }

        public abstract string MakeSound();
    }
    public abstract class AnimalWithTail : Animal
    {
        public float TailLength { get; set; }

        public AnimalWithTail(string color, float weight, float tailLength) : base(color, weight)
        {
            TailLength = tailLength;
        }
    }

    public class Cat : AnimalWithTail
    {
        public Cat(string color, float weight, float tailLength) : base(color, weight, tailLength)
        { }

        private string Purr()
        {
            return "purrrrrrrr";
        }

        private string Meow()
        {
            return "Meow";
        }

        public override string MakeSound()
        {
            return Purr() + Meow();
        }

        public override string ToString()
        {
            return $"\nThis is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
        }
    }

    public class Dog : AnimalWithTail
    {
        public Dog(string color, float weight, float tailLength) : base(color, weight, tailLength)
        { }

        public override string MakeSound()
        {
            return "Woof";
        }

        public override string ToString()
        {
            
            return $"\nThis is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter cat color\n");
                string color = Convert.ToString(Console.ReadLine());

                Console.WriteLine("\nEnter cat weight\n");
                float weight = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\nEnter cat tail length\n");
                float tailLength = Convert.ToSingle(Console.ReadLine());

                Cat cat = new Cat(color, weight, tailLength);

                Console.WriteLine(cat.ToString());

                Console.WriteLine(cat.MakeSound());

                Console.WriteLine("\nEnter dog color\n");
                color = Convert.ToString(Console.ReadLine());

                Console.WriteLine("\nEnter dog weight\n");
                weight = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("\nEnter dog tail length\n");
                tailLength = Convert.ToSingle(Console.ReadLine());


                Dog dog = new Dog(color, weight, tailLength);


                Console.WriteLine(dog.ToString());

                Console.WriteLine(dog.MakeSound());
            }
            catch (FormatException)
            {
              Console.WriteLine("Error. You entered not a number");
            }
            Console.ReadKey();
        }
    }
}