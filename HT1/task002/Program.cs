int Max(int number1, int number2, int number3)
{
    int result = number1;
    if(number2>result) result = number2;
    if(number3>result) result = number3;
    return result;
}

Console.WriteLine("enter first number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second number");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter third number");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = Max(number1, number2, number3);
Console.WriteLine(max);

