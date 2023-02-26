// Программа, которая принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

Task_1();

void Task_1()
{
  int firstNumber = ReadInt("Введите число: ");    
  int exponentNumber = ReadInt("Введите степень числа: ");  

  PrintExponent(firstNumber, exponentNumber);        
}

int ReadInt(string argument)        
{                                    
  Console.Write($"{argument}: ");
  int number;

  while (!int.TryParse(Console.ReadLine(), out number)) 
  {
      Console.WriteLine("Error! Try again.");          
  }

  return number;                                        
}

void PrintExponent(int firstNumber, int exponentNumber)        
{
  int index = 1;
  int exponent = 1;

  while(index <= exponentNumber)
  {
    exponent = firstNumber * exponent;
    index++;
  }
  
  Console.Write(exponent);
}