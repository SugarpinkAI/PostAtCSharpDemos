using System;
using System.Net.Http.Headers;

namespace NewFeatureDemos
{
    public class DefaultExpressions
    {
        HttpRequestHeaders Foo = default(HttpRequestHeaders);
        HttpRequestHeaders Bar = default;
    }
}