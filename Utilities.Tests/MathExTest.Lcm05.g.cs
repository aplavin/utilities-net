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
[ExpectedException(typeof(ArgumentNullException))]
public void Lcm05ThrowsArgumentNullException874()
{
    ushort w;
    w = this.Lcm05((ushort[])null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void Lcm05ThrowsInvalidOperationException330()
{
    ushort w;
    ushort[] ws = new ushort[0];
    w = this.Lcm05(ws);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void Lcm05ThrowsInvalidOperationException193()
{
    ushort w;
    ushort[] ws = new ushort[1];
    w = this.Lcm05(ws);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Lcm05381()
{
    ushort w;
    ushort[] ws = new ushort[1];
    ws[0] = (ushort)33;
    w = this.Lcm05(ws);
    Assert.AreEqual<ushort>((ushort)33, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void Lcm05ThrowsInvalidOperationException645()
{
    ushort w;
    ushort[] ws = new ushort[2];
    w = this.Lcm05(ws);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void Lcm05ThrowsInvalidOperationException92()
{
    ushort w;
    ushort[] ws = new ushort[2];
    ws[0] = (ushort)33;
    w = this.Lcm05(ws);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Lcm05614()
{
    ushort w;
    ushort[] ws = new ushort[2];
    ws[0] = (ushort)80;
    ws[1] = (ushort)40;
    w = this.Lcm05(ws);
    Assert.AreEqual<ushort>((ushort)80, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(OverflowException))]
public void Lcm05ThrowsOverflowException805()
{
    ushort w;
    ushort[] ws = new ushort[2];
    ws[0] = (ushort)50179;
    ws[1] = (ushort)50176;
    w = this.Lcm05(ws);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Lcm0590()
{
    ushort w;
    ushort[] ws = new ushort[3];
    ws[0] = (ushort)80;
    ws[1] = (ushort)40;
    ws[2] = (ushort)32;
    w = this.Lcm05(ws);
    Assert.AreEqual<ushort>((ushort)160, w);
}
}