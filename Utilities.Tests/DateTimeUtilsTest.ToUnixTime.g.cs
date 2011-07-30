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
using Microsoft.Pex.Framework.Exceptions;

public partial class DateTimeUtilsTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::DateTimeUtilsTest))]
public void ToUnixTime349()
{
    long l;
    l = this.ToUnixTime(default(DateTime), false);
    Assert.AreEqual<long>(-62135596800L, l);
}
[TestMethod]
[PexGeneratedBy(typeof(global::DateTimeUtilsTest))]
public void ToUnixTime381()
{
    long l;
    l = this.ToUnixTime(default(DateTime), true);
    Assert.AreEqual<long>(-62135596800000L, l);
}
[TestMethod]
[PexGeneratedBy(typeof(global::DateTimeUtilsTest))]
public void ToUnixTime155()
{
    long l;
    l = this.ToUnixTime(new DateTime(4611686018427387903L & 621496748577128448L, 
                                     (DateTimeKind)(621496748577128448uL >> 62)), false);
    Assert.AreEqual<long>(14078057L, l);
}
[TestMethod]
[PexGeneratedBy(typeof(global::DateTimeUtilsTest))]
public void ToUnixTime262()
{
    long l;
    l = this.ToUnixTime(new DateTime(4611686018427387903L & -8628055597590526420L, 
                                     (DateTimeKind)(9818688476119025196uL >> 62)), false);
    Assert.AreEqual<long>(-2603952874L, l);
}
}
