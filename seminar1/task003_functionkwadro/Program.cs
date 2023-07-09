
int Power(int number) //метод/функция Power
{
  int result = number*number;
  return result;
}

void Task3()
{
    //напишите прогу вычисления квадрата числа
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    int result = Power(num);
    Console.WriteLine(result);
}

void Task4()
{
    //Напишите прогу, кот. принимает на вход число N, а на выходе показывает все целые числа из промжутка -N до N
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    //до тех пор, пока не достигнем введённого числа
    // 0 1 2 3 4 5 ... num
    num = Math.Abs(num);
    int counter = -num;
    while (counter < num)
    {
        Console.Write(counter + " ");
        counter++;
    }
}
Task4();