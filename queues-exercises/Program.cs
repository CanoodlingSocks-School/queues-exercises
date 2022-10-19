// Queue

// Fungerar som en kö (duh) där man kan köa upp element
// och sedan plocka ut dom i ordningen "först in", "först ut"

using System;

Queue<string> nummer = new Queue<string>();
nummer.Enqueue("ett");
nummer.Enqueue("två");
nummer.Enqueue("tre");
nummer.Enqueue("fyra");
nummer.Enqueue("fem");

// Iteration utan att ändra innehållet i kön
foreach (string number in nummer)
{
    Console.WriteLine(number);
}

Console.WriteLine("\n-----------------\n");

// Plockar ut det första elementet som lades in i kön

Console.WriteLine(nummer.Dequeue());

Queue<int> siffror = new Queue<int>();
siffror.Enqueue(1);
siffror.Enqueue(2);
siffror.Enqueue(3);
siffror.Enqueue(4);
siffror.Enqueue(5);

Console.WriteLine("\n-----------------\n");

// Tjuvkika på vad som finns först i kön utan att ta bort det
Console.WriteLine(siffror.Peek());

// Exercise:
// Skapa en klass Person med Namn och Age
// Skriv kod som tar in input för namn och ålder för 3 personer
// Skriv sen ut i konsollen så att det ser ut såhär:
// person name - person age 

Console.WriteLine("--------------EXERCISE----------------\n");

Queue<Person> queue = new Queue<Person>();
int total = 3;

Console.WriteLine("Lägg till 3 personer\n");

for (int i = 0; i < total; i++)
{
    Console.Write("Skriv in namn: ");
    string name = Console.ReadLine();
    Console.Write("Skriv in ålder: ");
    int age = int.Parse(Console.ReadLine());
    Console.WriteLine("------------------------\n");

    queue.Enqueue(new Person()
    {
        Name = name,
        Age = age
    });
}

for (int i = 0; i < total; i++)
{
    Person p = (Person)queue.Dequeue();
    Console.WriteLine(p.ToString());
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }


    public override string ToString()
    {
        return Name + " - " + Age;
    }
}
