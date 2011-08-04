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
public void GetAfterThrowsArgumentNullException830()
{
    string s;
    s = this.GetAfter((string)null, (string)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void GetAfterThrowsArgumentNullException278()
{
    string s;
    s = this.GetAfter("", (string)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void GetAfter574()
{
    string s;
    s = this.GetAfter("", "");
    Assert.AreEqual<string>("", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void GetAfterThrowsInvalidOperationException754()
{
    string s;
    s = this.GetAfter("", "\0\0");
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void GetAfterThrowsInvalidOperationException242()
{
    string s;
    s = this.GetAfter("", "\0");
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void GetAfter585()
{
    string s;
    s = this.GetAfter("\0", "\0");
    Assert.AreEqual<string>("", s);
}
}