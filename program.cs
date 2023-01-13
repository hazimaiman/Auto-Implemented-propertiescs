using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auto-Implemented properties =  shortcut when no additional logic is required in the property
            //                                you do not have to define a field for a property,
            //                                you only have to write get; and/or set; inside the property   

            Car car = new Car("MYVI");

            Console.WriteLine(car.Model);

            Console.ReadKey();
        }
    }
    class Car
    {


        public String Model { get; set; }

        //two way cara atass if tkde value
        /*String model;

        public String Model
        {
            get { return model; }
            set { model = value; }
        }*/


        public Car(String model) 
        { 
            this.Model = model;
        }

    }
}





