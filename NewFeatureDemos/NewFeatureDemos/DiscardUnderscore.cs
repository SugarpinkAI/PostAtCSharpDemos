using System;
using System.Collections.Generic;
using System.Text;

namespace NewFeatureDemos
{
    public class DiscardUnderscore
    {
        public interface ISomeInterface
        {
            string SomeMethod(string foo, string bar, string foobar);
        }

        public class SomeImplementation : ISomeInterface
        {
            public string SomeMethod(string foo, string _thisImplementationDoesNotUseBar, string foobar)
            {
                return foo + foobar;
            }
        }

        public void SomeMoreDiscards()
        {
            var _weLikeMakingTheUserType = Console.ReadLine();
            string foo = "123";

            if(int.TryParse(foo, out _))
            {
                Console.WriteLine("Surprise, we can parse that number");
            }
        }
    }
}
