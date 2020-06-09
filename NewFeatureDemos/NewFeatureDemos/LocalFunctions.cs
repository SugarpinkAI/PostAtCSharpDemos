using System;

namespace NewFeatureDemos
{
    public class LocalFunctions
    {
        public void Old()
        {
            int a = 1;
            int b = 2;
            int c = OldPrivate1(1, 2);
            Console.WriteLine(OldPrivate2(c));
        }

        private int OldPrivate1(int x, int y)
        {
            return x + y;
        }

        private double OldPrivate2(int x)
        {
            return Math.PI * x;
        }

        public void New()
        {
            int a = 1;
            int b = 2;
            int c = newPrivate1(1, 2);

            Console.WriteLine(newPrivate2(c));

            int newPrivate1(int x, int y)
            {
                return x + y;
            }

            double newPrivate2(int x)
            {
                return Math.PI * x;
            }
        }
    }
}