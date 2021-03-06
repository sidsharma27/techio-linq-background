﻿namespace ExtensionMethods1
{
    public static class ExtensionMethodsExercise1
    {
        public static string DoSayHello(string subject)
        {
            return subject.SayHello();
        }
    }

    // Write the extension method (and containing class) here,
    // following the example in the lesson. The method should
    // be called SayHello(), extends string, and returns a string.

    // public ... class ...
    // { }
    //// START SOLUTION ////
    public static class Foo
    {
        public static string SayHello(this string str)
        {
            return $"Hello, {str}!";
        }
    }
    //// END SOLUTION ////
}