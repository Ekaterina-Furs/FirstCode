Console.WriteLine("Enter username");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("This is Masha!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
