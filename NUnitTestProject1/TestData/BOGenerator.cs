using NUnitTestProject1.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject1.TestData
{
    class BOGenerator
    {
        public static Login generateSimpleLogin()
        {
            return new Login("valpetrovnatwo", "vfhl.rtdbx32/");
        }
    }
}
