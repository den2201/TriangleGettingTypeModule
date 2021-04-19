using System;
using Xunit;
using TriangleInfo;
using System.Collections.Generic;

namespace TriangleTest
{
    public class TriangleTest1
    {
        [Fact]
        public void Triangle_enterNoValueTypeSides_InvalidCastException()
        {
            ITriangleSrvice<string> triangle = new TriangleGetTypeService<string>();
            Assert.Throws<InvalidCastException>(() =>
            {
                triangle.ReturnTriangleTypeBySides("10", "20", "30");
            });

        }

        [Fact]
        public void Triangle_enterSidesLessOrEqualZero_ArgumentOutfRangeException()
        {
            ITriangleSrvice<int> triangle = new TriangleGetTypeService<int>();
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                triangle.ReturnTriangleTypeBySides(30, 30, 0);
            });

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                triangle.ReturnTriangleTypeBySides(-1, 30, 50);
            });

        }

        [Fact]

        public void Triangle_MaxSideOnFirstPositionInSideLists_FistElemnetIsMAxInListOfSides()
        {
            ITriangleSrvice<int> triangle = new TriangleGetTypeService<int>();
            triangle.ReturnTriangleTypeBySides(30, 60, 20);
            Assert.Equal(60, ((TriangleGetTypeService<int>)triangle).triangle.LongSide);
            Assert.Equal(30, ((TriangleGetTypeService<int>)triangle).triangle.SecondSide);
            Assert.Equal(20, ((TriangleGetTypeService<int>)triangle).triangle.ThirdSide);

        }

      
       
    }
}

      
