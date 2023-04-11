Console.Write("Введите 3-х значное число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);
int result = number / 10;
result = result % 10;
Console.Write("Вторая цифра этого числа: ");
Console.WriteLine(result);