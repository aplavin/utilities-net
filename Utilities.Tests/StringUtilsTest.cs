// <copyright file="StringUtilsTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using System.Linq;
using System.Text.RegularExpressions;

using FsCheck.Fluent;

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

        PexAssert.AreEqual(s.ToLower().Contains(value.ToLower()), result);

        return result;
    }

    /// <summary>Test for Count(String, String)</summary>
    [PexMethod]
    public int Count(string s, string value)
    {
        if (s != null) PexAssume.TrueForAll(s, ch => char.IsDigit(ch));
        if (value != null) PexAssume.TrueForAll(value, ch => char.IsDigit(ch));

        int result = global::StringUtils.Count(s, value);

        // force Pex test some special cases
        if (result > 0 && value.Length > 1) { }
        if (result > 0 && value.Length > 2 && value.All(c => c == value[0])) { }

        PexAssert.AreEqual((s.Length - s.Replace(value, string.Empty).Length) / value.Length, result);

        return result;
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

    /// <summary>Test for FormatWith(String, Object[])</summary>
    [PexMethod]
    public string FormatWith(string format, object[] args)
    {
        string result = global::StringUtils.FormatWith(format, args);

        PexAssert.AreEqual(string.Format(format, args), result);

        return result;
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
    [PexMethod, PexAllowedException(typeof(NullReferenceException))]
    public bool IsEmpty(string s)
    {
        bool result = global::StringUtils.IsEmpty(s);

        // force Pex to test all cases
        if (result) { }

        PexAssert.AreEqual(s.Length == 0, result);

        return result;
    }

    /// <summary>Test for IsNullOrEmpty(String)</summary>
    [PexMethod]
    public bool IsNullOrEmpty(string s)
    {
        bool result = global::StringUtils.IsNullOrEmpty(s);

        // force Pex to test all cases
        if (result) { }

        PexAssert.AreEqual(string.IsNullOrEmpty(s), result);

        return result;
    }

    /// <summary>Test for IsNullOrWhiteSpace(String)</summary>
    [PexMethod]
    public bool IsNullOrWhiteSpace(string s)
    {
        bool result = global::StringUtils.IsNullOrWhiteSpace(s);

        // force Pex to test all cases
        if (result) { }

        PexAssert.AreEqual(string.IsNullOrWhiteSpace(s), result);

        return result;
    }

    /// <summary>Test stub for NormalizeSpaces(String)</summary>
    [PexMethod]
    public string NormalizeSpaces(string s)
    {
        if (s != null) PexAssume.TrueForAll(s, ch => char.IsLetterOrDigit(ch) || ch == ' ');

        string result = global::StringUtils.NormalizeSpaces(s);

        // force Pex to test some special cases
        if (new Regex(@"^\w{3,5}[^\w]").IsMatch(s)) { }
        if (new Regex(@"[^\w]\w{3,5}$").IsMatch(s)) { }
        if (new Regex(@"[^\w]\w{3,5}[^\w]").IsMatch(s)) { }

        PexAssert.IsFalse(result.Contains("  "));

        return result;
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
