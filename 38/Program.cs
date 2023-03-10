double [] arrayNumbers = new double [50];
  for (int i = 0; i < arrayNumbers.Length; i++ )
  {
    arrayNumbers [i] = new Random().Next(1, 50);
    Console.Write(arrayNumbers [i] + " ");
  }
double maxNum = arrayNumbers [0];
double minNum = arrayNumbers [0];
for (int i = 1; i < arrayNumbers.Length; i++)
  {
    if (maxNum < arrayNumbers [i])
    {
      maxNum = arrayNumbers [i];
    }
        if (minNum > arrayNumbers [i])
    {
      minNum = arrayNumbers [i];
    }
  }

  double diff = maxNum - minNum;
Console.WriteLine();
Console.WriteLine($"разница между между элементами:{diff}");