using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eeliga un ejercicio\n");
            int ej = int.Parse(Console.ReadLine().ToString());
            switch (ej)
            {
                case 1:
                    ejercicio1();
                    break;
                case 2:
                    ejercicio2(ej);
                    break;
                case 3:
                    ejercicio3(ej);
                    break;
                case 4:
                    ejercicio4(ej);
                    break;
                case 5:
                    ejercicio5(ej);
                    break;
                case 6:
                    ejercicio6(ej);
                    break;
                case 7:
                    ejercicio7(ej);
                    break;
                case 8:
                    ejercicio8(ej);
                    break;
                case 9:
                    ejercicio9(ej);
                    break;
                case 10:
                    ejercicio10(ej);
                    break;
                case 11:
                    ejercicio11(ej);
                    break;

                default:
                    break;

            }
            Console.ReadKey();
        }

        private static void ejercicio1()
        {
            Console.Write("Ejercicio 1\n");
            List<int> l = new List<int>();
            l.AddRange(Enumerable.Range(1, 10));
            var s = l.Where(numero => numero % 2 == 0);
            foreach (int nunm in s)
            {
                Console.Write(nunm.ToString() + "\n");
            }

        }
        private static void ejercicio3(int ej)
        {
            Console.Write("Ejercicio {0}\n", ej.ToString());
            List<int> l = new List<int> { 3, 9, 2, 8, 6, 5 };
            var s = l.Select(n => new { pr = n, seg = (n * n) });
            foreach (var nunm in s)
            {
                Console.Write(nunm.pr.ToString() + " " + nunm.seg.ToString() + "\n");
            }

        }

        private static void ejercicio2(int ej)
        {
            Console.Write("Ejercicio {0}\n", ej.ToString());
            List<int> l = new List<int> { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var s = l.Where(numero => numero > 1 && numero < 12);
            foreach (int nunm in s)
            {
                Console.Write(nunm.ToString() + "\n");
            }

        }
        private static void ejercicio4(int ej)
        {
            Console.Write("Ejercicio {0}\n", ej.ToString());
            List<int> l = new List<int> { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var s = l.GroupBy(n => n);
            foreach (var nunm in s)
            {
                Console.Write("El " + nunm.Key.ToString() + " aparece " + nunm.Count() + " veces \n");
            }

        }
        private static void ejercicio5(int ej)
        {
            Console.Write("Ejercicio {0}\n", ej.ToString());
            List<string> l = new List<string> { "ROMA", "LONDRES", "ZARAGOZA", "A CORUÑA", "ZURICH", "BERLIN", "AMSTERDAM", "AMBERES", "PARIS" };
            var s = l.Where(city => city.StartsWith("A") && city.EndsWith("M")).First();
            Console.Write(s.ToString() + "\n");
        }

        private static void ejercicio6(int ej)
        {
            Console.Write("Ejercicio {0}\n", ej.ToString());
            Console.Write("Cantidad de numeros mas altos\n");
            int num = int.Parse(Console.ReadLine().ToString());
            List<int> l = new List<int> { 5, 7, 13, 9, 55, 4, 16 };
            l.Sort();
            l.Reverse();
            Console.Write("Los 3 numeros mas altos son->");
            foreach (int nunm in l.Take(num))
            {
                Console.Write(nunm.ToString() + " ");
            }
        }

        private static void ejercicio7(int ej)
        {

            Console.Write("Ejercicio {0}\n", ej.ToString());
            Console.Write("Introduce una palabra\n");
            string palabra = Console.ReadLine().ToString();
            Console.Write("Introduce una letra a eliminar\n");
            char letra = Char.Parse(Console.ReadLine().ToString());
            var p = palabra.ToList();
            p.Remove(letra);
            foreach (char nunm in p)
            {
                Console.Write(nunm.ToString() + " \n");
            }
            /*Otra solucion
             * 
             * Console.Write("Ejercicio {0}\n", ej.ToString());
            Console.Write("Introduce una palabra\n");
            string palabra = Console.ReadLine().ToString();
            Console.Write("Introduce una letra a eliminar\n");
            char letra = Char.Parse(Console.ReadLine().ToString());
            var p=palabra.Where(n => n!=letra);
            foreach (char nunm in p)
            {
                Console.Write(nunm.ToString() + " \n");
            }*/
            /*OTRA SOLUCION
             * 
             * 
            Console.Write("Ejercicio {0}\n", ej.ToString());
            Console.Write("Introduce una palabra\n");
            string palabra = Console.ReadLine().ToString();
            var l=palabra.ToCharArray();
            Console.Write("Introduce una letra a eliminar\n");
            char[] letra = Console.ReadLine().ToCharArray();
            var nl=l.Except(letra);
            foreach (char nunm in nl)
            {
                Console.Write(nunm.ToString() + " \n");
            }*/

        }

        private static void ejercicio8(int ej)
        {
            Console.Write("Ejercicio {0}\n", ej.ToString());
            List<int> ln = new List<int> { 1, 2, 3 };
            List<char> ll = new List<char> { 'a', 'b', 'c' };
            var sol = from m in ln
                      from l in ll
                      select new { m, l };

            foreach (var nunm in sol)
            {
                Console.Write(nunm.l.ToString() + " " + nunm.m.ToString() + " \n");
            }
        }

        private static void ejercicio9(int ej)
        {
            Console.Write("Ejercicio {0}\n", ej.ToString());
            int[,] mat =    { { 1, 2, 3, 4},
                              { 5, 6, 7, 8},
                              { 9,10,11,12},
                              {13,14,15,16}
            };
            int[,] array = { { 1, 2 }, { 3, 4 } };

            //var sol = from a in array
            //          select a;
        }

        private static void ejercicio10(int ej)
        {
            var daysNames = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();
            foreach (var day in daysNames)
            {
                Console.Write("Dia " + day + "\n");
            }
        }

        private static void ejercicio11(int ej)
        {
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}

        };
            var p1 = customers.Where(n => n.Balance > 1000000.00);
            var sol = p1.GroupBy(n => n.Bank);

            foreach (var s in p1)
            {
                Console.Write(s.Name.ToString() + " " + s.Bank.ToString() + " " + s.Balance.ToString() + "\n");
            }

            foreach (var s in sol)
            {
                Console.Write(s.Key.ToString()+" "+s.Count()+"\n");
            }
        }
            

        internal class Customer
        {
            public string Name { get; internal set; }
            public double Balance { get; internal set; }
            public string Bank { get; internal set; }
        }
    }
    }
        
    

    