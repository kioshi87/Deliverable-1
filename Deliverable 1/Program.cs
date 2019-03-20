using System;
using System.Globalization;

namespace Deliverable_1
{
    class Program
    {
        private const string V = "Type in an Amount";
        private const string W = "The total is ";
        private const string X = "The average is ";
        private const string Y = "The lowest is ";
        private const string U = "The highest is ";
        private const string T = "The total in US dollars is ";
        private const string S = "The total in Swedish krona is ";
        private const string R = "The total in Japanese yen is ";
        private const string Q = "The total in Thai baht ";

        static void Main(string[] args)
        {

            Console.WriteLine(V);
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double val = a + b + c;
            double val2 = a + b + c / 3;
            Console.WriteLine(W + val);
            Console.WriteLine(X + val2);
            Console.WriteLine(Y + Math.Min(a, Math.Min(b, c)));
            Console.WriteLine(U + Math.Max(a, Math.Max(b, c)));
            Console.WriteLine(T + val.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(S + val.ToString("C" CultureInfo.GetCultureInfo("sw-SE")));
            Console.WriteLine(R + val.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine(Q + val.ToString("C", CultureInfo.CreateSpecificCulture("th-TH")));

            Console.ReadKey();


        }
    }
}
