using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rovio_Demo_Code_Actual
{
    class Program
    {
        static void Main(string[] args)
        {
            Rovio.Robot robot = new Rovio.Robot("http://192.168.1.65/", "admin", "adminn");

            try { robot.API.Movement.GetLibNSVersion(); } // a dummy request
            catch (Exception) { Console.WriteLine("Could not connect to the robot"); return; }

            bool finish = true;
            while (finish == true)
            {
                string input;
                input = Console.ReadLine();
                if (input == "go")
                {
                    for (int j = 0; j < 5; j++)
                    {
                        for (int i = 0; i < 80; i++)
                        {
                            robot.Drive.Forward(30);
                        }
                        for (int i = 0; i < 15; i++)
                        {
                            robot.Drive.RotateLeft(90);
                        }
                        
                        for (int i = 0; i < 40; i++)
                        {
                            robot.Drive.Forward(30);
                        }
                        for (int i = 0; i < 15; i++)
                        {
                            robot.Drive.RotateLeft(90);
                        }
                        for (int i = 0; i < 80; i++)
                        {
                            robot.Drive.Forward(30);
                        }
                        for (int i = 0; i < 15; i++)
                        {
                            robot.Drive.RotateLeft(90);
                        }
                        for (int i = 0; i < 40; i++)
                        {
                            robot.Drive.Forward(30);
                        }
                        for (int i = 0; i < 15; i++)
                        {
                            robot.Drive.RotateLeft(90);
                        }

                    }
                }
                else if (input == "stop")
                    finish = false;
                else if (input == "test")
                {
                    for (int i = 0; i < 100; i++)
                    {
                        robot.Drive.Forward(30);
                    }
                }
                else
                    Console.WriteLine("Please enter either go or stop");

            }
        }
    }
}
