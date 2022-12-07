using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.CompilerServices;
using System.Configuration;

namespace ImageToASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder(); 
            string path = "ImageToASCII\\bin\\Debug\\Images\\";

            Console.WriteLine("Put your image in the Images folder located at {0}", path);
            Console.Write("Input the name of the image you want to convert: ");
            string imageName = Console.ReadLine();

            string relativePath = "Images\\" + imageName;
            string fullPath = Path.GetFullPath(relativePath);

            if (File.Exists(fullPath))
            {
                Console.WriteLine("YIPEE");
                System.Drawing.Image imageFile = System.Drawing.Image.FromFile(fullPath);
                Bitmap bitmap = new Bitmap(imageFile);

                for (int h = 0; h < bitmap.Height; h++)
                {
                    for (int w = 0; w < bitmap.Width; w++)
                    {
                        Color colour = bitmap.GetPixel(w, h);

                        colour = Color.FromArgb((colour.R + colour.G + colour.B) / 3, (colour.R + colour.G + colour.B) / 3, (colour.R + colour.G + colour.B) / 3);

                        int redValue = int.Parse(colour.R.ToString());

                        stringBuilder.Append(GreyscalerToAscii(redValue));

                    }
                }
            }
            else
            {
                Console.WriteLine("Sobbing :(");
            }
        }
        static string GreyscalerToAscii(int value)
        {
            string ASCIIValue = "";

            // using red works all the way up until #7f7f7f (midpoint)
            // if red and one other colour max out, the remaining colour's magnitude determines the brightness
            // ex. (255, 255, 10) would be lighter than (255, 0, 0)
            if (value > 230)
            {
                ASCIIValue = ASCIIConstants.BLACK;
            }
            else if (value > 200)
            {
                ASCIIValue = ASCIIConstants.DARK_GREY;
            }
            else if (value > 170)
            {
                ASCIIValue = ASCIIConstants.DARKER_MID_GREY;
            }
            else if (value > 140)
            {
                ASCIIValue = ASCIIConstants.MID_GREY;
            }
            else if (value > 110)
            {
                ASCIIValue = ASCIIConstants.GREY;
            }
            else if (value > 80)
            {
                ASCIIValue = ASCIIConstants.LIGHT_MID_GREY;
            }
            else if (value > 50)
            {
                ASCIIValue = ASCIIConstants.LIGHTER_MID_GREY;
            }
            else if (value > 20)
            {
                ASCIIValue = ASCIIConstants.WHITE;
            }

            return ASCIIValue;
        }

        public static class ASCIIConstants
        {
            public const string WHITE = " ";
            public const string LIGHT_GREY = "`";
            public const string LIGHT_MID_GREY = ".";
            public const string LIGHTER_MID_GREY = ",";
            public const string GREY = "*";
            public const string MID_GREY = "!";
            public const string DARKER_MID_GREY = "+";
            public const string DARK_GREY = "?";
            public const string BLACK = "%";
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
