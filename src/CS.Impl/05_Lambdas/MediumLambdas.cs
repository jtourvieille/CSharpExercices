using CS.Impl._05_Lambdas;
using System;

public static class MediumLambdas
{
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

    public static Func<int, int, string> GetCompositionAdditionEtHelloWorld()
    {
        var additionFunc = BasicLambdas.GetAdditionFunc();
        var helloWorldFunc = BasicLambdas.GetHelloWorldFunc();

        return (a, b) => helloWorldFunc() + additionFunc(a, b);
    }

    public static Func<int, int> GetRecursiveFunc()
    {
        Func<int, int> recursiveFunc = null;
        recursiveFunc = n => n == 0 ? 0 : n + recursiveFunc(n - 1);
        return recursiveFunc;
    }
}