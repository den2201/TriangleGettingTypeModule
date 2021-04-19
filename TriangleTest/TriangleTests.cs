using System;
using System.Collections.Generic;
using System.Text;
using TriangleInfo;
using Xunit;

namespace TriangleTest
{
    
    public class TriangleTests
    {
        [Fact]
        public void TriangleClass_MaxSideOnFirstPositionInSideLists_FistElemnetIsMAxInListOfSides()
        {
            Triangle triangle = new Triangle(new List<int>() { 70, 40, 80 });

            Assert.Equal(80, triangle.LongSide);
            Assert.Equal(70, triangle.SecondSide);
            Assert.Equal(40, triangle.ThirdSide);
        }

        [Fact]

        public void TriangleEntity_AddSidesAsRightTriangle_ReturnRightTriangle()
        {
            Triangle triangle = new Triangle(new List<int>() { 4, 5, 3});
            Assert.Equal(TriangleType.RightTriangle,  triangle.GetTriangleType());
        }

        [Fact]

        public void TriangleEntity_AddSidesTwoAreEqual_ReturnAcuteAangleTriangle()
        {
            Triangle triangle = new Triangle(new List<int>() { 5, 5, 7 });
            Assert.Equal(TriangleType.AcuteAangleTriangle, triangle.GetTriangleType());
        }

        [Fact]

        public void TriangleEntity_AddSidesTreeAreEqual_ReturnAcuteAangleTriangle()
        {
            Triangle triangle = new Triangle(new List<int>() { 5, 5, 5 });
            Assert.Equal(TriangleType.AcuteAangleTriangle, triangle.GetTriangleType());
        }

        [Fact]

        public void TriangleEntity_AddSidesObtuseTriangle_ReturnObtuseTriangle()
        {
            Triangle triangle = new Triangle(new List<int>() { 5, 5, 30 });
            Assert.Equal(TriangleType.ObtuseTriangle, triangle.GetTriangleType());
        }
    }
}
