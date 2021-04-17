using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleInfo
{
    public  class TriangleGetTypeService <T> : ITriangleSrvice <T>
    {
        List<int> sides;
     internal Triangle triangle { get; set; }

       public TriangleGetTypeService()
        {
            sides = new List<int>();
        }
        private void ValidateSides( T first, T second, T third )
        {
            
            if ((!typeof(T).IsValueType))
                throw new InvalidCastException("Entering sides must be Int32 type or convertable to Int32 Type");
            try
            {
                sides.Add(Convert.ToInt32(first));
                sides.Add(Convert.ToInt32(second));
                sides.Add(Convert.ToInt32(third));
                CheckSidesGreaterZero(sides);
            }

            catch(InvalidCastException e)
            {
                throw new InvalidCastException("Can't cast to int Format");
            }
            catch(ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException(e.ToString());
            }

        }

        private void CheckSidesGreaterZero(IEnumerable<int> sides)
        {
            if(sides.Where(x => x <= 0).ToList().Count() > 0)
            {
                throw new ArgumentOutOfRangeException("Side of triagle must be greater 0");
            }
        }

        private Triangle GenerateTriangle(IEnumerable<int> sides)
        {
            return new Triangle(sides);
        }

        public string ReturnTriangleTypeBySides(T x, T y, T z)
        {
            ValidateSides(x, y, z);
            triangle = GenerateTriangle(sides);
            return triangle.GetTriangleType().ToString();
        }
    }
}
