using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myClassLib;


/*
* SA
* CSC 153
* 3.18.2020
* CarClass_Assignment with a WPF form.
*/

namespace ConsoleUI
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            bool replay = true; //sentinel for do-while
            bool carCreated = false; //when car is created will be assigned true.
            do
            {
                Console.Clear();//clear screen
                Console.WriteLine(StdMsgs.DisplayMenu(carCreated));//Display menu.
                switch (Console.ReadLine())
                {
                    case "1"://Create Car/Show Car
                        if (carCreated == false)
                        {
                            CarWpfAppUI.MainWindow test = new CarWpfAppUI.MainWindow();
                            test.ShowDialog();
                            carCreated = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine(StdMsgs.ShowCar(Garage.myCar));
                            Console.ReadLine();
                            break;
                        }
                    case "2"://Accelerate
                        if (carCreated == false)
                        {
                            Console.WriteLine(myClassLib.StdMsgs.NoCarPrompt());
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Garage.myCar.Accelerate();
                            Console.WriteLine(StdMsgs.ShowSpeed(Garage.myCar));
                            Console.ReadLine();
                            break;
                        }
                    case "3"://Brake
                        if (carCreated == false)
                        {
                            Console.WriteLine(myClassLib.StdMsgs.NoCarPrompt());
                            Console.ReadLine();
                            break;
                        }
                        else 
                        {
                            Garage.myCar.Brake();
                            Console.WriteLine(StdMsgs.ShowSpeed(Garage.myCar));
                            Console.ReadLine();
                            break;
                        }
                    case "4"://Exit
                        replay = false;
                        break;
                    default:
                        Console.WriteLine(StdMsgs.DisplayBadInputPrompt());
                        Console.ReadLine();
                        break;
                }//end switch

            } while (replay == true); //end do-while

        }//end main
    }//end class
}//end namespace
