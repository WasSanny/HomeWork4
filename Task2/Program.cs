// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine(CalculateSumToN(ReadInt("Введите число")));

int ReadInt(string argument)  // функция проверяет ввели ли мы целое число до тех пор,
{                              // пока мы не введем целове число
  Console.Write($"{argument}: ");
  int number;

  while(!int.TryParse(Console.ReadLine(), out number))
  {
    Console.WriteLine("Вы ввели не число!");
  }

  return number;
}

int CalculateSumToN(int number)
{
  int sum = 0;

  for(int i = 1; i <= number; i++)
  {
    sum = sum + i;
  }

  return sum;
}
