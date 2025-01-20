using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Algorithms
{
    internal class User : IComparable<User>, Interface1
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        public int CompareTo(User? other)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine(_name);
        }

        public void Swap<T>(ref T x, ref T y)
        {
            (x, y) = (y, x);
        }
    }
}
