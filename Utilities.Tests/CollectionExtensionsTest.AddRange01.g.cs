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

public partial class CollectionExtensionsTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void AddRange01ThrowsArgumentNullException948()
{
    ICollection<int> iCollection;
    iCollection = this.AddRange01((ICollection<int>)null, (int[])null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void AddRange01ThrowsArgumentNullException450()
{
    ICollection<int> iCollection;
    int[] ints = new int[0];
    iCollection = this.AddRange01((ICollection<int>)ints, (int[])null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
public void AddRange0197()
{
    ICollection<int> iCollection;
    int[] ints = new int[0];
    int[] ints1 = new int[0];
    iCollection = this.AddRange01((ICollection<int>)ints, ints1);
    Assert.IsNotNull((object)iCollection);
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
[ExpectedException(typeof(NotSupportedException))]
public void AddRange01ThrowsNotSupportedException321()
{
    ICollection<int> iCollection;
    int[] ints = new int[0];
    int[] ints1 = new int[1];
    iCollection = this.AddRange01((ICollection<int>)ints, ints1);
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
public void AddRange01490()
{
    ICollection<int> iCollection;
    int[] ints = new int[2];
    int[] ints1 = new int[0];
    iCollection = this.AddRange01((ICollection<int>)ints, ints1);
    Assert.IsNotNull((object)iCollection);
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void AddRangeThrowsArgumentNullException99()
{
    ICollection<int> iCollection;
    iCollection = this.AddRange<int>((ICollection<int>)null, (IEnumerable<int>)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void AddRangeThrowsArgumentNullException551()
{
    ICollection<int> iCollection;
    int[] ints = new int[0];
    iCollection = this.AddRange<int>((ICollection<int>)ints, (IEnumerable<int>)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
public void AddRange818()
{
    ICollection<int> iCollection;
    int[] ints = new int[0];
    int[] ints1 = new int[0];
    iCollection =
      this.AddRange<int>((ICollection<int>)ints, (IEnumerable<int>)ints1);
    Assert.IsNotNull((object)iCollection);
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
[ExpectedException(typeof(NotSupportedException))]
public void AddRangeThrowsNotSupportedException541()
{
    ICollection<int> iCollection;
    int[] ints = new int[0];
    int[] ints1 = new int[1];
    iCollection =
      this.AddRange<int>((ICollection<int>)ints, (IEnumerable<int>)ints1);
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
public void AddRange415()
{
    ICollection<int> iCollection;
    int[] ints = new int[2];
    int[] ints1 = new int[0];
    iCollection =
      this.AddRange<int>((ICollection<int>)ints, (IEnumerable<int>)ints1);
    Assert.IsNotNull((object)iCollection);
}
}
