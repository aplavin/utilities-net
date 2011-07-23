// <copyright file="GenericCollectionExtensionsTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for GenericCollectionExtensions</summary>
[PexClass(typeof(global::GenericCollectionExtensions))]
[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class GenericCollectionExtensionsTest
{
    /// <summary>Test stub for AddRange(ICollection`1&lt;!!0&gt;, IEnumerable`1&lt;!!0&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod, PexAllowedException(typeof(NotSupportedException))]
    public void AddRange<TSource>(ICollection<TSource> collection, IEnumerable<TSource> source)
    {
        global::GenericCollectionExtensions.AddRange<TSource>(collection, source);
        // TODO: add assertions to method GenericCollectionExtensionsTest.AddRange(ICollection`1<!!0>, IEnumerable`1<!!0>)
    }

    /// <summary>Test stub for AddRange(ICollection`1&lt;!!0&gt;, !!0[])</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod, PexAllowedException(typeof(NotSupportedException))]
    public void AddRange01<TSource>(ICollection<TSource> collection, TSource[] items)
    {
        global::GenericCollectionExtensions.AddRange<TSource>(collection, items);
        // TODO: add assertions to method GenericCollectionExtensionsTest.AddRange01(ICollection`1<!!0>, !!0[])
    }

    /// <summary>Test stub for Invert(IEnumerable`1&lt;KeyValuePair`2&lt;!!0,!!1&gt;&gt;)</summary>
    [PexGenericArguments(typeof(int), typeof(int))]
    [PexMethod, PexAllowedException(typeof(ArgumentException))]
    public Dictionary<TValue, TKey> Invert<TKey,TValue>(IEnumerable<KeyValuePair<TKey, TValue>> source)
    {
        Dictionary<TValue, TKey> result
           = global::GenericCollectionExtensions.Invert<TKey, TValue>(source);
        return result;
        // TODO: add assertions to method GenericCollectionExtensionsTest.Invert(IEnumerable`1<KeyValuePair`2<!!0,!!1>>)
    }

    /// <summary>Test stub for IsValidIndex(IList`1&lt;!!0&gt;, Int32)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public bool IsValidIndex<TSource>(IList<TSource> list, int index)
    {
        bool result
           = global::GenericCollectionExtensions.IsValidIndex<TSource>(list, index);
        return result;
        // TODO: add assertions to method GenericCollectionExtensionsTest.IsValidIndex(IList`1<!!0>, Int32)
    }
}
