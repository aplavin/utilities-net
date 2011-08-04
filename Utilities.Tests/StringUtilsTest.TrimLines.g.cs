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
public void TrimLinesThrowsArgumentNullException891()
{
    string s;
    s = this.TrimLines((string)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void TrimLines578()
{
    string s;
    s = this.TrimLines("");
    Assert.AreEqual<string>("", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void TrimLines395()
{
    string s;
    s = this.TrimLines("\0");
    Assert.AreEqual<string>("\0", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void TrimLines655()
{
    string s;
    s = this.TrimLines("\n");
    Assert.AreEqual<string>("", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void TrimLines721()
{
    string s;
    s = this.TrimLines("\0\n");
    Assert.AreEqual<string>("\0", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void TrimLines107()
{
    string s;
    s = this.TrimLines("\0\n\0");
    Assert.AreEqual<string>("\0\n\0", s);
}
}