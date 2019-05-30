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
                //LOOP CAN ASK USER WHETHER COUNTINUE PROGRAM OR EXIST
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

                    //ASK USER ABOUT LENGTH AND WIDTH OF RECTANGLE
                    Console.WriteLine("\nplease enter number :");
                    choice = Console.ReadLine();
                    ch = int.Parse(choice);

                    //LOOP BREAK IF USER WANTS TO EXIST
                    if (ch == 7)
                    {
                        Console.WriteLine("thank you for choosing our application");
                        break;
                    }
                    //LOOP COUNTINUES RUNNING WHILE USRE GIVE CHOICE BETWEEN 1 TO 6
                    else
                    {
                        switch (ch)
                        {
                            // CASE 1 FOR GET RECTANGLE LENGTH
                            case 1:
                                Console.WriteLine("\nThe Length of Rectangle is {0} X {1}", rectangle.GetLength(), rectangle.GetWidth());
                                break;
                            // CASE 2 FOR CHANGE RECTANGLE LENGTH
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
                                Console.WriteLine("\nThe changed Length of Rectangle is {0} X {1}", rectangle.GetLength(), rectangle.GetWidth());
                                break;

                            // CASE 3 FOR GET RECTANGLE WIDTH
                            case 3:
                                Console.WriteLine("\nThe Width of Rectangle is {0} x {1}", rectangle.GetLength(),rectangle.GetWidth());
                                break;                               

                            // CASE 4 FOR CHANGE RECTANGLE WIDTH
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
                                Console.WriteLine("the changed width of rectangle {0} X {1}", rectangle.GetLength(),rectangle.GetWidth());
                                break;

                            // CASE 5 FOR GET RECTANGLE PERIMETER
                            case 5:
                                Console.WriteLine("the perimeter of rectangle is :{0}", rectangle.GetPerimeter());
                                break;

                            // CASE 6 FOR GET RECTANGLE AREA
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
