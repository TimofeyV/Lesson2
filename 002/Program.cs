Console.Write("Введите число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);
int result = number;
int count = 0;

if (-100 < number && number < 100) Console.WriteLine("B числе нет 3-ей цифры");
else
{
    while(number > 999)
    {
        number /= 10;
    }
    Console.Write("Третья цифра в этом числе: ");
    Console.WriteLine(number % 10);
}
