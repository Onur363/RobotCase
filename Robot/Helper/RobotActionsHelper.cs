using Robot.Robots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Helper
{
    public class RobotActionHelper<T> : IRobotActions where T:List<RobotBase>,new()
    {
        public void Move(RobotBase robotBase)
        {
            switch (robotBase.currentRoute)
            {
                case 'N':
                    robotBase.currentPositionY += 1;
                    break;
                case 'E':
                    robotBase.currentPositionX += 1;
                    break;
                case 'S':
                    robotBase.currentPositionY -= 1;
                    break;
                case 'W':
                    robotBase.currentPositionX -= 1;
                    break;
                default:
                    break;
            }
        }

        public void TurnLeft(RobotBase robotBase)
        {
            switch (robotBase.currentRoute)
            {
                case 'N':
                    robotBase.currentRoute = 'W';
                    break;
                case 'E':
                    robotBase.currentRoute = 'N';
                    break;
                case 'S':
                    robotBase.currentRoute = 'E';
                    break;
                case 'W':
                    robotBase.currentRoute = 'S';
                    break;
                default:
                    break;
            }
        }

        public void TurnRight(RobotBase robotBase)
        {
            switch (robotBase.currentRoute)
            {
                case 'N':
                    robotBase.currentRoute = 'E';
                    break;
                case 'E':
                    robotBase.currentRoute = 'S';
                    break;
                case 'S':
                    robotBase.currentRoute = 'W';
                    break;
                case 'W':
                    robotBase.currentRoute = 'N';
                    break;
                default:
                    break;
            }
        }

        public void PrintRobotPosition(AreaCoordinate areaCoordinate, T robotList)
        {
            foreach (RobotBase _robotBase in robotList)
            {
                for (int i = 0; i < _robotBase.actionCommands.Length; i++)
                {
                    if (_robotBase.actionCommands[i] == 'L')
                    {
                        TurnLeft(_robotBase);
                    }
                    else if (_robotBase.actionCommands[i] == 'R')
                    {
                        TurnRight(_robotBase);
                    }
                    else if (_robotBase.actionCommands[i] == 'M')
                    {
                        Move(_robotBase);
                    }
                }
                ControlPositions(areaCoordinate, _robotBase);

                Console.WriteLine("{0} {1} {2}", _robotBase.currentPositionX, _robotBase.currentPositionY, _robotBase.currentRoute);
            }
        }

        private void ControlPositions(AreaCoordinate areaCoordinate, RobotBase robotBase)
        {
            if (areaCoordinate.positionX < robotBase.currentPositionX)
            {
                robotBase.currentPositionX = areaCoordinate.positionX;
            }

            if (robotBase.currentPositionX < 0)
            {
                robotBase.currentPositionX = 0;
            }

            if (areaCoordinate.positionY < robotBase.currentPositionY)
            {
                robotBase.currentPositionY = areaCoordinate.positionY;
            }

            if (robotBase.currentPositionY < 0)
            {
                robotBase.currentPositionY = 0;
            }

        }
    }
}
