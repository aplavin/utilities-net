// <copyright file="StringUtilsTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for StringUtils</summary>
[PexClass(typeof(global::StringUtils))]
[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class StringUtilsTest
{
    /// <summary>Test stub for ContainsCi(String, String)</summary>
    [PexMethod]
    public bool ContainsCi(string s, string value)
    {
        bool result = global::StringUtils.ContainsCi(s, value);
        return result;
        // TODO: add assertions to method StringUtilsTest.ContainsCi(String, String)
    }

    /// <summary>Test stub for Count(String, String)</summary>
    [PexMethod(MaxRuns = 20)]
    public int Count(string s, string value)
    {
        int result = global::StringUtils.Count(s, value);
        return result;
        // TODO: add assertions to method StringUtilsTest.Count(String, String)
    }

    /// <summary>Test stub for FormatNamed(String, !!0)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public string FormatNamed<T>(string format, T arg)
    {
        string result = global::StringUtils.FormatNamed<T>(format, arg);
        return result;
        // TODO: add assertions to method StringUtilsTest.FormatNamed(String, !!0)
    }

    /// <summary>Test stub for FormatWith(String, Object[])</summary>
    [PexMethod]
    public string FormatWith(string format, object[] args)
    {
        string result = global::StringUtils.FormatWith(format, args);
        return result;
        // TODO: add assertions to method StringUtilsTest.FormatWith(String, Object[])
    }

    /// <summary>Test stub for GetAfter(String, String)</summary>
    [PexMethod]
    public string GetAfter(string s, string x)
    {
        string result = global::StringUtils.GetAfter(s, x);
        return result;
        // TODO: add assertions to method StringUtilsTest.GetAfter(String, String)
    }

    /// <summary>Test stub for GetBefore(String, String)</summary>
    [PexMethod]
    public string GetBefore(string s, string x)
    {
        string result = global::StringUtils.GetBefore(s, x);
        return result;
        // TODO: add assertions to method StringUtilsTest.GetBefore(String, String)
    }

    /// <summary>Test stub for GetBetween(String, String, String)</summary>
    [PexMethod]
    public string GetBetween(
        string s,
        string left,
        string right
    )
    {
        string result = global::StringUtils.GetBetween(s, left, right);
        return result;
        // TODO: add assertions to method StringUtilsTest.GetBetween(String, String, String)
    }

    /// <summary>Test stub for IsEmpty(String)</summary>
    [PexMethod]
    public bool IsEmpty(string s)
    {
        bool result = global::StringUtils.IsEmpty(s);
        return result;
        // TODO: add assertions to method StringUtilsTest.IsEmpty(String)
    }

    /// <summary>Test stub for IsNullOrEmpty(String)</summary>
    [PexMethod]
    public bool IsNullOrEmpty(string s)
    {
        bool result = global::StringUtils.IsNullOrEmpty(s);
        return result;
        // TODO: add assertions to method StringUtilsTest.IsNullOrEmpty(String)
    }

    /// <summary>Test stub for IsNullOrWhiteSpace(String)</summary>
    [PexMethod]
    public bool IsNullOrWhiteSpace(string s)
    {
        bool result = global::StringUtils.IsNullOrWhiteSpace(s);
        return result;
        // TODO: add assertions to method StringUtilsTest.IsNullOrWhiteSpace(String)
    }

    /// <summary>Test stub for NormalizeSpaces(String)</summary>
    [PexMethod]
    public string NormalizeSpaces(string s)
    {
        string result = global::StringUtils.NormalizeSpaces(s);
        return result;
        // TODO: add assertions to method StringUtilsTest.NormalizeSpaces(String)
    }

    /// <summary>Test stub for Replace(String, Int32, Char)</summary>
    [PexMethod]
    public string Replace(
        string s,
        int index,
        char ch
    )
    {
        string result = global::StringUtils.Replace(s, index, ch);
        return result;
        // TODO: add assertions to method StringUtilsTest.Replace(String, Int32, Char)
    }

    /// <summary>Test stub for TrimLines(String)</summary>
    [PexMethod]
    public string TrimLines(string s)
    {
        string result = global::StringUtils.TrimLines(s);
        return result;
        // TODO: add assertions to method StringUtilsTest.TrimLines(String)
    }
}
