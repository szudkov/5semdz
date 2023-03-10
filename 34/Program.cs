Console.WriteLine($"Определяем количество: ");
int [] numbers = new int [50];

void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ )
  {
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int KolichestvoChet(int [] array)
{
    int kolichestvo = 0;
    for (int i = 0; i<array.Length; i++ )
    {
    if (array[i] % 2 == 1)
    {
      kolichestvo++;
    }
  }
  return kolichestvo;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int kolichestvo = KolichestvoChet(numbers);
Console.WriteLine($"Количество четных чисел: {kolichestvo}");