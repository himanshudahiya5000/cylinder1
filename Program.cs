using System;

namespace Cylinder
{
    class Cylinder
    {
        public double height; // length of a Cylinder
        public double radious; // radious of a Cylinder
        public double pi = 3.14; // fixed Ratio of a Cylinder
    }
    class Cylindertester
    { 
        static void Main(string[] args)
        {
            Cylinder Cylinder1 = new Cylinder(); // Declare Cylinder1 of box type
            Cylinder Cylinder2 = new Cylinder(); // Declare Cylinder1 of box type
            Cylinder Cylinder3 = new Cylinder();
            Cylinder Cylinder4 = new Cylinder();
            
            double volume = 0.0; // Store the volume of a box here

            // Cylinder 1 Specification
            Cylinder1.height = 10.0;
            Cylinder1.radious = 5.0;
            
            // Cylinder 1 volume = 785

            // Cylinder 2 Specifications
            Cylinder2.height = 20.0;
            Cylinder2.radious = 10.0;
            
            // Cylinder 2 volume = 6280

            // Cylinder 3 Specifications
            Cylinder3.height = 30.0;
            Cylinder3.radious = 15.0;
           
            // Cylinder 3 volume = 21195

            // Cylinder 4 Specifications
            Cylinder4.height = 40.0;
            Cylinder4.radious = 20.0;
           
            // Cylinder 4 volume = 50240

            // Volume of Cylinder 1
            volume = Cylinder1.pi * Cylinder1.height * Cylinder1.radious * Cylinder1.radious ;
            Console.WriteLine("volume of Cylinder1 : {0}", volume);

            // Volume of Cylinder 2
            volume = Cylinder2.pi * Cylinder2.height * Cylinder2.radious * Cylinder2.radious;
            Console.WriteLine("volume of Cylinder2 : {0}", volume);

            // Volume of Cylinder 3
            volume = Cylinder3.pi * Cylinder3.height * Cylinder3.radious * Cylinder3.radious;
            Console.WriteLine("volume of Cylinder3 : {0}", volume);

            // Volume of Cylinder 4
            volume = Cylinder4.pi * Cylinder4.height * Cylinder4.radious * Cylinder4.radious;
            Console.WriteLine("volume of Cylinder4 : {0}", volume);
            Console.ReadKey();

        }
    }
}
