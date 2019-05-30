using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichaAssignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Richa Patel\nID-8334401\n");

            Program pg = new Program();
            pg.Fun();

            Console.ReadKey();
        }
        public void Fun()
        {
            Rectangle rectangle = new Rectangle();

            string r_length = "";
            int length;

            int width;
            string r_width = "";

            Console.WriteLine("length must be greater than 0.");
            try
            {
                while (true)
                {
                    Console.WriteLine("\n1.Get Rectangle Length");
                    Console.WriteLine("2.Change Rectangle Length");
                    Console.WriteLine("3.Get Rectangle Width");
                    Console.WriteLine("4.Change Rectangle Width");
                    Console.WriteLine("5.Get Rectangle Perimeter");
                    Console.WriteLine("6.Get Rectangle Area");
                    Console.WriteLine("7.Exit");

                    String choice = "";
                    int ch;

                    Console.WriteLine("\nplease enter number :");
                    choice = Console.ReadLine();
                    ch = int.Parse(choice);

                    if (ch == 7)
                    {
                        Console.WriteLine("thank you for choosing our application");
                        break;
                    }
                    else
                    {
                        switch (ch)
                        {
                            case 1:
                                Console.WriteLine("\nThe Length of Rectangle is {0}", rectangle.GetLength());
                                break;
                            case 2:
                                do
                                {
                                    Console.WriteLine("Enter the length: ");
                                    r_length = Console.ReadLine();
                                    length = int.Parse(r_length);

                                    if (length <= 1)
                                    {
                                        Console.WriteLine("\nLength must be greater than zero.");
                                    }
                                } while (!int.TryParse(r_length, out length) || (length <= 1));
                                rectangle.SetLength(length);
                                Console.WriteLine("\nThe Length of Rectangle is {0}", rectangle.GetLength());
                                break;

                            case 3:
                                Console.WriteLine("\nThe Width of Rectangle is {0}", rectangle.GetWidth());
                                break;

                            case 4:
                                do
                                {
                                    Console.WriteLine("\nEnter the width: ");
                                    r_width = Console.ReadLine();
                                    width = int.Parse(r_width);

                                    if (width <= 1)
                                    {
                                        Console.WriteLine("\nwidth must be greater than zero.");
                                    }
                                } while (!int.TryParse(r_width, out width) || (width <= 1));

                                rectangle.SetWidth(width);
                                Console.WriteLine("the width of rectangle {0}", rectangle.GetWidth());
                                break;
                            case 5:
                                Console.WriteLine("the perimeter of rectangle is :{0}", rectangle.GetPerimeter());
                                break;
                            case 6:
                                Console.WriteLine("the perimeter of rectangle is :{0}", rectangle.GetArea());
                                break;
                        }
                    }
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
        }

    }
}
