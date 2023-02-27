//Программа, которая задаёт массив из 8 элементов и выводит их на экран.


 void NewArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;

  while(index < length)
  {
    collection[index] = new Random().Next(1, 8);
    index++;
  }
}

void PrintArray(int[] col)
{
  int count = col.Length;
  int position = 0;

  while(position < count)
  {
    Console.Write($"{col[position] + " "}");
    position++;
  }
}

int[] array = new int[8];

NewArray(array);
PrintArray(array);