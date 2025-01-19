using TCSA.OOP.LibraryManagementSystem;

// UserInterface.MainMenu();
UserInterface userInterface = new UserInterface();
userInterface.MainMenu();


Animal myDog = new Dog("Buddy", 3);
Animal myCat = new Cat("Whiskers", 2);

myDog.MakeSound(); // Output: Buddy says: Woof!
myCat.MakeSound(); // Output: Whiskers says: Meow!


internal abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    protected Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Abstract method that must be implemented by derived classes
    public abstract void MakeSound();
}
internal class Dog : Animal
{
    public Dog(string name, int age)
        : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}

internal class Cat : Animal
{
    public Cat(string name, int age)
        : base(name, age) // Calling the base class constructor
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}

