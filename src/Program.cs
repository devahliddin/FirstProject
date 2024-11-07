namespace src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write number :");
            var number = Convert.ToInt32(Console.ReadLine());
            var  ones = number % 10;
            var  tens = number / 10 % 10;
            var  hunderds = number / 100 % 10;
            var  thousands = number / 1000 % 10;
            var result = ones + tens + hunderds + thousands;
            Console.WriteLine(result);

        }
    }
}
