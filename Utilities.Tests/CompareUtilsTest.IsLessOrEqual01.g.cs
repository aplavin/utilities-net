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
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

public partial class CompareUtilsTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::CompareUtilsTest))]
public void IsLessOrEqual01567()
{
    bool b;
    b = this.IsLessOrEqual01<int>(0, 0, (IComparer<int>)null);
    Assert.AreEqual<bool>(true, b);
}
[TestMethod]
[PexGeneratedBy(typeof(global::CompareUtilsTest))]
public void IsLessOrEqual886()
{
    bool b;
    b = this.IsLessOrEqual<int>(0, 0);
    Assert.AreEqual<bool>(true, b);
}
}
