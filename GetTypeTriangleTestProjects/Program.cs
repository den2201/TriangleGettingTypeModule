using System;
using TriangleInfo;

namespace GetTypeTriangleTestProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            ITriangleSrvice<int> triangle = new TriangleGetTypeService<int>();
            
            Console.WriteLine(triangle.ReturnTriangleTypeBySides(3, 4, 5));
            Console.WriteLine(triangle.ReturnTriangleTypeBySides(5, 5, 5));
            Console.WriteLine(triangle.ReturnTriangleTypeBySides(7, 7, 5));
            Console.WriteLine(triangle.ReturnTriangleTypeBySides(3, 4, 40));
            ///
            ///Exception: Zero is incorrect length of side
            ///
          //  Console.WriteLine(triangle.ReturnTriangleTypeBySides(1, 0, 5));
            Console.ReadKey();
        }
    }
}
