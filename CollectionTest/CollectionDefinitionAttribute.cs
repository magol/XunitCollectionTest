using System;

namespace CollectionTest;

/// <summary>
/// My own copy of <see cref="Xunit.CollectionDefinitionAttribute"/> that have "AllowMultiple" set to true and a second constructor for parameters.
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
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