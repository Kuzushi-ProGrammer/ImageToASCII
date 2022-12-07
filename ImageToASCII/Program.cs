using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;


namespace ImageToASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string basePath = Environment.CurrentDirectory;
            string relativePath = ".ImageToASCII/Images/AmongUs.png";

            string fullPath = Path.GetFullPath(relativePath, basePath);
            Console.WriteLine(fullPath);
            Image image = Image.FromFile(fullPath);
        }


        #region [Testing]
        /*
        static void Main(string[] args)
        {
            string brand;
            string speed;

            Console.WriteLine("Please input the brand of car you have: ");
            brand = Console.ReadLine();

            Console.WriteLine("Please input the speed of car you have");
            speed = Console.ReadLine();

            CreateCar(brand, Convert.ToInt32(speed));

            void CreateCar(string carBrand, int carSpeed)
            {
                Car customCar = new Car(carBrand, carSpeed);

                if (carSpeed > 9000)
                {
                    Console.WriteLine(string.Format("The car brand is {0}, and the speed is OVER 9000!!!", carBrand, carSpeed));
                    if (customCar.isNew)
                    {
                        Console.WriteLine("The car is also brand new!");
                    }
                }
                else
                {
                    Console.WriteLine(string.Format("The car brand is {0}, and the speed is {1}", carBrand, carSpeed));
                    if (customCar.isNew)
                    {
                        Console.WriteLine("The car is also brand new!");
                    }
                }
            }
        }
        */
        #endregion
    }
}
