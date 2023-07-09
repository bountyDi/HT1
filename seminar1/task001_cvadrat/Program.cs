/*
// квадрат числа
int number = 5;
int result = number*number;
Console.WriteLine(result);
*/

// 1. Напишите прогу, кот. на ввод принимает 2 чсила и проверяет, является ли первое число квадратом второго
Console.WriteLine("Введите первое число");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number_2 = Convert.ToInt32(Console.ReadLine());
//== вопрос? равна или нет?
if(number_1 == number_2*number_2)
{
    Console.WriteLine("Первая переменная является квадратом второй");
}
else 
{ 
    Console.WriteLine("Первая переменная не является квадратом второй");  
}

