using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double htxft, hrxft;
            double x1, x2, y1, y2;
            Console.Clear();
        home:
            Console.Clear();
            Console.WriteLine("Pick an Option");
            Console.WriteLine("1. Signal Range Calculator \n2. Distance Calculator  \n\nEnter Choice: ");
            String choice = Convert.ToString(Console.ReadLine());
            if (choice == "1")
            {
                Console.Clear();
                snr:
                Console.Clear();
                Console.WriteLine("Enter Height of antenna transmitter(HTx) in ft!");
                try{
                    htxft = Double.Parse(Console.ReadLine());

                } catch (FormatException)
                {
                    Console.Write("is not a valid number!! \n");
                    Console.WriteLine("Press Enter to Continue...");

                    Console.ReadLine();
                    goto snr;
                }

            hrx:
                Console.WriteLine("Enter Height of antenna reciever(HRx) in ft!");
                try { 
                    hrxft = Double.Parse(Console.ReadLine());
                }

                catch (FormatException) {
                    Console.WriteLine("Is not a valid number!! \n");
                    Console.WriteLine("Press Enter to Continue...");

                    Console.ReadLine();

                    goto hrx;
                }

                Console.WriteLine("..................................");
                Console.WriteLine("The Result is");
                Hcalc();
                Console.WriteLine("Miles\nor ");
                HcalcKm();
                Console.WriteLine(".................................. \n\n\n\n");
                Console.WriteLine("Press Enter to Continue...");

                Console.ReadLine();
                goto home;
            }
            else if (choice == "2")
            {
            Console.Clear();
                dstance:
                Console.Clear();
                Console.WriteLine("Enter Latitude 1(X1)");
                try { 
                x1 = Double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Is not a valid number!! \n");
                    Console.WriteLine("Press Enter to Continue...");

                    Console.ReadLine();
                    goto dstance;

                }

                y1:
                Console.WriteLine("Enter Longitude 1(Y1)");
                try
                {
                    y1 = Double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Is not a valid number!! \n");
                    Console.WriteLine("Press Enter to Continue...");

                    Console.ReadLine();
                    goto y1;
                }

                x2:
                Console.WriteLine("Enter Latitude 2(X2)");
                try
                {
                    x2 = Double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Is not a valid number!! \n");
                    Console.WriteLine("Press Enter to Continue...");

                    Console.ReadLine();
                    goto x2;
                }

                y2:
                Console.WriteLine("Enter Longitude 2(Y2)");
                try
                {
                    y2 = Double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Is not a valid number!! \n");
                    Console.WriteLine("Press Enter to Continue...");
                    Console.ReadLine();
                    goto y2;
                }

                Console.WriteLine("..................................");

                Console.WriteLine("The Result is \n");
                Dcalc();
                Console.WriteLine(".................................. \n\n\n\n");
                Console.WriteLine("Press Enter to Continue...");

                Console.ReadLine();
                goto home;
            }
            else
            {
                Console.WriteLine("Please choose between the two options. \n\n\n");
                Console.WriteLine("Press Enter to Continue...");

                Console.ReadLine();
                goto home;
            }

            void Dcalc()
            {
                
                Console.WriteLine(Math.Round(Math.Sqrt((Math.Pow((x2 - x1), 2)) + ((Math.Pow((y2 - y1), 2)))) * 100, 2) + "\n\n\n");
            }

            void Hcalc()
            {
                Console.WriteLine(Math.Round((Math.Sqrt(2)) * (htxft) + (Math.Sqrt(2)) * (hrxft) ,2) + "\n\n\n");
            }

            void HcalcKm()
            {
                Console.WriteLine((Math.Round((((Math.Sqrt(2)) * (htxft) + (Math.Sqrt(2)) * (hrxft)) * (1.609)),2)) + "\n\n\n");
            }
        }
    }
}
