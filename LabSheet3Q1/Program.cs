using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3Q1
{
    class Car
    {
        //  attributes
        private string _make;
        private string _model;
        private double _currentSpeed;
        private double _engineSize;


        public string Make      // Name property used to get and set the make attribute of an object
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }
        // Model property used to get and set the model attribute of an object
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        
        public double CurrentSpeed { get; set; }

        // EmployeeNumber property used to get and set the employee number attribute of an object
        public double EngineSize
        {
            get
            {
                return _engineSize;
            }
            set
            {
                _engineSize = value;
            }
        }

        public Car()   // Default construct
        {
        }

        public Car(string m, string n, double e, double s)   //parameterised constructor
        {
            Make = m;
            Model = n;
            EngineSize = e;
            CurrentSpeed = s;

        }

        public override string ToString()   // Method to print the attributes of an object
        {
            return "Make: " + Make + " Model : " + Model + " Engine Size : " + EngineSize + " current speed : " + CurrentSpeed;
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car Make = {Make}");
            Console.WriteLine($"Car Model = {Model}");
            Console.WriteLine($"Car Engine size = {EngineSize}");
            Console.WriteLine($"Car Current speed = {CurrentSpeed}");
        }

        public void Accelerate()
        {
            CurrentSpeed = CurrentSpeed + 10;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Car first = new Car("Jaguar", "XK6", 4.5, 30);
            Car next = new Car();
            next.Make = "Ford";
            next.Model = "Focus";
            next.EngineSize = 1.6;
            next.CurrentSpeed = 78;

            Console.WriteLine(first);
            Console.WriteLine(next);

           // Console.WriteLine("Please choose the car that you want the info on (first/next): ");
            first.DisplayCarInfo();
            first.Accelerate();
            //first.DisplayCarInfo();  //output check to see if Accelerate has worked

            next.Accelerate();
            next.DisplayCarInfo();

            for (int i = 0; i < 10; i++)
            {
                first.Accelerate();
                if(first.CurrentSpeed>=100)   //break out of loop of car has already reached 100
                {
                    Console.WriteLine($"accelerator pressed {i+1} ");
                    break;  
                }
                
            }



        }
    }
}
