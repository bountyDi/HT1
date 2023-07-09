// Напишите программу функции возведения числа в квадрат
int Power(int number) //метод/функция Power
{
  int result = number*number;
  return result;
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int result = Power(num);
Console.WriteLine(result);
