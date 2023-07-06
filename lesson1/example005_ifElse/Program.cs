Console.Write("enter username");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hooray, this is Masha");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}