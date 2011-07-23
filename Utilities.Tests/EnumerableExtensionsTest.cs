// <copyright file="EnumerableExtensionsTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using System.Collections;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Using;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for EnumerableExtensions</summary>
[PexClass(typeof(global::EnumerableExtensions))]
[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class EnumerableExtensionsTest
{
    /// <summary>Test stub for Empty(IEnumerable)</summary>
    [PexMethod]
    [PexUseType(typeof(object[]))]
    public bool Empty(IEnumerable source)
    {
        bool result = global::EnumerableExtensions.Empty(source);
        return result;
        // TODO: add assertions to method EnumerableExtensionsTest.Empty(IEnumerable)
    }
}
