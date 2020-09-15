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

    class Teglalap
    {
        private int a;
        private int b;

        public Teglalap(int oldalA, int oldalB)
        {
            a = oldalA;
            b = oldalB;
        }
        private int Kerulet()
        {
            return 2 * (a + b);
        }

        private int Terulet()
        {
            return a * b;
        }
    }

    class Kor
    {
        private int r;

        public Kor(int sugar)
        {
            if (sugar < 1)
            {
                r = 1;
            }
            else
            {
                r = sugar;
            }
        }

        public double Kerulet()
        {
            return 2 * r * Math.PI;
        }

        public double Terulet()
        {
            return Math.Pow(r,2) * Math.PI;
        }

        public void AdatokKiirasa()
        {
            Console.WriteLine("Sugár: {0}", r);
            Console.WriteLine("Terület: {0}", Terulet());
            Console.WriteLine("Kerület: {0}", Kerulet());
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

            Console.Write("Adja meg az 'a' oldalt: ");
            int oldalA = int.Parse(Console.ReadLine());
            Console.Write("Adja meg a 'b' oldalt: ");
            int oldalB = int.Parse(Console.ReadLine());
            Teglalap t = new Teglalap(oldalA,oldalB);


            //Console.Write("A téglalap 'a' oldala: ");
            //t.a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("A téglalap 'b' oldala: ");
            //t.b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Téglalap vagyok, terület: {t.Terulet()}, kerület: {t.Kerulet()}.");

            Console.Write("Adja meg a kör sugarát.");
            int sugar = int.Parse(Console.ReadLine());
            Kor k = new Kor(sugar);

            //Console.Write("A kör kerülete: ");
            //k.r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A kör kerülete: {k.Kerulet()}, területe: {k.Terulet()}");
            Console.WriteLine("A kör adatai");
            k.AdatokKiirasa();
            

            Console.ReadKey();
        }
    }
}
