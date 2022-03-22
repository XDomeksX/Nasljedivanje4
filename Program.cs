using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje4
{ 
    class GeometrijskiLik
{
    protected int BrojStranica;  //protected - pristup ima ta klasa i njezine podklase
    protected double[] Stranice = new double[10];  //stvaramo niz tipa double

    public void UcitajStranice()
    {
        for (int i = 0; i < BrojStranica; i++)
        {
            Console.WriteLine("Unesi duljinu {0}. stranice", i + 1);  //{0} - broojac koji koristi i kao svoju vrijednost
            string s = Console.ReadLine();
            Stranice[i] = Convert.ToDouble(s);
        }
    }

    public double Opseg()
    {
        double opseg = 0;
        for (int i = 0; i < BrojStranica; i++)
        {
            opseg += Stranice[i];
        }
        return opseg;
    }

    class Trokut : GeometrijskiLik
    {
        public Trokut()
        {
            BrojStranica = 3;
        }
    }

    class Cetverokut : GeometrijskiLik
    {
        public Cetverokut()
        {
            BrojStranica = 4;
        }
    }

    internal class Program
    {
        }
        static void Main(string[] args)
        {
            Trokut t = new Trokut();
            t.UcitajStranice();  //priziv metode UcitajStranice
            Console.WriteLine("Opseg trokuta je: {0}", t.Opseg());

            Console.WriteLine(Environment.NewLine);

            Cetverokut c = new Cetverokut();
            c.UcitajStranice();
            Console.WriteLine("Opseg cetverokuta je: {0}", c.Opseg());

            Console.ReadKey();
        }
    }
}
