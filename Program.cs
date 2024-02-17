
class Program{

public class Pet
{
    public string Name { get; }
    public string Owner { get; set; }
    public int Age { get; }
    public string Description { get; }
    private bool IsHouseTrained { get; set; }

    public Pet(string name, int age, string description)
    {
        Name = name;
        Age = age;
        Description = description;
        Owner = "no one";
        IsHouseTrained = false;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Description: {Description}, Owner: {Owner}, Is House Trained: {IsHouseTrained}";
    }

    public void SetOwner(string newOwner)
    {
        Owner = newOwner;
    }

    public void Train()
    {
        IsHouseTrained = true;
    }
}

static void Main(string[] args)
{
    
    Pet pet1 = new Pet("Peter", 2, "Dog");
    Pet pet2 = new Pet("Ashley", 3, "Cat");
    Pet pet3 = new Pet("Sophie", 4, "Hamster");
    Pet pet4 = new Pet("Jack", 5, "Rabbit");

    List<Pet> pets = new List<Pet> { pet1, pet2, pet3, pet4 };

    pet1.Train();
    pet2.SetOwner("John");

    foreach (Pet pet in pets)
    {
        Console.WriteLine(pet);
    }

    Console.WriteLine("Enter the name of the owner: ");
    var Owner = Console.ReadLine();
    foreach (Pet pet in pets)
    {
        if (pet.Owner == Owner)
        {
            Console.WriteLine(pet);
            Console.WriteLine($"{pet.Name} is {Owner}'s pet.");
        }
    }


}
}