using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace NewFeatureDemos
{
    class OutParameters
    {
        public void Old()
        {
            int parsedNumber;
            int.TryParse("420", out parsedNumber);
            Console.WriteLine(parsedNumber);
        }

        public void New()
        {
            int.TryParse("420", out int parsedNumber);
            Console.WriteLine(parsedNumber);
        }

        public void New2()
        {
            int.TryParse("420", out int _);
        }
    }
}
