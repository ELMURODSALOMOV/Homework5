// 1 - Vazifa
int sum = 0;
int itaration = 1;
while(itaration <= 1000)
{
    if(itaration % 2 != 0)
    {
        sum += itaration;
    }
    itaration++;
}
System.Console.WriteLine("1 dan 1000 gacha bo'lgan toq sonlarning yig'indisi: " + sum);

// 2 - Vazifa
int[] numbers = {4, 5, 6, 11, 77, 44, 33};
int max = numbers[0];
int min = numbers[0];
for(int iteration = 1; iteration < numbers.Length; iteration++)
{
    if(numbers[iteration] > max)
    {
        max = numbers[iteration];
    }
    if(numbers[iteration] < min)
    {
        min = numbers[iteration];
    }
}
System.Console.WriteLine("Eng katta qiymat: " + max);
System.Console.WriteLine("Eng kichik qiymat: " + min);

// 3 - Vazifa
System.Console.Write("Butun sonni kiriting: ");
int x = Convert.ToInt32(Console.ReadLine());
long factorial = CalculateFactorial(x);
System.Console.WriteLine($"{x}! = {factorial}");

static long CalculateFactorial(int n)
{
    if(n == 0)
    {
        return 1;
    }
    long result = 1;
    for(int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}
