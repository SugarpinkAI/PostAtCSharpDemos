using System;

namespace NonNullableReferenceTypes
{
    public class Program
    {
        public static void Main1()
        {
            Console.WriteLine("Please enter the filename!");
            var filename = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(filename))
            {
                filename = null;
            }

            var manager = new NonNullableDataManager(filename, 10, null);
        }

        public static void Main2()
        {
            Console.WriteLine("Please enter the filename!");
            var filename = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(filename))
            {
                filename = ".default";
            }

            var manager = new NonNullableDataManager(filename, 10, null);
        }

        public static void Main3()
        {
            var filename = NonNullStringSource.GetString();

            var manager = new NonNullableDataManager(filename, 10, null);
        }

        public static void Main4()
        {
            var filename = NullStringSource.GetString();

            var manager = new NonNullableDataManager(filename, 10, null);
        }

        public static void Main5()
        {
            Console.WriteLine("Please enter the filename!");
            var filename = Console.ReadLine();

            var manager = new NonNullableDataManager(filename, 10, null);
        }
    }
}