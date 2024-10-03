using System;

namespace FizzBuzz;

public class FizzBuz
{
    public void CountTo(int lastNumber)
    {
        //výkonný kod
        for (int aktualniCislo = 1; aktualniCislo <= lastNumber; aktualniCislo++)
        {
            if (aktualniCislo % 3 == 0 && aktualniCislo % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (aktualniCislo % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (aktualniCislo % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(aktualniCislo);
            }
        }

    }

}
