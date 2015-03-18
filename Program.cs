using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rovio_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Rovio.Robot robot = new Rovio.Robot("http://ip_address/", "user", "password");

            //check if we can receive responses from the robot
            try { robot.API.Movement.GetLibNSVersion(); } // a dummy request
            catch (Exception) { Console.WriteLine("Could not connect to the robot"); return; }

            //move the robot forward

            //using the CGI commands
            //robot.Request("rev.cgi?Cmd=nav&action=18&drive=1&speed=5");

            //using the wrapper library - API commands
            //robot.API.Movement.ManualDrive.Forward(5);

            //using the convenience class
            //robot.Drive.Forward(5);
            bool finish = true;
            while(finish == true)
            {
                string input;
                input = Console.ReadLine();
                if (input == "go")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        robot.Drive.Forward(20);
                        robot.Drive.RotateLeft(90);
                        robot.Drive.Forward(20);
                        robot.Drive.RotateLeft(90);
                        robot.Drive.Forward(20);
                        robot.Drive.RotateLeft(90);
                        robot.Drive.Forward(20);
                        robot.Drive.RotateLeft(90);

                    }
                }
                else if (input == "stop")
                    finish = false;
                else
                    Console.WriteLine("Please enter either go or stop");

            }
           
        }
    }
}