using _8Task;

Console.WriteLine("Enter dog's name");
var name = Console.ReadLine();

var dog = new Dog();
dog.SetName(name);

Console.Write($"{dog.GetName()}");
dog.Eat();