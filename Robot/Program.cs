using Robot.Helper;
using Robot.Robots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen X Y koordinatlarını giriniz:");
            string coordinates = Console.ReadLine();
            var areaCoordinate = AreaCoordinate.SetCoordinate(coordinates);

            Console.WriteLine("RobotA için sırası ile x,y ve yön bilgilerini giriniz");
            string robotACoordinates = Console.ReadLine();
            
            Console.WriteLine("RobotA için yönlendirme komutlarını giriniz");
            string robotACommands = Console.ReadLine();
            RobotA robotA = new RobotA(robotACoordinates,robotACommands);

            Console.WriteLine("RobotB için sırası ile x,y ve yön bilgilerini giriniz");
            string robotBCoordinates = Console.ReadLine();
           
            Console.WriteLine("RobotB için yönlendirme komutlarını giriniz");
            string robotBCommands = Console.ReadLine();
            RobotA robotB = new RobotA(robotBCoordinates,robotBCommands);

            RobotActionHelper<List<RobotBase>> robotActionHelper = new RobotActionHelper<List<RobotBase>>();
            robotActionHelper.PrintRobotPosition(areaCoordinate, new List<RobotBase>() { robotA, robotB });

            Console.ReadLine();
        }
    }  
}


