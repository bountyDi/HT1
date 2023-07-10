Console.WriteLine("enter a number");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
int counter = 0;

while (counter<N)
{   if(counter%2==0)
{   
    Console.Write(counter + " ");
}
    counter++;
}

