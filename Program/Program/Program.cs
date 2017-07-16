using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program:Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word! Wybierz, co chcesz zrobic");
            Console.WriteLine("1: Dodawanie");
            Console.WriteLine("2: Odejmowanie");
            Console.WriteLine("3: Mnozenie");
            Console.WriteLine("4: Dzielenie");
            Console.WriteLine("5: Sprawdzanie, czy liczba jest piersza");
            Console.WriteLine("6: format C:/");

            int Check = int.Parse(Console.ReadLine());

          
            switch (Check)
            {
                case 1:
                    Calculator c1 = new Calculator();
                    c1.Add();
                    break;

                case 2:
                    Calculator c2 = new Calculator();
                    c2.Sub();
                    break;

                case 3:
                    Calculator c3 = new Calculator();
                    c3.Mul();
                    break;

                case 4:
                    Calculator c4 = new Calculator();
                    c4.Div();
                    break;

                case 5:
                    Calculator c5 = new Calculator();
                    c5.IsPrimary();
                    break;

                case 6:
                    Console.WriteLine("Nie tym razem :)");
                    Console.ReadLine();
                    break;
                    
            }
        }
    }

}
