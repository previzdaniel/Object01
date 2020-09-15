using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object01
{
    class Ember
    {
        public string nev;
        public int eletkor;

        public string Bemutatkozas()
        {
            //string valasz = $"{nev} vagyok {eletkor} éves.";
            //return valasz;

            //return $"{nev} vagyok {eletkor} éves.";

            return nev + " vagyok " + eletkor + " éves.";
        }
    }

    class teglalap
    {
        public int a;
        public int b;

        public int Kerulet()
        {
            return 2 * (a + b);
        }

        public int Terulet()
        {
            return a * b;
        }
    }

    class kor
    {
        public int r;

        public double Kerulet()
        {
            return 2 * r * Math.PI;
        }

        public double Terulet()
        {
            return Math.Pow(r,2) * Math.PI;
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            Ember Pisti = new Ember();
            Ember Eva = new Ember();

            Pisti.nev = "Nagy Pista";
            Pisti.eletkor = 20;

            Eva.nev = "Kis Éva";
            Eva.eletkor = 16;

            Console.WriteLine(Pisti.Bemutatkozas());
            Console.WriteLine(Eva.Bemutatkozas());

            teglalap t = new teglalap();

            Console.Write("A téglalap 'a' oldala: ");
            t.a = Convert.ToInt32(Console.ReadLine());
            Console.Write("A téglalap 'b' oldala: ");
            t.b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Téglalap vagyok, terület: {t.Terulet()}, kerület: {t.Kerulet()}.");

            kor k = new kor();

            Console.Write("A kör kerülete: ");
            k.r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A kör kerülete: {k.Kerulet()}, területe: {k.Terulet()}");
            

            Console.ReadKey();
        }
    }
}
