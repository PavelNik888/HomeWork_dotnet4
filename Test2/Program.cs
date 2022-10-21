Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN){
    
    int counter = Convert.ToString(numberN).Length;
    int temp = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      temp = numberN - numberN % 10;
      result = result + (numberN - temp);
      numberN = numberN / 10;
    }
   return result;
  }
  int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);