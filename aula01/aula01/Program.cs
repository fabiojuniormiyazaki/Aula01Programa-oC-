using System;


namespace aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            Console.WriteLine("digite o valor de A: ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o valor de B: ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o valor de C: ");
            C = Convert.ToDouble(Console.ReadLine()); 

            double delta = FDelta(A, B, C);

            Console.WriteLine($"DELTA :{delta}");
            XBhaskara ResultadoBhaskara = FBhaskara(A, B, delta);
            Console.WriteLine($"BHASKARA: X1: {ResultadoBhaskara.x1} X2: {ResultadoBhaskara.x2}");


            Console.ReadKey();
        }
            

        public static double FDelta(double a,double b,double c)
        {
            double delta = (b * b) - 4 * a * c;
            return delta;
        }
        public static XBhaskara FBhaskara(double a,double b, double Delta)
        {
            XBhaskara Resultado;

            Resultado.x1 = (-b + Math.Sqrt(Delta)) / (2 * a);
            Resultado.x2 = (-b - Math.Sqrt(Delta)) / (2 * a);
            return Resultado;           
        }
    }
    public struct XBhaskara
    {
        public double x1;
        public double x2;
    }
}
