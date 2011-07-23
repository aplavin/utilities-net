// <copyright file="CompareUtilsTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for CompareUtils</summary>
[PexClass(typeof(global::CompareUtils))]
[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class CompareUtilsTest
{
    /// <summary>Test stub for Clamp(!!0, !!0, !!0)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public T Clamp<T>(
        T value,
        T min,
        T max
    )
    {
        T result = global::CompareUtils.Clamp<T>(value, min, max);
        return result;
        // TODO: add assertions to method CompareUtilsTest.Clamp(!!0, !!0, !!0)
    }

    /// <summary>Test stub for Clamp(!!0, !!0, !!0, IComparer`1&lt;!!0&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public T Clamp01<T>(
        T value,
        T min,
        T max,
        IComparer<T> comparer
    )
    {
        T result = global::CompareUtils.Clamp<T>(value, min, max, comparer);
        return result;
        // TODO: add assertions to method CompareUtilsTest.Clamp01(!!0, !!0, !!0, IComparer`1<!!0>)
    }

    /// <summary>Test stub for InRange(!!0, !!0, !!0)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public bool InRange<T>(
        T value,
        T min,
        T max
    )
    {
        bool result = global::CompareUtils.InRange<T>(value, min, max);
        return result;
        // TODO: add assertions to method CompareUtilsTest.InRange(!!0, !!0, !!0)
    }

    /// <summary>Test stub for InRange(!!0, !!0, !!0, IComparer`1&lt;!!0&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public bool InRange01<T>(
        T value,
        T min,
        T max,
        IComparer<T> comparer
    )
    {
        bool result = global::CompareUtils.InRange<T>(value, min, max, comparer);
        return result;
        // TODO: add assertions to method CompareUtilsTest.InRange01(!!0, !!0, !!0, IComparer`1<!!0>)
    }

    /// <summary>Test stub for IsGreater(!!0, !!0)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public bool IsGreater<T>(T x, T y)
    {
        bool result = global::CompareUtils.IsGreater<T>(x, y);
        return result;
        // TODO: add assertions to method CompareUtilsTest.IsGreater(!!0, !!0)
    }

    /// <summary>Test stub for IsGreater(!!0, !!0, IComparer`1&lt;!!0&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public bool IsGreater01<T>(
        T x,
        T y,
        IComparer<T> comparer
    )
    {
        bool result = global::CompareUtils.IsGreater<T>(x, y, comparer);
        return result;
        // TODO: add assertions to method CompareUtilsTest.IsGreater01(!!0, !!0, IComparer`1<!!0>)
    }

    /// <summary>Test stub for IsGreaterOrEqual(!!0, !!0)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public bool IsGreaterOrEqual<T>(T x, T y)
    {
        bool result = global::CompareUtils.IsGreaterOrEqual<T>(x, y);
        return result;
        // TODO: add assertions to method CompareUtilsTest.IsGreaterOrEqual(!!0, !!0)
    }

    /// <summary>Test stub for IsGreaterOrEqual(!!0, !!0, IComparer`1&lt;!!0&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public bool IsGreaterOrEqual01<T>(
        T x,
        T y,
        IComparer<T> comparer
    )
    {
        bool result = global::CompareUtils.IsGreaterOrEqual<T>(x, y, comparer);
        return result;
        // TODO: add assertions to method CompareUtilsTest.IsGreaterOrEqual01(!!0, !!0, IComparer`1<!!0>)
    }

    /// <summary>Test stub for IsLess(!!0, !!0)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public bool IsLess<T>(T x, T y)
    {
        bool result = global::CompareUtils.IsLess<T>(x, y);
        return result;
        // TODO: add assertions to method CompareUtilsTest.IsLess(!!0, !!0)
    }

    /// <summary>Test stub for IsLess(!!0, !!0, IComparer`1&lt;!!0&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public bool IsLess01<T>(
        T x,
        T y,
        IComparer<T> comparer
    )
    {
        bool result = global::CompareUtils.IsLess<T>(x, y, comparer);
        return result;
        // TODO: add assertions to method CompareUtilsTest.IsLess01(!!0, !!0, IComparer`1<!!0>)
    }

    /// <summary>Test stub for IsLessOrEqual(!!0, !!0)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public bool IsLessOrEqual<T>(T x, T y)
    {
        bool result = global::CompareUtils.IsLessOrEqual<T>(x, y);
        return result;
        // TODO: add assertions to method CompareUtilsTest.IsLessOrEqual(!!0, !!0)
    }

    /// <summary>Test stub for IsLessOrEqual(!!0, !!0, IComparer`1&lt;!!0&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public bool IsLessOrEqual01<T>(
        T x,
        T y,
        IComparer<T> comparer
    )
    {
        bool result = global::CompareUtils.IsLessOrEqual<T>(x, y, comparer);
        return result;
        // TODO: add assertions to method CompareUtilsTest.IsLessOrEqual01(!!0, !!0, IComparer`1<!!0>)
    }
}
