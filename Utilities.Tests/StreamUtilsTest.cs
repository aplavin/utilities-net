// <copyright file="StreamUtilsTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for StreamUtils</summary>
[PexClass(typeof(global::StreamUtils))]
[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class StreamUtilsTest
{
    /// <summary>Test stub for EnumerateLines(TextReader)</summary>
    [PexMethod]
    public IEnumerable<string> EnumerateLines(TextReader reader)
    {
        IEnumerable<string> result = global::StreamUtils.EnumerateLines(reader);
        return result;
        // TODO: add assertions to method StreamUtilsTest.EnumerateLines(TextReader)
    }

    /// <summary>Test stub for GetReader(Stream)</summary>
    [PexMethod]
    public StreamReader GetReader(Stream stream)
    {
        StreamReader result = global::StreamUtils.GetReader(stream);
        return result;
        // TODO: add assertions to method StreamUtilsTest.GetReader(Stream)
    }

    /// <summary>Test stub for GetWriter(Stream)</summary>
    [PexMethod]
    public StreamWriter GetWriter(Stream stream)
    {
        StreamWriter result = global::StreamUtils.GetWriter(stream);
        return result;
        // TODO: add assertions to method StreamUtilsTest.GetWriter(Stream)
    }

    /// <summary>Test stub for ReadToEnd(Stream)</summary>
    [PexMethod]
    public string ReadToEnd(Stream stream)
    {
        string result = global::StreamUtils.ReadToEnd(stream);
        return result;
        // TODO: add assertions to method StreamUtilsTest.ReadToEnd(Stream)
    }

    /// <summary>Test stub for Write(Stream, Byte[])</summary>
    [PexMethod]
    public void Write(Stream stream, byte[] bytes)
    {
        global::StreamUtils.Write(stream, bytes);
        // TODO: add assertions to method StreamUtilsTest.Write(Stream, Byte[])
    }
}
