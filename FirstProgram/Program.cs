// while loop
string name = "";
while (name == "")
{
    name = Console.ReadLine();
    Console.WriteLine(name != "" ? "your name is " + name : "Please enter a valid name:");
}