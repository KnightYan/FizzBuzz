namespace FizzBuzz
{
    public class FizzBuzzPrinter : NumbersPrinter
    {
        protected override string GetPrint(int i)
        {
            var result = i.ToString() + " ";
            var validation = new MultipleValidade();
            if(validation.IsMultiple(i, 3))
                result = result + "Fizz";

            if (validation.IsMultiple(i, 5))
                result = result + "Buzz";

            return result;
        }
    }
}
