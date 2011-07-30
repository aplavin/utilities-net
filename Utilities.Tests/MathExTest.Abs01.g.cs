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

public partial class MathExTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Abs01284()
{
    int i;
    i = this.Abs01(0);
    Assert.AreEqual<int>(0, i);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(OverflowException))]
public void Abs01ThrowsOverflowException719()
{
    int i;
    i = this.Abs01(int.MinValue);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Abs01726()
{
    int i;
    i = this.Abs01(-1);
    Assert.AreEqual<int>(1, i);
}
}
