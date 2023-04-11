Console.Write("Введите цифру, обозначающую день недели: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);
if (number < 0 || number > 7) Console.WriteLine("Вы ввели некоректное число");
else if (number == 6 || number == 7)
{
    Console.WriteLine("Это выходной");
}
else
{
    Console.WriteLine("Это будний день");
}