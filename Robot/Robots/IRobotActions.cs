using Robot.Robots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Helper
{
    public interface IRobotActions
    {
        void TurnRight(RobotBase robotBase);
        void TurnLeft(RobotBase robotBase);
        void Move(RobotBase robotBase);
    }
}
