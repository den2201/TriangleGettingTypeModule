using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleInfo
{
    public enum TriangleType
    {
        RightTriangle,
        AcuteAangleTriangle,
        ObtuseTriangle,
        UnknownType
    }
    internal class Triangle 
    {
         public double LongSide { get;  private set; }

        public double SecondSide { get; private set; }

        public double ThirdSide { get; private set; }

        

        internal Triangle(IEnumerable<int> sides)
        {
            var temp = sides.OrderByDescending(x => x).ToArray();
            LongSide = temp.First();
            SecondSide = temp[1];
            ThirdSide = temp[2];
        }

        private TriangleType CheckForTriangleType()
        {
            if (Math.Pow(LongSide, 2) == Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2))
                return TriangleType.RightTriangle;
            else if (Math.Pow(LongSide, 2) < Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2))
                return TriangleType.AcuteAangleTriangle;
            else if (Math.Pow(LongSide, 2) > Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2))
                return TriangleType.ObtuseTriangle;
            else
                return TriangleType.UnknownType;
        }
        internal TriangleType GetTriangleType()
        {
            return CheckForTriangleType();
        }

    }
}
