using CS.Impl._05_Lambdas;
using System;

public static class MediumLambdas
{
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

    public static Func<int, int, string> GetCompositionAdditionEtHelloWorld()
    {
        var additionFunc = BasicLambdas.GetAdditionFunc();
        var helloWorldFunc = BasicLambdas.GetHelloWorldFunc();

        return null;
    }

    public static Func<int, int> GetRecursiveFunc()
    {
        return null;
    }
}