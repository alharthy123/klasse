using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasse
{
    class Person
    {

        //Eigenschaften
        public string Name;
        public int Alter;
        public string vorname;

        //Methoden
        public void vorstellen()
        {
            Console.WriteLine("hallo meine name ist {0}  {1}", vorname, Name);
            Console.WriteLine("ich bin {0} jahre alt!", Alter);
        }
    }


    internal class Program
    {
        
        static void Main(string[] args)
        {
            Person an = new Person();//Objekt erzeugen
            an.Alter = 34;
            an.Name = "anna";
            an.vorname = "müller";
            an.vorstellen();
            Console.WriteLine();
            Console.ReadLine();
          

            //beliebig viele Objekte möglich
            Person person = new Person();
            person.Alter = 16;
            person.vorname = "ben";
            person.Name = "meier";
           
            person.vorstellen();   
            Console.WriteLine();
            Console.ReadLine();


            Console.WriteLine();
            Person an2 = new Person();
            Console.Write("alter:");
            an2.Alter = Convert.ToInt32(Console.ReadLine());
            Console.Write("vornamé");
            an2.vorname = Convert.ToString(Console.ReadLine());
            Console.Write("name");
            an2.Name = Convert.ToString(Console.ReadLine());    
            an2.vorstellen();
            Console.WriteLine();
            Console.ReadLine();

        }
    }



}





