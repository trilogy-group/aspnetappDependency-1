using System;

namespace aspnetappDependency
{
    public class TextFromDependencyProvider
    {
        public static string Text { get { return $"This text is from Dependency library \n" +
                                    $"Name:{typeof(TextFromDependencyProvider).Assembly.GetName().FullName} \n" +
                                    $"Version: {typeof(TextFromDependencyProvider).Assembly.GetName().Version}\n" +
                                    $"Location: {typeof(TextFromDependencyProvider).Assembly.Location}"; } }
    }
}
