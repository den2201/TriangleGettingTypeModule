using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleInfo
{
    public interface ITriangleSrvice <T>
    {
        string ReturnTriangleTypeBySides(T x, T y, T z);
    }
}
