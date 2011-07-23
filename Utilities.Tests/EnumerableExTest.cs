// <copyright file="EnumerableExTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for EnumerableEx</summary>
[PexClass(typeof(global::EnumerableEx))]
[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class EnumerableExTest
{
    /// <summary>Test stub for MakeEnumerable(!!0)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public IEnumerable<TSource> MakeEnumerable<TSource>(TSource item)
    {
        IEnumerable<TSource> result = global::EnumerableEx.MakeEnumerable<TSource>(item)
          ;
        return result;
        // TODO: add assertions to method EnumerableExTest.MakeEnumerable(!!0)
    }

    /// <summary>Test stub for MakeEnumerable(!!0[])</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public IEnumerable<TSource> MakeEnumerable01<TSource>(TSource[] items)
    {
        IEnumerable<TSource> result
           = global::EnumerableEx.MakeEnumerable<TSource>(items);
        return result;
        // TODO: add assertions to method EnumerableExTest.MakeEnumerable01(!!0[])
    }
}
