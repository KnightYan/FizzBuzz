using System;

namespace FizzBuzz
{
    public abstract class NumbersPrinter
    {
        public void Print(int startNumber, int endNumber)
        {
            for(int i=startNumber; i<=endNumber;i++)
            {
                Console.WriteLine(GetPrint(i));
            }
        }

        protected virtual string GetPrint(int i)
        {
            return i.ToString();
        }
    }
}
