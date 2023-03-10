Console.Write("Введите количество элементов массива: ");
int numberEl = Convert.ToInt32(Console.ReadLine()); 

int RandomNum(int numberEl, int min, int max)
  {
  int [] randomNum = new int [numberEl];
  int summa = 0;
    for (int i = 0; i < randomNum.Length; i++ )
    {
      randomNum [i] = new Random().Next(min, max);

      Console.Write(randomNum [i] + " ");

      if (i % 2 != 1)
      {
        summa = summa + randomNum [i];
      }
    }
     return summa;
  }

int randomNum =  RandomNum(numberEl, 1, 40);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечётных позициях: {randomNum}");