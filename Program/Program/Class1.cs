using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Calculator:ICalculator
    {
        public void Add()
        {
            double w = 0;
            int x = 0, y = 0;
            string Temp;

            Console.Write("Podaj pierwsza liczbe: ");
            try
            {
                Temp = Console.ReadLine();
                x = Convert.ToInt32(Temp);
            }
            catch (Exception)
            {
                Console.WriteLine("DESPACITO! Ciepaj ino liczbe");
            }
            

            Console.Write("Podaj druga liczbe: ");

            try
            {
                Temp = Console.ReadLine();
                y = Convert.ToInt32(Temp);
            }
            catch (Exception)
            {
                Console.WriteLine("DESPACITO! Ciepaj ino liczbe");
            }
           
            w = x + y;

            Console.WriteLine("Wynik: {0}", w);
            Console.ReadLine();
        }

        public void Sub()
        {
            double w = 0;
            int x = 0, y = 0;
            string Temp;

            Console.Write("Podaj pierwsza liczbe: ");
            try
            {
                Temp = Console.ReadLine();
                x = Convert.ToInt32(Temp);
            }
            catch (Exception)
            {
                Console.WriteLine("DESPACITO! Ciepaj ino liczbe");
            }


            Console.Write("Podaj druga liczbe: ");

            try
            {
                Temp = Console.ReadLine();
                y = Convert.ToInt32(Temp);
            }
            catch (Exception)
            {
                Console.WriteLine("DESPACITO! Ciepaj ino liczbe");
            }

            w = x - y;

            Console.WriteLine("Wynik: {0}", w);
            Console.ReadLine();
        }

        public void Mul()
        {
            double w = 0;
            int x = 0, y = 0;
            string Temp;

            Console.Write("Podaj pierwsza liczbe: ");
            try
            {
                Temp = Console.ReadLine();
                x = Convert.ToInt32(Temp);
            }
            catch (Exception)
            {
                Console.WriteLine("DESPACITO! Ciepaj ino liczbe");
            }


            Console.Write("Podaj druga liczbe: ");

            try
            {
                Temp = Console.ReadLine();
                y = Convert.ToInt32(Temp);
            }
            catch (Exception)
            {
                Console.WriteLine("DESPACITO! Ciepaj ino liczbe");
            }

            w = x * y;

            Console.WriteLine("Wynik: {0}", w);
            Console.ReadLine();
        }

        public void Div()
        {
            double w = 0;
            int x = 0, y = 0;
            string Temp;

            Console.Write("Podaj pierwsza liczbe: ");
            try
            {
                Temp = Console.ReadLine();
                x = Convert.ToInt32(Temp);
            }
            catch (Exception)
            {
                Console.WriteLine("DESPACITO! Ciepaj ino liczbe");
            }


            Console.Write("Podaj druga liczbe: ");

            try
            {
                Temp = Console.ReadLine();
                y = Convert.ToInt32(Temp);
            }
            catch (Exception)
            {
                Console.WriteLine("DESPACITO! Ciepaj ino liczbe");
            }

            try
            {
                w = x / y;
            }
            catch (Exception)
            {
                Console.WriteLine("Serio Janusz? Dzielic przez 0?");
                Console.ReadLine();
            }
            
            Console.WriteLine("Wynik: {0}", w);
            Console.ReadLine();
        }

        public void IsPrimary()
        {
            string Temp;
            int x = 0;
            Console.WriteLine("Sprawdz, czy podana liczba jest liczba pierwsza!");
            Console.Write("Podaj liczbe: ");
            
            try
            {
                Temp = Console.ReadLine();
                x = Convert.ToInt32(Temp);
            }
            catch (Exception)
            {
                Console.WriteLine("Wprowadzono bledna wartosc");
            }

            if (x<2) Console.WriteLine("Liczba nie jest pierwsza");
                else
                {
                for (int i = 2; i*i < x; i++)
                {
                    if (x % i == 0) Console.WriteLine("Liczba nie jest pierwsza");
                    else Console.WriteLine("Liczba jest liczba pierwsza!");
                }
                }
            Console.ReadLine();
        }
    }
}
