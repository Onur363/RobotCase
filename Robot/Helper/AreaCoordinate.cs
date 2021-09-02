using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Helper
{
    public class AreaCoordinate
    {
        public int positionX { get; set; }
        public int positionY { get; set; }

        public static AreaCoordinate SetCoordinate(string coordinate)
        {
            var coordinateArray = coordinate.Split(' ');
            return new AreaCoordinate()
            {
                positionX = Convert.ToInt32(coordinateArray[0].ToString()),
                positionY = Convert.ToInt32(coordinateArray[1].ToString())
            };
        }
    }
}
