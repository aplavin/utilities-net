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

public partial class GenericEnumerableExtensionsTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
public void Aggregate533()
{
    string s;
    int[] ints = new int[1];
    s = this.Aggregate<int>((IEnumerable<int>)ints, "", "");
    Assert.AreEqual<string>("", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void Aggregate01ThrowsArgumentNullException79()
{
    string s;
    int[] ints = new int[0];
    s = this.Aggregate01<int, int>
            ((IEnumerable<int>)ints, (Func<int, int>)null, "", "");
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void Aggregate01ThrowsArgumentNullException770()
{
    string s;
    int[] ints = new int[0];
    s = this.Aggregate01<int, int>
            ((IEnumerable<int>)ints, (Func<int, int>)null, "", (string)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void Aggregate01ThrowsArgumentNullException637()
{
    string s;
    int[] ints = new int[0];
    s = this.Aggregate01<int, int>
            ((IEnumerable<int>)ints, (Func<int, int>)null, (string)null, (string)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void Aggregate01ThrowsArgumentNullException449()
{
    string s;
    s = this.Aggregate01<int, int>
            ((IEnumerable<int>)null, (Func<int, int>)null, (string)null, (string)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
public void Aggregate01576()
{
    object o;
    string s;
    o = FuncFactory.Create();
    int[] ints = new int[0];
    s =
      this.Aggregate01<int, int>((IEnumerable<int>)ints, (Func<int, int>)o, "", "");
    Assert.AreEqual<string>("", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
public void Aggregate01181()
{
    object o;
    string s;
    o = FuncFactory.Create();
    int[] ints = new int[1];
    s =
      this.Aggregate01<int, int>((IEnumerable<int>)ints, (Func<int, int>)o, "", "");
    Assert.AreEqual<string>("", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
public void Aggregate01705()
{
    object o;
    string s;
    o = FuncFactory.Create();
    int[] ints = new int[2];
    s =
      this.Aggregate01<int, int>((IEnumerable<int>)ints, (Func<int, int>)o, "", "");
    Assert.AreEqual<string>("", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
public void Aggregate01764()
{
    object o;
    string s;
    o = FuncFactory.Create();
    int[] ints = new int[5];
    s =
      this.Aggregate01<int, int>((IEnumerable<int>)ints, (Func<int, int>)o, "", "");
    Assert.AreEqual<string>("", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
public void Aggregate43101()
{
    string s;
    int[] ints = new int[2];
    s = this.Aggregate<int>((IEnumerable<int>)ints, "", "");
    Assert.AreEqual<string>("", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
public void Aggregate88001()
{
    string s;
    int[] ints = new int[0];
    s = this.Aggregate<int>((IEnumerable<int>)ints, "", "");
    Assert.AreEqual<string>("", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void AggregateThrowsArgumentNullException771()
{
    string s;
    int[] ints = new int[0];
    s = this.Aggregate<int>((IEnumerable<int>)ints, (string)null, (string)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void AggregateThrowsArgumentNullException817()
{
    string s;
    int[] ints = new int[0];
    s = this.Aggregate<int>((IEnumerable<int>)ints, "", (string)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void AggregateThrowsArgumentNullException590()
{
    string s;
    s = this.Aggregate<int>((IEnumerable<int>)null, (string)null, (string)null);
}
}
