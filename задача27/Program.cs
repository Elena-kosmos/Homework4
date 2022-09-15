// написать программу, которая принимает на вход число
// и выдает сумму цифр в числе
//425 -> 11
Console.Write("Ведите число: ");
int number= Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigit(number));
int SumDigit(int num)
{   int sum =0;
    while(num>0)
{
    sum += num%10;
    num = num/10;
    

}
return sum;
}

