using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Robots
{
    public abstract class RobotBase
    {
        public int currentPositionX { get; set; }
        public int currentPositionY { get; set; }
        public char currentRoute { get; set; }
        public string actionCommands { get; set; }

        public RobotBase(string coordinate,string commands)
        {
            var coordinateArray = coordinate.Split(' ');
            currentPositionX = Convert.ToInt32(coordinateArray[0].ToString());
            currentPositionY = Convert.ToInt32(coordinateArray[1].ToString());
            currentRoute = Convert.ToChar(coordinateArray[2].ToString());
            actionCommands = commands.Trim().ToUpper();
        }
    }
}
