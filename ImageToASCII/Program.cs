﻿using System;
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

                        int greenValue = int.Parse(colour.G.ToString());
                        GetGreyValue(greenValue);

                    }
                }


            }
            else
            {
                Console.WriteLine("Sobbing :(");
            }


        }

        static string GetGreyValue(int greenValue)
        {
            ASCIIConstants ascii = new ASCIIConstants();
            string ASCIIValue = "";

            if (greenValue > 200)
            {
                ASCIIValue = ;
            }
            else if (greenValue < 200)
            {

            }

            return ASCIIValue;
        }
        public class ASCIIConstants
        {
            public const string White = " ";
            const string LightGrey = "`";
            const string LightMidGrey = ".";
            const string LighterMidGrey = ",";
            const string Grey = "*";
            const string MidGrey = "!";
            const string DarkerMidGrey = "+";
            const string DarkGrey = "?";
            const string Black = "%";

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
