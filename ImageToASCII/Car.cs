using System;

namespace ImageToASCII
{
    // Class
    public class Car
    {
        public string type;
        public int speed;
        public bool isNew;

        // Method
        public void CarGoVroom()
        {
            Console.WriteLine("BRRRRRRRRRRR");
        }
        // Main (Reads through line by line)
        static void Main(string[] args)
        {
            Car honda = new Car("Honda", 5000);

            Car kia = new Car("Kia", 9001);
        }

        // Constructor
        public Car(string carBrand, int carSpeed)
        {
            isNew = true;
            type = carBrand;
            speed = carSpeed;
        }
    }
}

