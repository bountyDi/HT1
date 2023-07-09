Console.WriteLine("enter first number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second number");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1>number2)
{
    Console.WriteLine(number1);
}
    else if (number2>number1)
{
    Console.WriteLine(number2);
} 
else
{
    Console.WriteLine("numbers equal");
}
