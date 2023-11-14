
using System.ComponentModel;
using System.ComponentModel.Design;

double i = 1;
int cap;

List<int> primes = new();

Console.WriteLine("Enter a number and you'll get all the prime numbers up to that number in reverse order.");
cap = Convert.ToInt32(Console.ReadLine());


while(i < cap)
{
    i++;
    double j = (i - 1);

    while (j > 1)
    {     
         if (i / j % 1 == 0)
         {
             break;   
         }
         else
         { 
             j--;
         }
    }

    if (j == 1)
    {
        primes.Add(Convert.ToInt32(i));
    }
}

int placeInList = 1;

primes.Reverse();
Console.WriteLine($"Here are all the prime numbers up to {cap} in reverse order:");
foreach(var p in primes)
{
    Console.WriteLine($"Prime number {placeInList}: {p}");
    placeInList++;
}
