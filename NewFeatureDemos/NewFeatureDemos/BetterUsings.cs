using System.IO;

namespace NewFeatureDemos
{
    public class BetterUsings
    {
        public void Old()
        {
            using (var input = new System.IO.StreamReader("Input.txt"))
            {
                using (var output = new System.IO.StreamWriter("Output.txt"))
                {
                    // Do Stuff
                }
            }
        }

        public void New()
        {
            using var input = new System.IO.StreamReader("Input.txt");
            using var output = new System.IO.StreamWriter("Output.txt");
            // Do Stuff
        }
    }
}