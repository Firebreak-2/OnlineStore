using System;

namespace AvaloniaTestApp;

public static class Extensions
{
    public static TOutput Pipe<TInput, TOutput>(this TInput input, Func<TInput, TOutput> action) => action(input);
}