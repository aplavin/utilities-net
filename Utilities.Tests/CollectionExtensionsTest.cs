// <copyright file="CollectionExtensionsTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using System.Collections;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for CollectionExtensions</summary>
[PexClass(typeof(global::CollectionExtensions))]
[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class CollectionExtensionsTest
{
    /// <summary>Test stub for AddRange(IList, IEnumerable)</summary>
    [PexMethod, PexAllowedException(typeof(NotSupportedException))]
    public void AddRange(IList list, IEnumerable source)
    {
        global::CollectionExtensions.AddRange(list, source);
        // TODO: add assertions to method CollectionExtensionsTest.AddRange(IList, IEnumerable)
    }

    /// <summary>Test stub for AddRange(IList, Object[])</summary>
    [PexMethod, PexAllowedException(typeof(NotSupportedException))]
    public void AddRange01(IList list, object[] items)
    {
        global::CollectionExtensions.AddRange(list, items);
        // TODO: add assertions to method CollectionExtensionsTest.AddRange01(IList, Object[])
    }

    /// <summary>Test stub for IsValidIndex(IList, Int32)</summary>
    [PexMethod]
    public bool IsValidIndex(IList list, int index)
    {
        bool result = global::CollectionExtensions.IsValidIndex(list, index);
        return result;
        // TODO: add assertions to method CollectionExtensionsTest.IsValidIndex(IList, Int32)
    }
}
