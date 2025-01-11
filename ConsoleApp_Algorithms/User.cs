using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Algorithms
{
    internal class User : IComparable<User>, Interface1
    {
        public int CompareTo(User? other)
        {
            throw new NotImplementedException();
        }

        public int Print()
        {
            throw new NotImplementedException();
        }

        public int Swap<T>(ref T x, ref T y)
        {
            throw new NotImplementedException();
        }
    }
}
