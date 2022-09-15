//напишите цикл, который принимает на вход число два числа
// А и В и возводит число А в натуральную степень В
//3,5 -> 243 2,4 -> 16
Console.Write("Ведите число A: ");
int numbersA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите число B: ");
int numbersB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ExposureDegree(numbersA, numbersB));
int ExposureDegree (int numbersA, int numbersB)
{   int result = 1;
    for(int i =1; i <= numbersB; i++)
    {
        result = result*numbersA;
    }
    return result;
}
