using System;

namespace L
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Радиус окружности: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите Угол в радианах: ");
            double y = double.Parse(Console.ReadLine());
            double z = 2 * 3.14 * x;
            double b = y / 360;
            Calculate calculate = new Calculate(z, b);
            Console.WriteLine(" Длина дуги  = {0}", calculate.Multiplication());
            
            Console.ReadKey();
        }
    }

    class Calculate
    {
        double number1, number2;

        public Calculate(double x, double y)
        {
            number1 = x;
            number2 = y;
            
        }
        
        public double Multiplication()
        {
            return Math.Floor(number1 * number2);
        }
    }
}
