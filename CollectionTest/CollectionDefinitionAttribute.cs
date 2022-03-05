using System;

namespace CollectionTest;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class CollectionDefinitionAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="T:Xunit.CollectionDefinitionAttribute" /> class.
    /// </summary>
    /// <param name="name">The test collection name.</param>
    public CollectionDefinitionAttribute(string name)
    {
    }

    public CollectionDefinitionAttribute(string name, params string[] parameters)
    {
    }

    /// <summary>
    /// Determines whether tests in this collection runs in parallel with any other collections.
    /// </summary>
    public bool DisableParallelization { get; set; }
}