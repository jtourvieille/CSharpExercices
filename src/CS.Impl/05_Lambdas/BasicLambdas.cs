using System;

namespace CS.Impl._05_Lambdas
{
    public static class BasicLambdas
    {
        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

        public static Func<int, int, int> GetAdditionFunc()
        {
            return (a, b) => a + b;
        }

        public static Func<string> GetHelloWorldFunc()
        {
            return () => "Hello World!";
        }
    }
}