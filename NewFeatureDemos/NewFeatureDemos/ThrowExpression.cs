using System;

namespace NewFeatureDemos
{
    public class ThrowExpression
    {
        public string SomeDataProperty { get; set; }

        public void Old1(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            SomeDataProperty = input;
        }

        public void New1(string input)
        {
            SomeDataProperty = input ?? throw new ArgumentNullException(nameof(input));
        }

        public void Old2(string input)
        {
            if (input == "Bad Input")
            {
                throw new ArgumentException("Input was Bad");
            }

            SomeDataProperty = "I am " + input;
        }

        public void New2(string input)
        {
            SomeDataProperty = input != "Bad Input" ? "I am " + input : throw new ArgumentException("Input was Bad");
        }
    }
}