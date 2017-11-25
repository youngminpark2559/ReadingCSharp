using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c Add a project AddWithThreads to examine the feature of ParameterizedThreadStart delegate.

namespace AddWithThreads
{
    class AddParams
    {
        public int a, b;

        public AddParams(int numb1, int numb2)
        {
            a = numb1;
            b = numb2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
