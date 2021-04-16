using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleInfo
{
    internal  class TriangleService <T>
    {
        internal TriangleService(T a, T b, T c  )
        {
            CheckForValueType();
           
        }
        internal void CheckForValueType()
        {
            if ((!typeof(T).IsValueType) && (typeof(T) != typeof(int)))
                throw new InvalidCastException("Entering sides must be Int32 type");
        }

        

    }
}
