using System;

namespace CollectionTest;

/// <summary>
/// My own copy of <see cref="Xunit.CollectionAttribute"/> that have "AllowMultiple" set to true.
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
public sealed class CollectionAttribute : Attribute
{
    public CollectionAttribute(string name)
    {
    }
}