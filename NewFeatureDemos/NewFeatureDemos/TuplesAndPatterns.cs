using System;

namespace NewFeatureDemos
{
    public class TuplesAndPatterns
    {
        public static void NewTuples()
        {
            var person = ("Patrick", 178, 27 ,true);
            Console.WriteLine(person.Item1);
        }

        public static void NewTuplesNamed()
        {
            var person = (Name: "Patrick", Height: 178, Age: 27, Employed: true);
            Console.WriteLine(person.Name);
        }

        public static void NewTuplesReturnValue1()
        {
            var result = NewTuplesReturnValue2();
            Console.WriteLine(result.Value);
        }

        public static (string Value, object Error) NewTuplesReturnValue2()
        {
            return ("Patrick", null);
        }

        public static bool LeapYearIf(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }

                    return false;
                }

                return true;
            }

            return false;
        }

        public static bool LeapYearTuplePatterns(int year)
        {
            var yearProperties = (year % 4 == 0, year % 100 == 0, year % 400 == 0);

            switch (yearProperties)
            {
                case (true, false, _):
                case (true, true, true):
                    return true;

                case (true, true, false):
                default: 
                    return false;
            }
        }

        public static bool ElligibleForBetaAccess((bool RequestedBeta, bool AttendedEvent, bool IsVip, int UserId, string Name) customerInfo)
        {
            switch (customerInfo)
            {
                case (_, _, true, _, "Patrick"):
                    return false;
                case (true, _, true, _, _):
                    return true;
                case (true, true, _, _, _) c when c.UserId <= 10000:
                    return true;
                case (true, true, _, _, _):
                    return false;
                default:
                    return false;
            }
        }

        public static int GetLongestSide(object o)
        {
            switch (o)
            {
                case Rectangle r when r.X > r.Y:
                    return r.X;
                case Rectangle r:
                    return r.Y;
                case Square s:
                    return s.X;
                case Circle _:
                    return 0;
                default: 
                    throw new InvalidOperationException();
            }
        }

        public class Rectangle
        {
            public int X { get; set; }

            public int Y { get; set; }
        }

        public class Circle
        {
            public int Radius { get; set; }
        }

        public class Square
        {
            public int X { get; set; }
        }
    }
}