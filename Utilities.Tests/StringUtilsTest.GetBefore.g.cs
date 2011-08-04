// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

public partial class StringUtilsTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void GetBeforeThrowsArgumentNullException109()
{
    string s;
    s = this.GetBefore((string)null, (string)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void GetBeforeThrowsArgumentNullException560()
{
    string s;
    s = this.GetBefore("", (string)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void GetBefore574()
{
    string s;
    s = this.GetBefore("", "");
    Assert.AreEqual<string>("", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void GetBeforeThrowsInvalidOperationException174()
{
    string s;
    s = this.GetBefore("", "\0\0");
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void GetBeforeThrowsInvalidOperationException401()
{
    string s;
    s = this.GetBefore("", "\0");
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void GetBefore585()
{
    string s;
    s = this.GetBefore("\0", "\0");
    Assert.AreEqual<string>("", s);
}
}