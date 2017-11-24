using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    class Program
    {
        public int globalnaPremenna = 7;

        void TestGlobalnejPremennej()
        {
            int lokalnaPremenna = 9;
            globalnaPremenna++;
        }

        static void Main(string[] args)
        {
            const int mojaKonstanta=4;
            int polomer = 6;
            //polomer += 1; // da sa aj napr += 8
            //polomer++;  // najskor vyhodnoti polomer a potom +1
            /*++polomer; */ // najskor zvysi o 1 a potom vyhodnoti polomer

            


            Console.WriteLine("Povodny polomer {0}",polomer);
            int novyPolomer = polomer++;
            Console.WriteLine("Novy polomer ++ {0}", novyPolomer); //najskor chyti polomer,vypise a potom priradi +1
            int zasNovyPolomer = ++polomer;
            Console.WriteLine("++ Zasa novy polomer {0}", zasNovyPolomer);

            //Pouzitie Kalkulatora

            Kalkulator.Scitaj(b:"4",a: "5");
            Kalkulator.Scitaj(4);
            int vysledok = Kalkulator.Vynasob(4, 6, 8, 10, 15);

            if (vysledok == 4) vysledok++;
            else
                --vysledok;

            if (vysledok == 4 )
            {
                vysledok++;
                Kalkulator.Vynasob(4, 6, 8, 10, 15);
            }
            else if (vysledok == 5)
            {
                vysledok--;
                Kalkulator.Vynasob(4, 6, 8, 10, 15);
            }
            else
            {
                //nic
            }

            switch (vysledok)
            {
                case 2: Console.WriteLine("Vysledok bol 2"); break;
                case 3: Console.WriteLine("Vysledok bol 3"); break;
                case 4:
                case 5: Console.WriteLine("Vysledok bol 4 al 5"); break;
                default: Console.WriteLine("Vysledok nebol 2-5");break;

                
                    
            }

            bool anoNe = false;
            if (anoNe)
            {
                //nevykona sa 
            }

            if (!anoNe)
            {
                //vykona sa
            }

            if (vysledok==4 || vysledok ==5) //alebo
            {

            }

            if (vysledok==4 && anoNe==true) // a zaroven 
            {

            }

            if (((vysledok>=10 && vysledok<=20) || (vysledok>=40 && vysledok<=60)) && (vysledok !=16)) //&& medzi cislami
            {

            }

            Console.ReadLine();
        }
    }
}
