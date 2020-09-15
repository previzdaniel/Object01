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

            Console.ReadKey();
        }
    }
}
