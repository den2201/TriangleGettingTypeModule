using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleInfo
{
    public class TriangleInfo<T> : ITriangle
    {
        public T LongSide { get;  set; }

        public T SecondSide { get; set; }

        public T ThirdSide { get; set; }

        private TriangleService<T> validationService;

        public TriangleInfo(T firstSide, T secondSide, T thirdSide)
        {
           validationService = new TriangleService<T>(firstSide, secondSide, thirdSide);
           validationService.CheckForValueType();
            LongSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

        }
        public string GetTriangleType()
        {
            throw new NotImplementedException();
        }
    }
}
