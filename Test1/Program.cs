Console.Write("Введите число A: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int number2 = int.Parse(Console.ReadLine());


int GetDegree(int number1, int number2)
{
	int result = 1;
  for(int i=1; i <= number2; i++){
    result = result * number1;
  }
    return result;
}

  int number = GetDegree(number1, number2);
  Console.WriteLine("Ответ: " + number);