using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    class Dog : Animal
    {
        public double age;
        public double weight;
        public string breed;

        public Dog()
            : base()
        {
            age = 0;
            weight = 0;
            breed = "";
        }

        public Dog(string name, double age, double weight, string breed)
            : base(name)
        {
            this.age = age;
            this.weight = weight;
            this.breed = breed;
        }

        public void info()
        {
            Console.WriteLine($"{name}'s information:");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight} lbs");
            Console.WriteLine($"Breed: {breed}");
        }
    }
    class Fox : Animal
    {
        public double age;
        public double weight;
        public string furColor;

        public Fox()
            : base()
        {
            age = 0;
            weight = 0;
            furColor = "";
        }

        public Fox(string name, double age, double weight, string furColor)
            : base(name)
        {
            this.age = age;
            this.weight = weight;
            this.furColor = furColor;
        }

        public void info()
        {
            Console.WriteLine($"{name}'s information:");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight} lbs");
            Console.WriteLine($"Fur Color: {furColor}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();
            Console.WriteLine();

            
            Dog ashley = new Dog();
            ashley.name = "Ashley";
            ashley.age = 3;
            ashley.weight = 30;
            ashley.breed = "American Eskimo";
            ashley.info();
            Console.WriteLine();
            

            Dog max = new Dog("Max", 6, 72, "German Shepherd");
            max.info();
            Console.WriteLine();


            Fox todd = new Fox();
            todd.name = "Todd";
            todd.age= 4;
            todd.weight = 25;
            todd.furColor = "Orange";
            todd.info();

            Console.WriteLine();

            Fox robin = new Fox("Robin", 8, 15, "Grey");
            robin.info();

            Console.ReadLine();
            
        }

    }
}