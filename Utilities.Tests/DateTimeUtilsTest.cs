// <copyright file="DateTimeUtilsTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for DateTimeUtils</summary>
[PexClass(typeof(global::DateTimeUtils))]
[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class DateTimeUtilsTest
{
    /// <summary>Test stub for CalculateAge(DateTime)</summary>
    [PexMethod]
    public int CalculateAge(DateTime birthDate)
    {
        int result = global::DateTimeUtils.CalculateAge(birthDate);
        return result;
        // TODO: add assertions to method DateTimeUtilsTest.CalculateAge(DateTime)
    }

    /// <summary>Test stub for CalculateAge(DateTime, DateTime)</summary>
    [PexMethod]
    public int CalculateAge01(DateTime birthDate, DateTime referenceDate)
    {
        int result = global::DateTimeUtils.CalculateAge(birthDate, referenceDate);
        return result;
        // TODO: add assertions to method DateTimeUtilsTest.CalculateAge01(DateTime, DateTime)
    }

    /// <summary>Test stub for DaysInMonth(DateTime)</summary>
    [PexMethod]
    public int DaysInMonth(DateTime date)
    {
        int result = global::DateTimeUtils.DaysInMonth(date);
        return result;
        // TODO: add assertions to method DateTimeUtilsTest.DaysInMonth(DateTime)
    }

    /// <summary>Test stub for FromUnixTime(Int64, Boolean)</summary>
    [PexMethod, PexAllowedException(typeof(OverflowException))]
    public DateTime FromUnixTime(long unixTime, bool withMilliseconds)
    {
        DateTime result = global::DateTimeUtils.FromUnixTime(unixTime, withMilliseconds)
          ;
        return result;
        // TODO: add assertions to method DateTimeUtilsTest.FromUnixTime(Int64, Boolean)
    }

    /// <summary>Test stub for ToUnixTime(DateTime, Boolean)</summary>
    [PexMethod]
    public long ToUnixTime(DateTime dateTime, bool withMilliseconds)
    {
        long result = global::DateTimeUtils.ToUnixTime(dateTime, withMilliseconds);
        return result;
        // TODO: add assertions to method DateTimeUtilsTest.ToUnixTime(DateTime, Boolean)
    }

    /// <summary>Test stub for UtcOffset</summary>
    [PexMethod]
    public void UtcOffsetGet()
    {
        double result = global::DateTimeUtils.UtcOffset;
        // TODO: add assertions to method DateTimeUtilsTest.UtcOffsetGet()
    }
}
