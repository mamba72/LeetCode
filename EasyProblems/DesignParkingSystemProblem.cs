using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyProblems
{
	internal class DesignParkingSystemProblem
	{
        //solving this problem: https://leetcode.com/problems/design-parking-system/

        public class ParkingSystem
        {

            int small;
            int big;
            int medium;
            public ParkingSystem(int big, int medium, int small)
            {
                this.small = small;
                this.medium = medium;
                this.big = big;
            }

            public bool AddCar(int carType)
            {
                switch (carType)
                {
                    case 3:
                        if (small > 0)
                        {
                            --small;
                            return true;
                        }
                        else
                            return false;
                    case 2:
                        if (medium > 0)
                        {
                            --medium;
                            return true;
                        }
                        else
                            return false;
                    case 1:
                        if (big > 0)
                        {
                            --big;
                            return true;
                        }
                        else
                            return false;
                    default:
                        return false;
                }
            }
        }
    }
}
