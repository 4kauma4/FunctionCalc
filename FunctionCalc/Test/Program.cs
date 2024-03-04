using FunctionCalc;
internal class Program
{
        static void Main(string[] args)
        {
            bool f = true;
            while (f)
            {
                Console.WriteLine("введите N");
                double N = double.Parse(Console.ReadLine());
                Console.WriteLine("введите K");
                double K = double.Parse(Console.ReadLine());
            Console.WriteLine("введите iterations");
            int iterations = int.Parse(Console.ReadLine());
                FunctionCalculator functionCalculator = new FunctionCalculator();
                functionCalculator.Calculate(N, iterations, K);

                Console.WriteLine("Хотите повдорить? (да-1; нет-0)");
                int q = int.Parse(Console.ReadLine());

                if (q==1)
                {
                    f = true;
                }
                else f= false;
            }

        }
}