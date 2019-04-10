using System;

/*
 * source: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
 */

class NullCoalescingOperator
{
    static int? GetNullableInt()
    {
        return null;
    }

    static string GetStringValue()
    {
        return null;
    }

    static void Main()
    {
        // int? allow variable x to be null
        // reference types can be null
        int? x = null;

        // Set y to the value of x if x is NOT null; otherwise,
        // if x == null, set y to -1.
        int y = x ?? -1;
        Console.WriteLine(y);

        // Assign i to return value of the method if the method's result
        // is NOT null; otherwise, if the result is null, set i to the
        // default value of int.
        int i = GetNullableInt() ?? default(int);
        Console.WriteLine(i);

        string s = GetStringValue();
        // Display the value of s if s is NOT null; otherwise, 
        // display the string "Unspecified".
        Console.WriteLine(s ?? "Unspecified");
    }
}