using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionCalc
{
    public class FunctionCalculator
    {
        public void Calculate(double N, int iterations, double k)
        {

            double step = 0.1;

            try
            {
                for (double x = 0; x <= k; x += step)
                {
                    if (Math.Abs(x - N) < double.Epsilon)
                    {
                        throw new ArgumentException("Ошибка! Деление на ноль невозможно! ");
                    }
                    if (k < x)
                    {
                        throw new ArgumentException("Оширбка! Выход за пределы диапазона! ");
                    }

                    double result = 1 / (x - N);
                    Console.WriteLine($"f({x}) = {result}");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Исключение поймано!  \n {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение! \n {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Расчет завершен.");
            }
        }
    }


}